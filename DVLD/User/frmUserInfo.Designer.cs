namespace DVLD_Interface.User
{
    partial class frmUserInfo
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
            this.ctrUserInfo2 = new DVLD_Interface.Controls.ctrUser.ctrUserInfo();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ctrUserInfo2
            // 
            this.ctrUserInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrUserInfo2.Location = new System.Drawing.Point(0, 0);
            this.ctrUserInfo2.Name = "ctrUserInfo2";
            this.ctrUserInfo2.Size = new System.Drawing.Size(916, 398);
            this.ctrUserInfo2.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.ClientSize = new System.Drawing.Size(916, 398);
            this.Controls.Add(this.ctrUserInfo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserInfo";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmUserInfo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Controls.ctrUser.ctrUserInfo ctrUserInfo2;
    }
}