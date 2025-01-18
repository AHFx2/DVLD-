namespace DVLD_Interface
{
    partial class frmTest
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
            this.ctrlScheduleTest2 = new DVLD_Interface.Tests.Controls.ctrlScheduleTest();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest2
            // 
            this.ctrlScheduleTest2.Location = new System.Drawing.Point(196, 46);
            this.ctrlScheduleTest2.Name = "ctrlScheduleTest2";
            this.ctrlScheduleTest2.Size = new System.Drawing.Size(522, 706);
            this.ctrlScheduleTest2.TabIndex = 0;
            this.ctrlScheduleTest2.TestTypeID = DVLD_Buisness.clsTestType.enTestType.VisionTest;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.ctrlScheduleTest2);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tests.Controls.ctrlScheduleTest ctrlScheduleTest1;
        private Tests.Controls.ctrlScheduleTest ctrlScheduleTest2;
    }
}