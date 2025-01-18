namespace DVLD_Interface.Licenses.Local_Licenses.Controls
{
    partial class ctrLicenseCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrLicenseCardWithFilter));
            this.ctrLicenseInof1 = new DVLD_Interface.Licenses.Local_Licenses.Controls.ctrLicenseInof();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrLicenseInof1
            // 
            this.ctrLicenseInof1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrLicenseInof1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.ctrLicenseInof1.Location = new System.Drawing.Point(0, 85);
            this.ctrLicenseInof1.Name = "ctrLicenseInof1";
            this.ctrLicenseInof1.Size = new System.Drawing.Size(867, 339);
            this.ctrLicenseInof1.TabIndex = 0;
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(3, 3);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(861, 77);
            this.ctrFiltredList1.TabIndex = 1;
            this.ctrFiltredList1.TextBoxVisible = true;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::DVLD_Interface.Properties.Resources.search__2_;
            this.btnFind.Location = new System.Drawing.Point(289, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(41, 39);
            this.btnFind.TabIndex = 2;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.ctrFiltredList1);
            this.Controls.Add(this.ctrLicenseInof1);
            this.Name = "ctrLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(867, 424);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrLicenseInof ctrLicenseInof1;
        private DVLD_Interface.Controls.ctrFiltredList ctrFiltredList1;
        private System.Windows.Forms.Button btnFind;
    }
}
