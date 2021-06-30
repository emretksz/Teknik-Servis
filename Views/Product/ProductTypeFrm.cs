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
    public partial class ProductTypeFrm : Form
    {
        public ProductTypeFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;
        int id = 0;
        TechnicalServiceContext db = new TechnicalServiceContext();
        private void ProductTypeFrm_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;
            var productTypeDataList= db.ProductTypes.ToList();
            dgvProductTypes.DataSource = productTypeDataList;
            dgvProductTypes.Columns[0].Visible = false;
            dgvProductTypes.Columns[4].Visible = false;
            dgvProductTypes.Columns[3].Visible = false;
            dgvProductTypes.Columns[2].Visible = false;
            dgvProductTypes.Columns[1].HeaderText = "Adı";
            dgvProductTypes.Columns.Add("RegisterDate", "Kayıt Tarihi");
            dgvProductTypes.Columns.Add("IsActive", "Durumu");
            for (int i = 0; i < productTypeDataList.Count; i++)
            {
                dgvProductTypes.Rows[i].Cells[5].Value = productTypeDataList[i].RegisterDate.ToString("dd.MM.yyyy hh:mm");
                dgvProductTypes.Rows[i].Cells[6].Value = productTypeDataList[i].IsActive ? "Aktif" : "Pasif";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTypes productTypes = new ProductTypes();
                productTypes.Name = txtName.Text;
                productTypes.IsActive = chkIsActive.Checked;
                productTypes.RegisterDate = DateTime.Now;
                db.ProductTypes.Add(productTypes);
                db.SaveChanges();
                MessageBox.Show("Başarıyla Eklenmiştir.");
                dgvProductTypes.DataSource = db.ProductTypes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu. Sorun: "+ ex.Message);
            }
        }

        private void dgvProductTypes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductTypes.SelectedRows.Count!=0)
            {
                var productType = dgvProductTypes.SelectedRows[0].DataBoundItem as ProductTypes;
                txtName.Text = productType.Name;
                chkIsActive.Checked = productType.IsActive;
                id = productType.ProductTypeId; 
            }
            else
            {
                MessageBox.Show("Bir satır seçiniz.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductTypes productTypeUpdate = db.ProductTypes.Find(id);
            productTypeUpdate.Name = txtName.Text;
            productTypeUpdate.IsActive = chkIsActive.Checked;
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi.");
            dgvProductTypes.DataSource = db.ProductTypes.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var productType = dgvProductTypes.SelectedRows[0].DataBoundItem as ProductTypes;
            db.ProductTypes.Remove(productType);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Silindi.");
            dgvProductTypes.DataSource = db.ProductTypes.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductsFrm frm = new ProductsFrm(user);
            this.Close();
            frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                var productTypeList = db.ProductTypes.Where(p => p.Name.Contains(search)).ToList();
                dgvProductTypes.DataSource = productTypeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Sorun oluştu. Sorun: "+ex.Message+"\nUzun Cevap: "+ex.StackTrace);
            }
        }
    }
}
