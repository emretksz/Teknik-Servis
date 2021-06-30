using EFFiveSessionWindowsFormApp.Models.Entities;
using EFFiveSessionWindowsFormApp.Views.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFFiveSessionWindowsFormApp.Views.Product
{
    public partial class ProductsFrm : Form
    {
        public ProductsFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;
        TechnicalServiceContext db = new TechnicalServiceContext();
        private void ProductsFrm_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;
            cmbDeliveryUsers.Enabled = user.isRole ? true : false;
            Random rnd = new Random();
            int rndNumber = rnd.Next(1000, 10000);
            lblProductNumber.Text = rndNumber.ToString();
            cmbProductType.DataSource = db.ProductTypes.Where(p => p.IsActive == true).ToList();
            cmbProductType.DisplayMember = "Name";
            cmbProductType.ValueMember = "ProductTypeId";
            cmbDeliveryUsers.DataSource = db.Users.Where(u => u.IsActive == true).ToList();
            cmbDeliveryUsers.DisplayMember = "NameSurname";
            cmbDeliveryUsers.ValueMember = "UserId";
            lstFaultTypes.DataSource = db.FaultTypes.Where(f => f.IsActive == true).ToList();
            lstFaultTypes.DisplayMember = "Name";
            lstFaultTypes.ValueMember = "FaultTypeId";
            //clstFaultTypes.Items.AddRange(db.FaultTypes.ToArray());
            var productDataList = db.Products.Where(p => p.RepairStatusId == null).ToList();
            dgvProducts.DataSource = productDataList;
            dgvProducts.Columns[0].Visible = false;
            dgvProducts.Columns[1].Visible = false;
            dgvProducts.Columns[2].Visible = false;
            dgvProducts.Columns[3].Visible = false;
            dgvProducts.Columns[4].HeaderText = "Ürün Adı";
            dgvProducts.Columns[5].HeaderText = "Ürün No";
            dgvProducts.Columns[6].HeaderText = "Teslim Eden";
            dgvProducts.Columns[7].HeaderText = "Kutu Durumu";
            dgvProducts.Columns[8].HeaderText = "Alınma Tarihi";
            dgvProducts.Columns[9].HeaderText = "Açıklama";
            dgvProducts.Columns[10].Visible = false;//Ürün Tipi
            dgvProducts.Columns[11].Visible = false;//Tamir Durumu
            dgvProducts.Columns[12].Visible = false;//Teslim Alan
            dgvProducts.Columns[13].Visible = false;//Arıza Tipi
            dgvProducts.Columns.Add("ProductTypeId", "Ürün Tipi");
            dgvProducts.Columns.Add("RepairStatusId", "Tamir Durumu");
            dgvProducts.Columns.Add("UserId", "Teslim Alan");
            dgvProducts.Columns.Add("FaultTypes", "Arıza Tipi");
            for (int i = 0; i < productDataList.Count; i++)
            {
                dgvProducts.Rows[i].Cells[14].Value = productDataList[i].ProductTypes.Name;
                dgvProducts.Rows[i].Cells[15].Value = productDataList[i].RepairSituations.Name;
                dgvProducts.Rows[i].Cells[16].Value = productDataList[i].Users.NameSurname;
                foreach (var item in productDataList[i].FaultTypes)
                {
                    dgvProducts.Rows[i].Cells[17].Value += item.Name+ ", ";

                }
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuFrm frm = new MainMenuFrm(user);
            this.Close();
            frm.Show();
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            ProductTypeFrm frm = new ProductTypeFrm(user);
            this.Close();
            frm.Show();
        }

        private void btnFaultType_Click(object sender, EventArgs e)
        {
            FaultTypeFrm frm = new FaultTypeFrm(user);
            this.Close();
            frm.Show();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ProductNumber = lblProductNumber.Text;
            products.ProductTypeId = Convert.ToInt32(cmbProductType.SelectedValue);
            products.Name = txtProductName.Text;
            products.DeliveryCustomer = txtDeliveryCustomer.Text;
            products.UserId = Convert.ToInt32(cmbDeliveryUsers.SelectedValue);
            products.IsBoxed = rdbBoxing.Checked ? true : false;
            products.TakeDate = dtpDeliveryDate.Value;
            foreach (var faultType in lstFaultTypes.SelectedItems)
            {
                var faultItem = faultType as FaultTypes;
                products.FaultTypes.Add(faultItem);
            }
            db.Products.Add(products);
            db.SaveChanges();
            MessageBox.Show("Başarıyla eklenmiştir.");
            dgvProducts.DataSource = db.Products.ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count!=0)
            {
                var product = dgvProducts.SelectedRows[0].DataBoundItem as Products;
                ProductEditFrm frm = new ProductEditFrm(user, product.ProductId);
                this.Close();
                frm.Show(); 
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.");
            }
        }

        private void btnRepairStatus_Click(object sender, EventArgs e)
        {
            RepairTypesFrm frm = new RepairTypesFrm(user);
            this.Close();
            frm.Show();
        }

        private void btnEditProductList_Click(object sender, EventArgs e)
        {
            EditProductListFrm frm = new EditProductListFrm(user);
            this.Close();
            frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var searchDataList = db.Products.Where(p => p.Name.Contains(search) && p.RepairStatusId == null).ToList();
            dgvProducts.DataSource = searchDataList;
        }
    }
}
