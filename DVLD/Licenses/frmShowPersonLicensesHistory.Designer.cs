namespace DVLD_Interface.Licenses
{
    partial class frmShowPersonLicensesHistory
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
            this.ctrDriverLicenses1 = new DVLD_Interface.Licenses.Controls.ctrDriverLicenses();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrFindPerson1 = new DVLD_Interface.People.Controls.ctrFindPerson();
            this.SuspendLayout();
            // 
            // ctrDriverLicenses1
            // 
            this.ctrDriverLicenses1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrDriverLicenses1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrDriverLicenses1.Location = new System.Drawing.Point(0, 539);
            this.ctrDriverLicenses1.Name = "ctrDriverLicenses1";
            this.ctrDriverLicenses1.Size = new System.Drawing.Size(1037, 338);
            this.ctrDriverLicenses1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.lblTitle.Location = new System.Drawing.Point(-8, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1062, 39);
            this.lblTitle.TabIndex = 130;
            this.lblTitle.Text = "License History";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrFindPerson1.FilterEnabled = true;
            this.ctrFindPerson1.Item = null;
            this.ctrFindPerson1.Location = new System.Drawing.Point(67, 71);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.ShowAddPerson = true;
            this.ctrFindPerson1.Size = new System.Drawing.Size(933, 462);
            this.ctrFindPerson1.TabIndex = 131;
            this.ctrFindPerson1.VisbleFilter = true;
            // 
            // frmShowPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 877);
            this.Controls.Add(this.ctrFindPerson1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrDriverLicenses1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowPersonLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Person Licenses History";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrDriverLicenses ctrDriverLicenses1;
        private System.Windows.Forms.Label lblTitle;
        private People.Controls.ctrFindPerson ctrFindPerson1;
    }
}