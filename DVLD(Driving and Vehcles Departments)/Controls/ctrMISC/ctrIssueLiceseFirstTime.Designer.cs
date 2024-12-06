namespace DVLD_Interface.Controls.ctrMISC
{
    partial class ctrIssueLiceseFirstTime
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
            this.ctrLDLAppInfo1 = new DVLD_Interface.Controls.ctrMISC.ctrLDLAppInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // ctrLDLAppInfo1
            // 
            this.ctrLDLAppInfo1.BackColor = System.Drawing.Color.Chocolate;
            this.ctrLDLAppInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrLDLAppInfo1.ForeColor = System.Drawing.Color.Snow;
            this.ctrLDLAppInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrLDLAppInfo1.Name = "ctrLDLAppInfo1";
            this.ctrLDLAppInfo1.Size = new System.Drawing.Size(699, 532);
            this.ctrLDLAppInfo1.TabIndex = 0;
            this.ctrLDLAppInfo1.Load += new System.EventHandler(this.ctrLDLAppInfo1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Image = global::DVLD_Interface.Properties.Resources.Notes_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(4, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = " Notes :                ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::DVLD_Interface.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(605, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 44);
            this.btnSave.TabIndex = 23;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.Parent = this.txtNotes;
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.Tomato;
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.FocusedState.Parent = this.txtNotes;
            this.txtNotes.ForeColor = System.Drawing.Color.Snow;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.HoverState.Parent = this.txtNotes;
            this.txtNotes.Location = new System.Drawing.Point(4, 558);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.ShadowDecoration.Parent = this.txtNotes;
            this.txtNotes.Size = new System.Drawing.Size(573, 142);
            this.txtNotes.TabIndex = 24;
            // 
            // ctrIssueLiceseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrLDLAppInfo1);
            this.Name = "ctrIssueLiceseFirstTime";
            this.Size = new System.Drawing.Size(699, 703);
            this.Load += new System.EventHandler(this.ctrIssueLiceseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrLDLAppInfo ctrLDLAppInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
    }
}
