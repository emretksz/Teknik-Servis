
namespace EFFiveSessionWindowsFormApp.Views.Home
{
    partial class MainMenuFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnFault = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(71, 160);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(155, 130);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile Git";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnFault
            // 
            this.btnFault.Location = new System.Drawing.Point(572, 160);
            this.btnFault.Name = "btnFault";
            this.btnFault.Size = new System.Drawing.Size(155, 130);
            this.btnFault.TabIndex = 0;
            this.btnFault.Text = "Arıza Kaydı";
            this.btnFault.UseVisualStyleBackColor = true;
            this.btnFault.Click += new System.EventHandler(this.btnFault_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(706, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSurname.Location = new System.Drawing.Point(340, 52);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(64, 25);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "Name";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(13, 9);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Çıkış Yap";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(324, 160);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(155, 130);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Kullanıcılar";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Visible = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Red;
            this.lblRole.Location = new System.Drawing.Point(340, 27);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 17);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnFault);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnProfile);
            this.Name = "MainMenuFrm";
            this.Text = "MainMenuFrm";
            this.Load += new System.EventHandler(this.MainMenuFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFault;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblRole;
    }
}