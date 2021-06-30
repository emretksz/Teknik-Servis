
namespace EFFiveSessionWindowsFormApp.Views.Product
{
    partial class ProductEditFrm
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
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.rdbUnBoxing = new System.Windows.Forms.RadioButton();
            this.rdbBoxing = new System.Windows.Forms.RadioButton();
            this.cmbDeliveryUsers = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryCustomer = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lstFaultTypes = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRepairStatus = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.Location = new System.Drawing.Point(173, 426);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(99, 35);
            this.btnProductEdit.TabIndex = 39;
            this.btnProductEdit.Text = "Güncelle";
            this.btnProductEdit.UseVisualStyleBackColor = true;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Enabled = false;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(132, 260);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 38;
            // 
            // rdbUnBoxing
            // 
            this.rdbUnBoxing.AutoSize = true;
            this.rdbUnBoxing.Enabled = false;
            this.rdbUnBoxing.Location = new System.Drawing.Point(246, 230);
            this.rdbUnBoxing.Name = "rdbUnBoxing";
            this.rdbUnBoxing.Size = new System.Drawing.Size(63, 17);
            this.rdbUnBoxing.TabIndex = 36;
            this.rdbUnBoxing.TabStop = true;
            this.rdbUnBoxing.Text = "Kutusuz";
            this.rdbUnBoxing.UseVisualStyleBackColor = true;
            // 
            // rdbBoxing
            // 
            this.rdbBoxing.AutoSize = true;
            this.rdbBoxing.Enabled = false;
            this.rdbBoxing.Location = new System.Drawing.Point(135, 230);
            this.rdbBoxing.Name = "rdbBoxing";
            this.rdbBoxing.Size = new System.Drawing.Size(55, 17);
            this.rdbBoxing.TabIndex = 37;
            this.rdbBoxing.TabStop = true;
            this.rdbBoxing.Text = "Kutulu";
            this.rdbBoxing.UseVisualStyleBackColor = true;
            // 
            // cmbDeliveryUsers
            // 
            this.cmbDeliveryUsers.Enabled = false;
            this.cmbDeliveryUsers.FormattingEnabled = true;
            this.cmbDeliveryUsers.Location = new System.Drawing.Point(133, 200);
            this.cmbDeliveryUsers.Name = "cmbDeliveryUsers";
            this.cmbDeliveryUsers.Size = new System.Drawing.Size(198, 21);
            this.cmbDeliveryUsers.TabIndex = 34;
            // 
            // cmbProductType
            // 
            this.cmbProductType.Enabled = false;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(135, 101);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(198, 21);
            this.cmbProductType.TabIndex = 35;
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(132, 73);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(13, 13);
            this.lblProductNumber.TabIndex = 33;
            this.lblProductNumber.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kutu Durumu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Teslim Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Teslim Alan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Teslim Eden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ürün Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ürün No:";
            // 
            // txtDeliveryCustomer
            // 
            this.txtDeliveryCustomer.Enabled = false;
            this.txtDeliveryCustomer.Location = new System.Drawing.Point(135, 168);
            this.txtDeliveryCustomer.Name = "txtDeliveryCustomer";
            this.txtDeliveryCustomer.Size = new System.Drawing.Size(196, 20);
            this.txtDeliveryCustomer.TabIndex = 24;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(135, 134);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 20);
            this.txtProductName.TabIndex = 25;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(360, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 42;
            this.lblDate.Text = "Date";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSurname.Location = new System.Drawing.Point(149, 32);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(64, 25);
            this.lblNameSurname.TabIndex = 41;
            this.lblNameSurname.Text = "Name";
            // 
            // lstFaultTypes
            // 
            this.lstFaultTypes.Enabled = false;
            this.lstFaultTypes.FormattingEnabled = true;
            this.lstFaultTypes.Location = new System.Drawing.Point(352, 101);
            this.lstFaultTypes.Name = "lstFaultTypes";
            this.lstFaultTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFaultTypes.Size = new System.Drawing.Size(120, 173);
            this.lstFaultTypes.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Arıza Tipi";
            // 
            // cmbRepairStatus
            // 
            this.cmbRepairStatus.FormattingEnabled = true;
            this.cmbRepairStatus.Location = new System.Drawing.Point(132, 295);
            this.cmbRepairStatus.Name = "cmbRepairStatus";
            this.cmbRepairStatus.Size = new System.Drawing.Size(201, 21);
            this.cmbRepairStatus.TabIndex = 45;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(132, 332);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(201, 88);
            this.txtDescription.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tamir Durumu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Açıklama:";
            // 
            // ProductEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 473);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbRepairStatus);
            this.Controls.Add(this.lstFaultTypes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.rdbUnBoxing);
            this.Controls.Add(this.rdbBoxing);
            this.Controls.Add(this.cmbDeliveryUsers);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeliveryCustomer);
            this.Controls.Add(this.txtProductName);
            this.Name = "ProductEditFrm";
            this.Text = "ProductEditFrm";
            this.Load += new System.EventHandler(this.ProductEditFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.ListBox lstFaultTypes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRepairStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.RadioButton rdbUnBoxing;
        private System.Windows.Forms.RadioButton rdbBoxing;
        private System.Windows.Forms.ComboBox cmbDeliveryUsers;
        private System.Windows.Forms.TextBox txtDeliveryCustomer;
        private System.Windows.Forms.TextBox txtProductName;
    }
}