namespace DVLD_Interface.Controls.Person
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
            this.ctrPersonDetails1 = new DVLD_Interface.Controls.ctrPersonDetails();
            this.ctrFiltredList1 = new DVLD_Interface.Controls.ctrFiltredList();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.BackColor = System.Drawing.Color.Transparent;
            this.ctrPersonDetails1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrPersonDetails1.Location = new System.Drawing.Point(0, 88);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.NatID = null;
            this.ctrPersonDetails1.PersonID = 0;
            this.ctrPersonDetails1.Size = new System.Drawing.Size(934, 486);
            this.ctrPersonDetails1.TabIndex = 18;
            this.ctrPersonDetails1.Load += new System.EventHandler(this.ctrPersonDetails1_Load_1);
            // 
            // ctrFiltredList1
            // 
            this.ctrFiltredList1.BackColor = System.Drawing.Color.Transparent;
            this.ctrFiltredList1.Item = "None";
            this.ctrFiltredList1.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ctrFiltredList1.Items")));
            this.ctrFiltredList1.Location = new System.Drawing.Point(8, 5);
            this.ctrFiltredList1.Name = "ctrFiltredList1";
            this.ctrFiltredList1.Size = new System.Drawing.Size(280, 82);
            this.ctrFiltredList1.TabIndex = 20;
            this.ctrFiltredList1.onTextChanged += new System.Action<string>(this.ctrFiltredList1_onTextChanged);
            this.ctrFiltredList1.Load += new System.EventHandler(this.ctrFiltredList1_Load);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::DVLD_Interface.Properties.Resources.SearchPerson;
            this.btnSearch.Location = new System.Drawing.Point(294, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 42);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::DVLD_Interface.Properties.Resources.AddPerson_321;
            this.btnAddPerson.Location = new System.Drawing.Point(359, 25);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(49, 42);
            this.btnAddPerson.TabIndex = 23;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ctrFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.ctrPersonDetails1);
            this.Controls.Add(this.ctrFiltredList1);
            this.Name = "ctrFindPerson";
            this.Size = new System.Drawing.Size(934, 574);
            this.Load += new System.EventHandler(this.ctrFindPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected ctrFiltredList ctrFiltredList1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearch;
        public ctrPersonDetails ctrPersonDetails1;
    }
}
