namespace DVLD_Interface.Controls.ctrUser
{
    partial class ctrUserInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.ctrPersonDetails1 = new DVLD_Interface.Controls.ctrPersonDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Image = global::DVLD_Interface.Properties.Resources.Number_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(30, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "UseID:      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Image = global::DVLD_Interface.Properties.Resources.Person_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(269, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:        ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Image = global::DVLD_Interface.Properties.Resources.Question_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(632, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Is Active:      ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Snow;
            this.lblID.Location = new System.Drawing.Point(143, 495);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 28);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Username";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Snow;
            this.lblUsername.Location = new System.Drawing.Point(432, 495);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 28);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.BackColor = System.Drawing.Color.Transparent;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.Snow;
            this.lblActive.Location = new System.Drawing.Point(782, 495);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(99, 28);
            this.lblActive.TabIndex = 6;
            this.lblActive.Text = "Username";
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.BackColor = System.Drawing.Color.Transparent;
            this.ctrPersonDetails1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrPersonDetails1.ForeColor = System.Drawing.Color.Snow;
            this.ctrPersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.NatID = null;
            this.ctrPersonDetails1.PersonID = 0;
            this.ctrPersonDetails1.Size = new System.Drawing.Size(934, 492);
            this.ctrPersonDetails1.TabIndex = 7;
            this.ctrPersonDetails1.Load += new System.EventHandler(this.ctrPersonDetails1_Load_2);
            // 
            // ctrUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.ctrPersonDetails1);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "ctrUserInfo";
            this.Size = new System.Drawing.Size(934, 544);
            this.Load += new System.EventHandler(this.ctrUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblActive;
        private ctrPersonDetails ctrPersonDetails1;
    }
}
