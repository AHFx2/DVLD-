namespace DVLD_Interface.Screens.Tests
{
    partial class frmScheduledTest
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
            this.ctrTakeTest1 = new DVLD_Interface.Controls.ctrMISC.ctrScheduledTest();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pExit
            // 
            this.pExit.Location = new System.Drawing.Point(538, 3);
            this.pExit.Size = new System.Drawing.Size(25, 25);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ctrTakeTest1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(566, 868);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.ctrTakeTest1, 0);
            this.guna2CustomGradientPanel1.Controls.SetChildIndex(this.pExit, 0);
            // 
            // ctrTakeTest1
            // 
            this.ctrTakeTest1.BackColor = System.Drawing.Color.Transparent;
            this.ctrTakeTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTakeTest1.ForeColor = System.Drawing.Color.Snow;
            this.ctrTakeTest1.Location = new System.Drawing.Point(0, 0);
            this.ctrTakeTest1.Name = "ctrTakeTest1";
            this.ctrTakeTest1.Size = new System.Drawing.Size(566, 868);
            this.ctrTakeTest1.TabIndex = 1;
            this.ctrTakeTest1.Load += new System.EventHandler(this.ctrTakeTest1_Load);
            // 
            // frmScheduledTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 868);
            this.Name = "frmScheduledTest";
            this.Text = "frmAddTest";
            this.Load += new System.EventHandler(this.frmAddTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrMISC.ctrScheduledTest ctrTakeTest1;
    }
}