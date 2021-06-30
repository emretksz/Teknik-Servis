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

namespace EFFiveSessionWindowsFormApp.Views.Accounts
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblFailMessage.Text = "";
            TechnicalServiceContext db = new TechnicalServiceContext();
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            //db.Configuration.LazyLoadingEnabled = false; -- .Include("UserDetails").Include("Products")
            Models.Entities.Users user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == pass);
            if (user == null)
                lblFailMessage.Text = "E-Posta veya şifre hatalı";
            else
            {
                if (user.IsActive)
                {
                    MessageBox.Show("Giriş Başarılı");
                    MainMenuFrm frm = new MainMenuFrm(user);
                    this.Hide();
                    frm.Show();
                }
                else
                    MessageBox.Show("Giriş yetkiniz bulunmamaktadır.Lütfen yetkililerle iletişime geçin.");
            }

        }
    }
}
