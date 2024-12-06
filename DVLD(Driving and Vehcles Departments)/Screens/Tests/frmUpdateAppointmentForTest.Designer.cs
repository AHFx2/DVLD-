namespace DVLD_Interface.Screens.Tests
{
    partial class frmUpdateAppointmentForTest
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
            this.ctrScheduleTest1 = new DVLD_Interface.Controls.ctrMISC.ctrScheduleTest();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(472, 12);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrScheduleTest1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(527, 780);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrScheduleTest1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            // 
            // ctrScheduleTest1
            // 
            this.ctrScheduleTest1.BackColor = System.Drawing.Color.Transparent;
            this.ctrScheduleTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrScheduleTest1.Location = new System.Drawing.Point(0, 0);
            this.ctrScheduleTest1.Name = "ctrScheduleTest1";
            this.ctrScheduleTest1.Size = new System.Drawing.Size(527, 780);
            this.ctrScheduleTest1.TabIndex = 1;
            this.ctrScheduleTest1.Load += new System.EventHandler(this.ctrAddAppointmentForTest1_Load);
            // 
            // frmUpdateAppointmentForTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 780);
            this.Name = "frmUpdateAppointmentForTest";
            this.Text = "frmUpdateTest";
            this.Load += new System.EventHandler(this.frmUpdateTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrMISC.ctrScheduleTest ctrScheduleTest1;
    }
}