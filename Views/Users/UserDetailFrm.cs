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
    public partial class UserDetailFrm : Form
    {
        public UserDetailFrm(Models.Entities.Users users)
        {
            InitializeComponent();
            user = users;
        }
        Models.Entities.Users user;

        private void UserDetailFrm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtNameSurname.Text = user.NameSurname;
            dtpBirthDate.Value = user.UserDetails.Birthdate;
            txtAddress.Text = user.UserDetails.Address;
            if (user.UserDetails.Gender)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            mtxtPhone.Text = user.UserDetails.PhoneNumber;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuFrm frm = new MainMenuFrm(user);
            this.Close();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TechnicalServiceContext db = new TechnicalServiceContext();

            Models.Entities.Users userUpdate = db.Users.Find(user.UserId);
            userUpdate.Password = txtPassword.Text;
            userUpdate.UserDetails.Address = txtAddress.Text;
            userUpdate.UserDetails.Birthdate = dtpBirthDate.Value;
            userUpdate.UserDetails.Gender = rdbMale.Checked == true ? true : false;
            userUpdate.UserDetails.PhoneNumber = mtxtPhone.Text.Replace("(","").Replace(")","").Replace(" ","").Replace("-","");
            db.SaveChanges();
            user = userUpdate;
            MessageBox.Show("Başarıyla Güncellendi.");
        }
    }
}
