using EFFiveSessionWindowsFormApp.Models.Entities;
using EFFiveSessionWindowsFormApp.Views.Accounts;
using EFFiveSessionWindowsFormApp.Views.Product;
using EFFiveSessionWindowsFormApp.Views.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFFiveSessionWindowsFormApp.Views.Home
{
    public partial class MainMenuFrm : Form
    {
        public MainMenuFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            User = users;
        }
        Models.Entities.Users User;

        private void MainMenuFrm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblNameSurname.Text = User.NameSurname;
            if (User.isRole)
                btnUsers.Visible = true;
            lblRole.Text = User.isRole ? "Yönetici" : "Kullanıcı";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginFrm frm = new LoginFrm();
            this.Close();
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserDetailFrm frm = new UserDetailFrm(User);
            this.Close();
            frm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersFrm frm = new UsersFrm(User);
            this.Close();
            frm.Show();
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            ProductsFrm frm = new ProductsFrm(User);
            this.Close();
            frm.Show();
        }
    }
}
