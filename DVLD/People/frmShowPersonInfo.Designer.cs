namespace DVLD_Interface.People
{
    partial class frmShowPersonInfo
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonCard1 = new DVLD_Interface.People.Controls.ctrPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrPersonCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrPersonCard1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctrPersonCard1.Location = new System.Drawing.Point(0, 61);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.Size = new System.Drawing.Size(934, 307);
            this.ctrPersonCard1.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            this.ClientSize = new System.Drawing.Size(934, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmShowPersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private DVLD_Interface.People.Controls.ctrPersonCard ctrPersonCard1;
    }
}