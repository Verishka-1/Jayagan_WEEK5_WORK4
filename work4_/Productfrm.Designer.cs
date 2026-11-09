namespace work4_
{
    partial class Productfrm
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.grpbOrigin = new System.Windows.Forms.GroupBox();
            this.radbtnLocal = new System.Windows.Forms.RadioButton();
            this.radbtnAbroad = new System.Windows.Forms.RadioButton();
            this.chkbStatus = new System.Windows.Forms.CheckBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.lblBarcodeStatus = new System.Windows.Forms.Label();
            this.grpbOrigin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(27, 22);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(98, 19);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(329, 20);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 111);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 214);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(30, 241);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(34, 13);
            this.lblOrigin.TabIndex = 5;
            this.lblOrigin.Text = "Origin";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 295);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(30, 336);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(162, 336);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(329, 336);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(60, 13);
            this.lblMarkup.TabIndex = 9;
            this.lblMarkup.Text = "Markup (%)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(329, 20);
            this.txtName.TabIndex = 13;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(98, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(331, 94);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(98, 214);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(331, 21);
            this.cmbCategory.TabIndex = 15;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // grpbOrigin
            // 
            this.grpbOrigin.Controls.Add(this.radbtnAbroad);
            this.grpbOrigin.Controls.Add(this.radbtnLocal);
            this.grpbOrigin.Location = new System.Drawing.Point(98, 241);
            this.grpbOrigin.Name = "grpbOrigin";
            this.grpbOrigin.Size = new System.Drawing.Size(331, 47);
            this.grpbOrigin.TabIndex = 16;
            this.grpbOrigin.TabStop = false;
            this.grpbOrigin.Text = "Manufactured";
            this.grpbOrigin.Enter += new System.EventHandler(this.grpbOrigin_Enter);
            // 
            // radbtnLocal
            // 
            this.radbtnLocal.AutoSize = true;
            this.radbtnLocal.Location = new System.Drawing.Point(25, 20);
            this.radbtnLocal.Name = "radbtnLocal";
            this.radbtnLocal.Size = new System.Drawing.Size(51, 17);
            this.radbtnLocal.TabIndex = 0;
            this.radbtnLocal.TabStop = true;
            this.radbtnLocal.Text = "Local";
            this.radbtnLocal.UseVisualStyleBackColor = true;
            this.radbtnLocal.CheckedChanged += new System.EventHandler(this.radbtnLocal_CheckedChanged);
            // 
            // radbtnAbroad
            // 
            this.radbtnAbroad.AutoSize = true;
            this.radbtnAbroad.Location = new System.Drawing.Point(232, 20);
            this.radbtnAbroad.Name = "radbtnAbroad";
            this.radbtnAbroad.Size = new System.Drawing.Size(59, 17);
            this.radbtnAbroad.TabIndex = 1;
            this.radbtnAbroad.TabStop = true;
            this.radbtnAbroad.Text = "Abroad";
            this.radbtnAbroad.UseVisualStyleBackColor = true;
            this.radbtnAbroad.CheckedChanged += new System.EventHandler(this.radbtnAbroad_CheckedChanged);
            // 
            // chkbStatus
            // 
            this.chkbStatus.AutoSize = true;
            this.chkbStatus.Location = new System.Drawing.Point(98, 295);
            this.chkbStatus.Name = "chkbStatus";
            this.chkbStatus.Size = new System.Drawing.Size(56, 17);
            this.chkbStatus.TabIndex = 17;
            this.chkbStatus.Text = "Active";
            this.chkbStatus.UseVisualStyleBackColor = true;
            this.chkbStatus.CheckedChanged += new System.EventHandler(this.chkbStatus_CheckedChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(30, 352);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(124, 20);
            this.txtCost.TabIndex = 18;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(165, 352);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(109, 20);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(330, 352);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(97, 20);
            this.txtMarkup.TabIndex = 20;
            this.txtMarkup.TextChanged += new System.EventHandler(this.txtMarkup_TextChanged);
            // 
            // lblBarcodeStatus
            // 
            this.lblBarcodeStatus.AutoSize = true;
            this.lblBarcodeStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBarcodeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeStatus.Location = new System.Drawing.Point(98, 46);
            this.lblBarcodeStatus.Name = "lblBarcodeStatus";
            this.lblBarcodeStatus.Size = new System.Drawing.Size(0, 13);
            this.lblBarcodeStatus.TabIndex = 21;
            this.lblBarcodeStatus.Click += new System.EventHandler(this.lblBarcodeStatus_Click);
            // 
            // Productfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 507);
            this.Controls.Add(this.lblBarcodeStatus);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.chkbStatus);
            this.Controls.Add(this.grpbOrigin);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Name = "Productfrm";
            this.Text = "Productfrm";
            this.Load += new System.EventHandler(this.Productfrm_Load);
            this.grpbOrigin.ResumeLayout(false);
            this.grpbOrigin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox grpbOrigin;
        private System.Windows.Forms.RadioButton radbtnAbroad;
        private System.Windows.Forms.RadioButton radbtnLocal;
        private System.Windows.Forms.CheckBox chkbStatus;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.Label lblBarcodeStatus;
    }
}