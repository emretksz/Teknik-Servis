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
    public partial class ProductEditFrm : Form
    {
        public ProductEditFrm(Models.Entities.Users users,int productId)
        {
            InitializeComponent();
            user = users;
            this.productId = productId;
        }
        Models.Entities.Users user;
        int productId = 0;
        TechnicalServiceContext db = new TechnicalServiceContext();
        private void ProductEditFrm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;
            Products products = db.Products.Find(productId);
            lblProductNumber.Text = products.ProductNumber;
            cmbProductType.DataSource = db.ProductTypes.Where(p => p.IsActive == true).ToList();
            cmbProductType.DisplayMember = "Name";
            cmbProductType.ValueMember = "ProductTypeId";
            cmbProductType.SelectedValue = products.ProductTypeId;
            txtProductName.Text = products.Name;
            txtDeliveryCustomer.Text = products.DeliveryCustomer;
            cmbDeliveryUsers.DataSource = db.Users.Where(u => u.IsActive == true).ToList();
            cmbDeliveryUsers.DisplayMember = "NameSurname";
            cmbDeliveryUsers.ValueMember = "UserId";
            cmbDeliveryUsers.SelectedValue = products.UserId;
            if (products.IsBoxed)
                rdbBoxing.Checked = true;
            else
                rdbUnBoxing.Checked = true;
            dtpDeliveryDate.Value = products.TakeDate;

            lstFaultTypes.DataSource = db.FaultTypes.Where(f => f.IsActive == true).ToList();
            lstFaultTypes.DisplayMember = "Name";
            lstFaultTypes.ValueMember = "FaultTypeId";
            foreach (var faults in products.FaultTypes)
            {
                lstFaultTypes.SelectedValue = faults.FaultTypeId;
            }

            cmbRepairStatus.DataSource = db.RepairSituations.Where(r => r.IsActive == true).ToList();
            cmbRepairStatus.DisplayMember = "Name";
            cmbRepairStatus.ValueMember = "RepairStatusId";
            txtDescription.Text = products.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductsFrm frm = new ProductsFrm(user);
            this.Close();
            frm.Show();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            Products productUpdate = db.Products.Find(productId);
            productUpdate.ProductTypeId = Convert.ToInt32(cmbProductType.SelectedValue);
            productUpdate.Name = txtProductName.Text;
            productUpdate.DeliveryCustomer = txtDeliveryCustomer.Text;
            productUpdate.UserId= Convert.ToInt32(cmbDeliveryUsers.SelectedValue);
            productUpdate.IsBoxed = rdbBoxing.Checked ? true : false;
            productUpdate.TakeDate = dtpDeliveryDate.Value;
            productUpdate.FaultTypes.Clear();
            foreach (var item in lstFaultTypes.SelectedItems)
            {
                var faults = item as FaultTypes;
                productUpdate.FaultTypes.Add(faults);
            }
            productUpdate.RepairStatusId = Convert.ToInt32(cmbRepairStatus.SelectedValue);
            productUpdate.Description = txtDescription.Text;
            db.SaveChanges();
            MessageBox.Show("Başarıyla güncellenmiştir.");
            ProductsFrm frm = new ProductsFrm(user);
            this.Close();
            frm.Show();
        }
    }
}
