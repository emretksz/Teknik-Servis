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
    public partial class FaultTypeFrm : Form
    {
        public FaultTypeFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;
        int id = 0;
        TechnicalServiceContext db = new TechnicalServiceContext();
        private void FaultTypeFrm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;
            var faultTypeDataList = db.FaultTypes.ToList();
            dgvFaultTypes.DataSource = faultTypeDataList;
            dgvFaultTypes.Columns[0].Visible = false;
            dgvFaultTypes.Columns[4].Visible = false;
            dgvFaultTypes.Columns[3].Visible = false;
            dgvFaultTypes.Columns[2].Visible = false;
            dgvFaultTypes.Columns[1].HeaderText = "Adı";
            dgvFaultTypes.Columns.Add("RegisterDate", "Kayıt Tarihi");
            dgvFaultTypes.Columns.Add("IsActive", "Durumu");
            for (int i = 0; i < faultTypeDataList.Count; i++)
            {
                dgvFaultTypes.Rows[i].Cells[5].Value = faultTypeDataList[i].RegisterDate.ToString("dd.MM.yyyy hh:mm");
                dgvFaultTypes.Rows[i].Cells[6].Value = faultTypeDataList[i].IsActive ? "Aktif" : "Pasif";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FaultTypes faultTypes = new FaultTypes();
            faultTypes.Name = txtName.Text;
            faultTypes.IsActive = chkIsActive.Checked;
            faultTypes.RegisterDate = DateTime.Now;
            db.FaultTypes.Add(faultTypes);
            db.SaveChanges();
            MessageBox.Show("Başarıyla eklenmiştir.");
            dgvFaultTypes.DataSource = db.FaultTypes.ToList();
        }

        private void dgvFaultTypes_DoubleClick(object sender, EventArgs e)
        {
            var faultType = dgvFaultTypes.SelectedRows[0].DataBoundItem as FaultTypes;
            id = faultType.FaultTypeId;
            txtName.Text = faultType.Name;
            chkIsActive.Checked = faultType.IsActive;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FaultTypes faultTypeUpdate = db.FaultTypes.Find(id);
            faultTypeUpdate.Name = txtName.Text;
            faultTypeUpdate.IsActive = chkIsActive.Checked;
            db.SaveChanges();
            MessageBox.Show("Başarıyla güncellenmiştir.");
            dgvFaultTypes.DataSource = db.FaultTypes.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var faultType = dgvFaultTypes.SelectedRows[0].DataBoundItem as FaultTypes;
            db.FaultTypes.Remove(faultType);
            db.SaveChanges();
            MessageBox.Show("Başarıyla silinmiştir.");
            dgvFaultTypes.DataSource = db.FaultTypes.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductsFrm frm = new ProductsFrm(user);
            this.Close();
            frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var searchDataList= db.FaultTypes.Where(f=>f.Name.Contains(search)).ToList();
            dgvFaultTypes.DataSource = searchDataList;
        }
    }
}
