using EFFiveSessionWindowsFormApp.Models.Entities;
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
    public partial class EditProductListFrm : Form
    {
        public EditProductListFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;
        TechnicalServiceContext db = new TechnicalServiceContext();
        private void EditProductListFrm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;
            var productDataList = db.Products.Where(p => p.RepairStatusId != null).ToList();
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
                    dgvProducts.Rows[i].Cells[17].Value += item.Name + ", ";

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductsFrm frm = new ProductsFrm(user);
            this.Close();
            frm.Show();
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
                MessageBox.Show("Bir satır seçiniz.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var searchDataList = db.Products.Where(p => p.RepairStatusId != null&&p.Name.Contains(search)|| p.ProductNumber.Contains(search)).ToList();
            dgvProducts.DataSource = searchDataList;
        }
    }
}
