using System.Collections.Generic;

namespace DVLD_Interface.Controls
{
    partial class ctrFiltredList
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
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.DropDownWidth = 100;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo",
            "FirstName",
            "Gendor",
            "Phone",
            "Email"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(7, 27);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(34, 36);
            this.guna2ComboBox1.TabIndex = 9;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::DVLD_Interface.Properties.Resources.filter__2_;
            this.guna2Button1.Location = new System.Drawing.Point(3, 23);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(43, 51);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtFilterText
            // 
            this.txtFilterText.BorderRadius = 10;
            this.txtFilterText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterText.DefaultText = "";
            this.txtFilterText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterText.DisabledState.Parent = this.txtFilterText;
            this.txtFilterText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterText.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFilterText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterText.FocusedState.Parent = this.txtFilterText;
            this.txtFilterText.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFilterText.ForeColor = System.Drawing.Color.White;
            this.txtFilterText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterText.HoverState.Parent = this.txtFilterText;
            this.txtFilterText.IconLeft = global::DVLD_Interface.Properties.Resources.search__1_;
            this.txtFilterText.Location = new System.Drawing.Point(53, 27);
            this.txtFilterText.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.PasswordChar = '\0';
            this.txtFilterText.PlaceholderText = "";
            this.txtFilterText.SelectedText = "";
            this.txtFilterText.ShadowDecoration.Parent = this.txtFilterText;
            this.txtFilterText.Size = new System.Drawing.Size(213, 47);
            this.txtFilterText.TabIndex = 10;
            this.txtFilterText.TextOffset = new System.Drawing.Point(10, 0);
            this.txtFilterText.Visible = false;
            this.txtFilterText.TextChanged += new System.EventHandler(this.txtFilterText_TextChanged);
            // 
            // ctrFiltredList
            // 
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterText);
            this.Controls.Add(this.guna2ComboBox1);
            this.Name = "ctrFiltredList";
            this.Size = new System.Drawing.Size(393, 77);
            this.Load += new System.EventHandler(this.ctrFiltredList_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        protected internal Guna.UI2.WinForms.Guna2TextBox txtFilterText;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
