
namespace EFFiveSessionWindowsFormApp.Views.Product
{
    partial class ProductsFrm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeliveryCustomer = new System.Windows.Forms.TextBox();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryUsers = new System.Windows.Forms.ComboBox();
            this.rdbBoxing = new System.Windows.Forms.RadioButton();
            this.rdbUnBoxing = new System.Windows.Forms.RadioButton();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEditProductList = new System.Windows.Forms.Button();
            this.btnProductType = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.clstFaultTypes = new System.Windows.Forms.CheckedListBox();
            this.btnFaultType = new System.Windows.Forms.Button();
            this.lstFaultTypes = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRepairStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(698, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSurname.Location = new System.Drawing.Point(299, 51);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(64, 25);
            this.lblNameSurname.TabIndex = 14;
            this.lblNameSurname.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(1, 441);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(799, 195);
            this.dgvProducts.TabIndex = 16;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 178);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 20);
            this.txtProductName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Teslim Eden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Teslim Alan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kutu Durumu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Teslim Tarihi:";
            // 
            // txtDeliveryCustomer
            // 
            this.txtDeliveryCustomer.Location = new System.Drawing.Point(138, 212);
            this.txtDeliveryCustomer.Name = "txtDeliveryCustomer";
            this.txtDeliveryCustomer.Size = new System.Drawing.Size(196, 20);
            this.txtDeliveryCustomer.TabIndex = 17;
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(135, 117);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(13, 13);
            this.lblProductNumber.TabIndex = 19;
            this.lblProductNumber.Text = "0";
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(138, 145);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(198, 21);
            this.cmbProductType.TabIndex = 20;
            // 
            // cmbDeliveryUsers
            // 
            this.cmbDeliveryUsers.Enabled = false;
            this.cmbDeliveryUsers.FormattingEnabled = true;
            this.cmbDeliveryUsers.Location = new System.Drawing.Point(136, 244);
            this.cmbDeliveryUsers.Name = "cmbDeliveryUsers";
            this.cmbDeliveryUsers.Size = new System.Drawing.Size(198, 21);
            this.cmbDeliveryUsers.TabIndex = 20;
            // 
            // rdbBoxing
            // 
            this.rdbBoxing.AutoSize = true;
            this.rdbBoxing.Location = new System.Drawing.Point(138, 274);
            this.rdbBoxing.Name = "rdbBoxing";
            this.rdbBoxing.Size = new System.Drawing.Size(55, 17);
            this.rdbBoxing.TabIndex = 21;
            this.rdbBoxing.TabStop = true;
            this.rdbBoxing.Text = "Kutulu";
            this.rdbBoxing.UseVisualStyleBackColor = true;
            // 
            // rdbUnBoxing
            // 
            this.rdbUnBoxing.AutoSize = true;
            this.rdbUnBoxing.Location = new System.Drawing.Point(249, 274);
            this.rdbUnBoxing.Name = "rdbUnBoxing";
            this.rdbUnBoxing.Size = new System.Drawing.Size(63, 17);
            this.rdbUnBoxing.TabIndex = 21;
            this.rdbUnBoxing.TabStop = true;
            this.rdbUnBoxing.Text = "Kutusuz";
            this.rdbUnBoxing.UseVisualStyleBackColor = true;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(135, 304);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 22;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(182, 342);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(99, 35);
            this.btnProductAdd.TabIndex = 23;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(623, 415);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnEditProductList
            // 
            this.btnEditProductList.Location = new System.Drawing.Point(674, 342);
            this.btnEditProductList.Name = "btnEditProductList";
            this.btnEditProductList.Size = new System.Drawing.Size(114, 57);
            this.btnEditProductList.TabIndex = 25;
            this.btnEditProductList.Text = "Düzenlenmiş Ürünler";
            this.btnEditProductList.UseVisualStyleBackColor = true;
            this.btnEditProductList.Click += new System.EventHandler(this.btnEditProductList_Click);
            // 
            // btnProductType
            // 
            this.btnProductType.Location = new System.Drawing.Point(674, 117);
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.Size = new System.Drawing.Size(114, 57);
            this.btnProductType.TabIndex = 25;
            this.btnProductType.Text = "Ürün Tipleri";
            this.btnProductType.UseVisualStyleBackColor = true;
            this.btnProductType.Click += new System.EventHandler(this.btnProductType_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Arıza Tipi";
            // 
            // clstFaultTypes
            // 
            this.clstFaultTypes.FormattingEnabled = true;
            this.clstFaultTypes.Location = new System.Drawing.Point(353, 145);
            this.clstFaultTypes.Name = "clstFaultTypes";
            this.clstFaultTypes.Size = new System.Drawing.Size(140, 169);
            this.clstFaultTypes.TabIndex = 26;
            // 
            // btnFaultType
            // 
            this.btnFaultType.Location = new System.Drawing.Point(674, 193);
            this.btnFaultType.Name = "btnFaultType";
            this.btnFaultType.Size = new System.Drawing.Size(114, 57);
            this.btnFaultType.TabIndex = 25;
            this.btnFaultType.Text = "Arıza Tipleri";
            this.btnFaultType.UseVisualStyleBackColor = true;
            this.btnFaultType.Click += new System.EventHandler(this.btnFaultType_Click);
            // 
            // lstFaultTypes
            // 
            this.lstFaultTypes.FormattingEnabled = true;
            this.lstFaultTypes.Location = new System.Drawing.Point(499, 145);
            this.lstFaultTypes.Name = "lstFaultTypes";
            this.lstFaultTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFaultTypes.Size = new System.Drawing.Size(120, 173);
            this.lstFaultTypes.TabIndex = 27;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 35);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Ürün Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRepairStatus
            // 
            this.btnRepairStatus.Location = new System.Drawing.Point(674, 261);
            this.btnRepairStatus.Name = "btnRepairStatus";
            this.btnRepairStatus.Size = new System.Drawing.Size(114, 57);
            this.btnRepairStatus.TabIndex = 25;
            this.btnRepairStatus.Text = "Tamir Durumları";
            this.btnRepairStatus.UseVisualStyleBackColor = true;
            this.btnRepairStatus.Click += new System.EventHandler(this.btnRepairStatus_Click);
            // 
            // ProductsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.lstFaultTypes);
            this.Controls.Add(this.clstFaultTypes);
            this.Controls.Add(this.btnRepairStatus);
            this.Controls.Add(this.btnFaultType);
            this.Controls.Add(this.btnProductType);
            this.Controls.Add(this.btnEditProductList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.rdbUnBoxing);
            this.Controls.Add(this.rdbBoxing);
            this.Controls.Add(this.cmbDeliveryUsers);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeliveryCustomer);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.btnBack);
            this.Name = "ProductsFrm";
            this.Text = "ProductsFrm";
            this.Load += new System.EventHandler(this.ProductsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeliveryCustomer;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.ComboBox cmbDeliveryUsers;
        private System.Windows.Forms.RadioButton rdbBoxing;
        private System.Windows.Forms.RadioButton rdbUnBoxing;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnEditProductList;
        private System.Windows.Forms.Button btnProductType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clstFaultTypes;
        private System.Windows.Forms.Button btnFaultType;
        private System.Windows.Forms.ListBox lstFaultTypes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRepairStatus;
    }
}