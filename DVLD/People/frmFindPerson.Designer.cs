namespace DVLD_Interface.People
{
    partial class frmFindPerson
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrFindPerson1 = new DVLD_Interface.People.Controls.ctrFindPerson();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.lblTitle.Location = new System.Drawing.Point(366, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Find Person";
            // 
            // ctrFindPerson1
            // 
            this.ctrFindPerson1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFindPerson1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrFindPerson1.FilterEnabled = true;
            this.ctrFindPerson1.Item = null;
            this.ctrFindPerson1.Location = new System.Drawing.Point(0, 72);
            this.ctrFindPerson1.Name = "ctrFindPerson1";
            this.ctrFindPerson1.ShowAddPerson = true;
            this.ctrFindPerson1.Size = new System.Drawing.Size(915, 418);
            this.ctrFindPerson1.TabIndex = 2;
            this.ctrFindPerson1.VisbleFilter = true;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 490);
            this.Controls.Add(this.ctrFindPerson1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Person";
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private DVLD_Interface.People.Controls.ctrFindPerson ctrFindPerson1;
    }
}