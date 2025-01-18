namespace DVLD_Interface.Controls
{
    partial class ctrParent
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pPersonPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pPersonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 29);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Add Person ";
            // 
            // pPersonPicture
            // 
            this.pPersonPicture.BackColor = System.Drawing.Color.Transparent;
            this.pPersonPicture.Image = global::DVLD_Interface.Properties.Resources.male;
            this.pPersonPicture.Location = new System.Drawing.Point(296, 13);
            this.pPersonPicture.Name = "pPersonPicture";
            this.pPersonPicture.ShadowDecoration.BorderRadius = 0;
            this.pPersonPicture.ShadowDecoration.Depth = 10;
            this.pPersonPicture.ShadowDecoration.Parent = this.pPersonPicture;
            this.pPersonPicture.Size = new System.Drawing.Size(131, 130);
            this.pPersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPersonPicture.TabIndex = 0;
            this.pPersonPicture.TabStop = false;
            this.pPersonPicture.Tag = " ";
            this.pPersonPicture.Click += new System.EventHandler(this.pPersonPicture_Click);
            // 
            // ctrParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pPersonPicture);
            this.Name = "ctrParent";
            this.Size = new System.Drawing.Size(767, 630);
            this.Load += new System.EventHandler(this.ctrParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPersonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected System.Windows.Forms.Label lblTitle;
        protected Guna.UI2.WinForms.Guna2CirclePictureBox pPersonPicture;
    }
}
