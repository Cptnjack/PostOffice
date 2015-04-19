namespace PO
{
    partial class ChangePassword
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
            this.adminTableDataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pODBDataSet = new PO.PODBDataSet();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changepwdbtn = new System.Windows.Forms.Button();
            this.confirmpwdtxt = new System.Windows.Forms.TextBox();
            this.newpwdtxt = new System.Windows.Forms.TextBox();
            this.currentpwdtxt = new System.Windows.Forms.TextBox();
            this.confirmpwdlbl = new System.Windows.Forms.Label();
            this.newpwdlbl = new System.Windows.Forms.Label();
            this.currentpwdlbl = new System.Windows.Forms.Label();
            this.adminTableTableAdapter = new PO.PODBDataSetTableAdapters.AdminTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SearchMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTableDataGridView
            // 
            this.adminTableDataGridView.AutoGenerateColumns = false;
            this.adminTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.adminTableDataGridView.DataSource = this.adminTableBindingSource;
            this.adminTableDataGridView.Location = new System.Drawing.Point(28, 454);
            this.adminTableDataGridView.Name = "adminTableDataGridView";
            this.adminTableDataGridView.Size = new System.Drawing.Size(645, 220);
            this.adminTableDataGridView.TabIndex = 59;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // adminTableBindingSource
            // 
            this.adminTableBindingSource.DataMember = "AdminTable";
            this.adminTableBindingSource.DataSource = this.pODBDataSet;
            // 
            // pODBDataSet
            // 
            this.pODBDataSet.DataSetName = "PODBDataSet";
            this.pODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.Color.DarkRed;
            this.HomePic.Image = global::PO.Properties.Resources.home_icon;
            this.HomePic.Location = new System.Drawing.Point(354, 398);
            this.HomePic.Margin = new System.Windows.Forms.Padding(2);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(34, 37);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 58;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // SearchMenuStrip
            // 
            this.SearchMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.searchStudentToolStripMenuItem});
            this.SearchMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SearchMenuStrip.Name = "SearchMenuStrip";
            this.SearchMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.SearchMenuStrip.Size = new System.Drawing.Size(764, 24);
            this.SearchMenuStrip.TabIndex = 48;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.searchStudentToolStripMenuItem.Text = "Address";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // changepwdbtn
            // 
            this.changepwdbtn.BackColor = System.Drawing.Color.DarkRed;
            this.changepwdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepwdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepwdbtn.ForeColor = System.Drawing.Color.White;
            this.changepwdbtn.Location = new System.Drawing.Point(252, 318);
            this.changepwdbtn.Margin = new System.Windows.Forms.Padding(2);
            this.changepwdbtn.Name = "changepwdbtn";
            this.changepwdbtn.Size = new System.Drawing.Size(239, 67);
            this.changepwdbtn.TabIndex = 57;
            this.changepwdbtn.Text = "Change Password";
            this.changepwdbtn.UseVisualStyleBackColor = false;
            this.changepwdbtn.Click += new System.EventHandler(this.changepwdbtn_Click);
            // 
            // confirmpwdtxt
            // 
            this.confirmpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpwdtxt.Location = new System.Drawing.Point(252, 269);
            this.confirmpwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmpwdtxt.Name = "confirmpwdtxt";
            this.confirmpwdtxt.Size = new System.Drawing.Size(240, 26);
            this.confirmpwdtxt.TabIndex = 56;
            // 
            // newpwdtxt
            // 
            this.newpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpwdtxt.Location = new System.Drawing.Point(252, 205);
            this.newpwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.newpwdtxt.Name = "newpwdtxt";
            this.newpwdtxt.Size = new System.Drawing.Size(240, 26);
            this.newpwdtxt.TabIndex = 55;
            // 
            // currentpwdtxt
            // 
            this.currentpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpwdtxt.Location = new System.Drawing.Point(252, 138);
            this.currentpwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.currentpwdtxt.Name = "currentpwdtxt";
            this.currentpwdtxt.Size = new System.Drawing.Size(240, 26);
            this.currentpwdtxt.TabIndex = 54;
            // 
            // confirmpwdlbl
            // 
            this.confirmpwdlbl.AutoSize = true;
            this.confirmpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpwdlbl.Location = new System.Drawing.Point(248, 243);
            this.confirmpwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmpwdlbl.Name = "confirmpwdlbl";
            this.confirmpwdlbl.Size = new System.Drawing.Size(216, 24);
            this.confirmpwdlbl.TabIndex = 52;
            this.confirmpwdlbl.Text = "Confirm New Password: ";
            // 
            // newpwdlbl
            // 
            this.newpwdlbl.AutoSize = true;
            this.newpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.newpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpwdlbl.Location = new System.Drawing.Point(248, 178);
            this.newpwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newpwdlbl.Name = "newpwdlbl";
            this.newpwdlbl.Size = new System.Drawing.Size(146, 24);
            this.newpwdlbl.TabIndex = 51;
            this.newpwdlbl.Text = "New Password: ";
            // 
            // currentpwdlbl
            // 
            this.currentpwdlbl.AutoSize = true;
            this.currentpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.currentpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpwdlbl.Location = new System.Drawing.Point(248, 111);
            this.currentpwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentpwdlbl.Name = "currentpwdlbl";
            this.currentpwdlbl.Size = new System.Drawing.Size(169, 24);
            this.currentpwdlbl.TabIndex = 50;
            this.currentpwdlbl.Text = "Current Password: ";
            // 
            // adminTableTableAdapter
            // 
            this.adminTableTableAdapter.ClearBeforeFill = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.Controls.Add(this.adminTableDataGridView);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.SearchMenuStrip);
            this.Controls.Add(this.changepwdbtn);
            this.Controls.Add(this.confirmpwdtxt);
            this.Controls.Add(this.newpwdtxt);
            this.Controls.Add(this.currentpwdtxt);
            this.Controls.Add(this.confirmpwdlbl);
            this.Controls.Add(this.newpwdlbl);
            this.Controls.Add(this.currentpwdlbl);
            this.MaximumSize = new System.Drawing.Size(780, 641);
            this.MinimumSize = new System.Drawing.Size(780, 641);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.adminTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminTableDataGridView;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.MenuStrip SearchMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button changepwdbtn;
        private System.Windows.Forms.TextBox confirmpwdtxt;
        private System.Windows.Forms.TextBox newpwdtxt;
        private System.Windows.Forms.TextBox currentpwdtxt;
        private System.Windows.Forms.Label confirmpwdlbl;
        private System.Windows.Forms.Label newpwdlbl;
        private System.Windows.Forms.Label currentpwdlbl;
        private PODBDataSet pODBDataSet;
        private System.Windows.Forms.BindingSource adminTableBindingSource;
        private PODBDataSetTableAdapters.AdminTableTableAdapter adminTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}