namespace DVLD_Interface.Controls
{
    partial class ctrPersonDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNatID = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pPersonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 23);
            this.lblTitle.Size = new System.Drawing.Size(114, 29);
            this.lblTitle.Text = "Person Details";
            // 
            // pPersonPicture
            // 
            this.pPersonPicture.Enabled = false;
            this.pPersonPicture.Location = new System.Drawing.Point(378, 3);
            this.pPersonPicture.ShadowDecoration.BorderRadius = 0;
            this.pPersonPicture.ShadowDecoration.Depth = 10;
            this.pPersonPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pPersonPicture.ShadowDecoration.Parent = this.pPersonPicture;
            this.pPersonPicture.Size = new System.Drawing.Size(186, 146);
            this.pPersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.errorProvider1.SetIconAlignment(this.label1, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.label1.Image = global::DVLD_Interface.Properties.Resources.Person_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(25, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name:           ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblName.ForeColor = System.Drawing.Color.Snow;
            this.lblName.Location = new System.Drawing.Point(175, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 30);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "[?؟?]";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblID.ForeColor = System.Drawing.Color.Snow;
            this.lblID.Location = new System.Drawing.Point(175, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 30);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "[?؟?]";
            // 
            // lblNatID
            // 
            this.lblNatID.AutoSize = true;
            this.lblNatID.BackColor = System.Drawing.Color.Transparent;
            this.lblNatID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNatID.ForeColor = System.Drawing.Color.Snow;
            this.lblNatID.Location = new System.Drawing.Point(175, 299);
            this.lblNatID.Name = "lblNatID";
            this.lblNatID.Size = new System.Drawing.Size(58, 30);
            this.lblNatID.TabIndex = 53;
            this.lblNatID.Text = "[?؟?]";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.BackColor = System.Drawing.Color.Transparent;
            this.lblGendor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblGendor.ForeColor = System.Drawing.Color.Snow;
            this.lblGendor.Location = new System.Drawing.Point(498, 292);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(58, 30);
            this.lblGendor.TabIndex = 55;
            this.lblGendor.Text = "[?؟?]";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPhone.ForeColor = System.Drawing.Color.Snow;
            this.lblPhone.Location = new System.Drawing.Point(498, 361);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 30);
            this.lblPhone.TabIndex = 57;
            this.lblPhone.Text = "[?؟?]";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblEmail.ForeColor = System.Drawing.Color.Snow;
            this.lblEmail.Location = new System.Drawing.Point(498, 229);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 30);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "[?؟?]";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateBirth.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.Snow;
            this.lblDateBirth.Location = new System.Drawing.Point(175, 369);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(58, 30);
            this.lblDateBirth.TabIndex = 61;
            this.lblDateBirth.Text = "[?؟?]";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCountry.ForeColor = System.Drawing.Color.Snow;
            this.lblCountry.Location = new System.Drawing.Point(175, 439);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 30);
            this.lblCountry.TabIndex = 63;
            this.lblCountry.Text = "[?؟?]";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAddress.ForeColor = System.Drawing.Color.Snow;
            this.lblAddress.Location = new System.Drawing.Point(498, 439);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 30);
            this.lblAddress.TabIndex = 65;
            this.lblAddress.Text = "[?؟?]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Image = global::DVLD_Interface.Properties.Resources.Address_32;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(352, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 30);
            this.label9.TabIndex = 64;
            this.label9.Text = "Address:       ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Image = global::DVLD_Interface.Properties.Resources.Country_32;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(25, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 62;
            this.label8.Text = "Country:      ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Image = global::DVLD_Interface.Properties.Resources.Calendar_32;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(25, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 60;
            this.label7.Text = "Birth:             ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Image = global::DVLD_Interface.Properties.Resources.Email_32;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(352, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 30);
            this.label6.TabIndex = 58;
            this.label6.Text = "Email:         ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Image = global::DVLD_Interface.Properties.Resources.Phone_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(352, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 56;
            this.label5.Text = "Phone:        ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Image = global::DVLD_Interface.Properties.Resources.Person_32;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(352, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 30);
            this.label11.TabIndex = 54;
            this.label11.Text = "Gendor:      ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(25, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 52;
            this.label4.Text = "NatID:           ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(25, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 50;
            this.label3.Text = "ID:                 ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnUpdate.Image = global::DVLD_Interface.Properties.Resources.refresh;
            this.btnUpdate.Location = new System.Drawing.Point(591, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 49);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ctrPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNatID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGendor);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "ctrPersonDetails";
            this.Size = new System.Drawing.Size(934, 492);
            this.Load += new System.EventHandler(this.ctrPersonDetails_Load);
            this.Controls.SetChildIndex(this.pPersonPicture, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblPhone, 0);
            this.Controls.SetChildIndex(this.lblGendor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblNatID, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblDateBirth, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lblCountry, 0);
            this.Controls.SetChildIndex(this.lblAddress, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pPersonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label lblGendor;
        protected internal System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.Label lblNatID;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label lblID;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label lblName;
        protected internal System.Windows.Forms.Label lblAddress;
        protected internal System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.Label lblCountry;
        protected internal System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.Label lblDateBirth;
        protected internal System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.Label lblEmail;
        protected internal System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Label lblPhone;
        protected internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
    }
}
