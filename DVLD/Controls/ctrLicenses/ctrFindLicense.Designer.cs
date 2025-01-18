namespace DVLD_Interface.Controls.ctrMISC
{
    partial class ctrFindLicense
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
            this.txtFiled = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrLincesCard1 = new DVLD_Interface.Controls.ctrMISC.ctrLincesCard();
            this.SuspendLayout();
            // 
            // txtFiled
            // 
            this.txtFiled.BackColor = System.Drawing.Color.Transparent;
            this.txtFiled.BorderRadius = 10;
            this.txtFiled.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiled.DefaultText = "";
            this.txtFiled.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiled.DisabledState.Parent = this.txtFiled;
            this.txtFiled.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiled.FillColor = System.Drawing.Color.Violet;
            this.txtFiled.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiled.FocusedState.Parent = this.txtFiled;
            this.txtFiled.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiled.HoverState.Parent = this.txtFiled;
            this.txtFiled.IconLeft = global::DVLD_Interface.Properties.Resources.search__1_;
            this.txtFiled.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtFiled.Location = new System.Drawing.Point(15, 40);
            this.txtFiled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiled.Name = "txtFiled";
            this.txtFiled.PasswordChar = '\0';
            this.txtFiled.PlaceholderText = "";
            this.txtFiled.SelectedText = "";
            this.txtFiled.ShadowDecoration.Parent = this.txtFiled;
            this.txtFiled.Size = new System.Drawing.Size(267, 44);
            this.txtFiled.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.FillColor = System.Drawing.Color.Transparent;
            this.btnFind.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Image = global::DVLD_Interface.Properties.Resources.LicenseView_400;
            this.btnFind.ImageSize = new System.Drawing.Size(50, 50);
            this.btnFind.Location = new System.Drawing.Point(289, 41);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(57, 44);
            this.btnFind.TabIndex = 2;
            this.btnFind.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // ctrLincesCard1
            // 
            this.ctrLincesCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrLincesCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrLincesCard1.Location = new System.Drawing.Point(0, 91);
            this.ctrLincesCard1.Name = "ctrLincesCard1";
            this.ctrLincesCard1.Size = new System.Drawing.Size(720, 493);
            this.ctrLincesCard1.TabIndex = 0;
            this.ctrLincesCard1.Load += new System.EventHandler(this.ctrLincesCard1_Load);
            // 
            // ctrFindLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFiled);
            this.Controls.Add(this.ctrLincesCard1);
            this.Name = "ctrFindLicense";
            this.Size = new System.Drawing.Size(720, 584);
            this.Load += new System.EventHandler(this.ctrFindLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtFiled;
        private Guna.UI2.WinForms.Guna2GradientButton btnFind;
        public ctrLincesCard ctrLincesCard1;
    }
}
