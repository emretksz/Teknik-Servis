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
    public partial class RepairTypesFrm : Form
    {
        public RepairTypesFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;
        int id = 0;
        TechnicalServiceContext db = new TechnicalServiceContext();
        private void RepairTypesFrm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;
            var repairDataList= db.RepairSituations.ToList();
            dgvRepairTypes.DataSource = repairDataList;
            dgvRepairTypes.Columns[0].Visible = false;
            dgvRepairTypes.Columns[4].Visible = false;
            dgvRepairTypes.Columns[3].Visible = false;
            dgvRepairTypes.Columns[2].Visible=false;
            dgvRepairTypes.Columns[1].HeaderText = "Adı";
            //dgvRepairTypes.Columns[2].HeaderText = "Kayıt Tarihi";
            //dgvRepairTypes.Columns[3].HeaderText = "Durumu";
            dgvRepairTypes.Columns.Add("RegisterDate","Kayıt Tarihi");
            dgvRepairTypes.Columns.Add("IsActive", "Durumu");
            for (int i = 0; i < repairDataList.Count; i++)
            {
                dgvRepairTypes.Rows[i].Cells[5].Value = repairDataList[i].RegisterDate.ToString("dd.MM.yyyy hh:mm");
                dgvRepairTypes.Rows[i].Cells[6].Value = repairDataList[i].IsActive ? "Aktif" : "Pasif";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RepairSituations repairSituations = new RepairSituations();
            repairSituations.Name = txtName.Text;
            repairSituations.IsActive = chkIsActive.Checked;
            repairSituations.RegisterDate = DateTime.Now;
            db.RepairSituations.Add(repairSituations);
            db.SaveChanges();
            MessageBox.Show("Başarıyla eklenmiştir.");
            dgvRepairTypes.DataSource = db.RepairSituations.ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RepairSituations repairStatusUpdate = db.RepairSituations.Find(id);
            repairStatusUpdate.Name = txtName.Text;
            repairStatusUpdate.IsActive = chkIsActive.Checked;
            db.SaveChanges();
            MessageBox.Show("Başarıyla güncellenmiştir.");
            dgvRepairTypes.DataSource = db.RepairSituations.ToList();
        }

        private void dgvRepairTypes_DoubleClick(object sender, EventArgs e)
        {
            var repairStatus = dgvRepairTypes.SelectedRows[0].DataBoundItem as RepairSituations;
            id = repairStatus.RepairStatusId;
            txtName.Text = repairStatus.Name;
            chkIsActive.Checked = repairStatus.IsActive;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var repairStatus = dgvRepairTypes.SelectedRows[0].DataBoundItem as RepairSituations;
            db.RepairSituations.Remove(repairStatus);
            db.SaveChanges();
            MessageBox.Show("Başarıyla silinmiştir.");
            dgvRepairTypes.DataSource = db.RepairSituations.ToList();
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
            var searchDataList = db.RepairSituations.Where(p => p.Name.Contains(search)).ToList();
            dgvRepairTypes.DataSource = searchDataList;
        }
    }
}
