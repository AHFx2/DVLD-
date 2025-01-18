namespace DVLD_Interface.People.Controls
{
    partial class ctrFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrFindPerson));
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.ctrPersonCard1 = new DVLD_Interface.People.Controls.ctrPersonCard();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(6, 13);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(280, 82);
            this.ctrFiltredList1.TabIndex = 20;
            this.ctrFiltredList1.TextBoxVisible = true;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged);
            this.ctrFiltredList1.Load += new System.EventHandler(this.ctrFiltredList1_Load);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::DVLD_Interface.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(312, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 42);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::DVLD_Interface.Properties.Resources.AddPerson_321;
            this.btnAddPerson.Location = new System.Drawing.Point(378, 33);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(49, 42);
            this.btnAddPerson.TabIndex = 23;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrPersonCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrPersonCard1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctrPersonCard1.Location = new System.Drawing.Point(0, 151);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.Size = new System.Drawing.Size(933, 311);
            this.ctrPersonCard1.TabIndex = 25;
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.Color.Transparent;
            this.gbFilters.Controls.Add(this.ctrFiltredList1);
            this.gbFilters.Controls.Add(this.btnSearch);
            this.gbFilters.Controls.Add(this.btnAddPerson);
            this.gbFilters.Location = new System.Drawing.Point(9, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(916, 101);
            this.gbFilters.TabIndex = 26;
            this.gbFilters.TabStop = false;
            // 
            // ctrFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrPersonCard1);
            this.Name = "ctrFindPerson";
            this.Size = new System.Drawing.Size(933, 462);
            this.Load += new System.EventHandler(this.ctrFindPerson_Load);
            this.gbFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DVLD_Interface.Controls.ctrFiltredList ctrFiltredList1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearch;
        private People.Controls.ctrPersonCard ctrPersonCard1;
        private System.Windows.Forms.GroupBox gbFilters;
    }
}
