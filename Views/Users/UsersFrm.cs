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

namespace EFFiveSessionWindowsFormApp.Views.Users
{
    public partial class UsersFrm : Form
    {
        public UsersFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;
        TechnicalServiceContext db = new TechnicalServiceContext();

        private void UsersFrm_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = user.NameSurname;

            dgvUsers.DataSource = db.Users.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuFrm frm = new MainMenuFrm(user);
            this.Close();
            frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var searchDataList = db.Users.Where(p => p.NameSurname.Contains(search)).ToList();
            dgvUsers.DataSource = searchDataList;
        }
    }
}
