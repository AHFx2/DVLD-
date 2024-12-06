namespace DVLD_Interface.Screens.Tests
{
    partial class frmTestApoitments
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrClintTestsAppointments1 = new DVLD_Interface.Controls.ctrMISC.ctrClintTestsAppointments();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(1176, 3);
            this.pExit.Size = new System.Drawing.Size(25, 25);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrClintTestsAppointments1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1201, 763);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrClintTestsAppointments1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // takeToolStripMenuItem
            // 
            this.takeToolStripMenuItem.Name = "takeToolStripMenuItem";
            this.takeToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.takeToolStripMenuItem.Text = "Take";
            this.takeToolStripMenuItem.Click += new System.EventHandler(this.takeToolStripMenuItem_Click);
            // 
            // ctrClintTestsAppointments1
            // 
            this.ctrClintTestsAppointments1.AutoScroll = true;
            this.ctrClintTestsAppointments1.BackColor = System.Drawing.Color.Transparent;
            this.ctrClintTestsAppointments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrClintTestsAppointments1.LDLApp = 0;
            this.ctrClintTestsAppointments1.Location = new System.Drawing.Point(0, 0);
            this.ctrClintTestsAppointments1.Name = "ctrClintTestsAppointments1";
            this.ctrClintTestsAppointments1.Size = new System.Drawing.Size(1201, 763);
            this.ctrClintTestsAppointments1.TabIndex = 2;
            this.ctrClintTestsAppointments1.TestType = ((byte)(0));
            this.ctrClintTestsAppointments1.Load += new System.EventHandler(this.ctrClintTestsAppointments1_Load_2);
            // 
            // frmTestApoitments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 763);
            this.Name = "frmTestApoitments";
            this.Text = "frmVisionTest";
            this.Load += new System.EventHandler(this.frmVisionTest_Load);
            this.Shown += new System.EventHandler(this.frmVisionTestApoitments_Shown);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeToolStripMenuItem;
        private Controls.ctrMISC.ctrClintTestsAppointments ctrClintTestsAppointments1;
    }
}