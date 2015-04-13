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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.changepwdbtn = new System.Windows.Forms.Button();
            this.confirmpwdtxt = new System.Windows.Forms.TextBox();
            this.newpwdtxt = new System.Windows.Forms.TextBox();
            this.currentpwdtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.confirmpwdlbl = new System.Windows.Forms.Label();
            this.newpwdlbl = new System.Windows.Forms.Label();
            this.currentpwdlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.forcePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pODBDataSet = new PO.PODBDataSet();
            this.adminTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableTableAdapter = new PO.PODBDataSetTableAdapters.AdminTableTableAdapter();
            this.tableAdapterManager = new PO.PODBDataSetTableAdapters.TableAdapterManager();
            this.adminTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SearchMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // changepwdbtn
            // 
            this.changepwdbtn.BackColor = System.Drawing.Color.DarkRed;
            this.changepwdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepwdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepwdbtn.ForeColor = System.Drawing.Color.White;
            this.changepwdbtn.Location = new System.Drawing.Point(248, 389);
            this.changepwdbtn.Margin = new System.Windows.Forms.Padding(2);
            this.changepwdbtn.Name = "changepwdbtn";
            this.changepwdbtn.Size = new System.Drawing.Size(239, 67);
            this.changepwdbtn.TabIndex = 45;
            this.changepwdbtn.Text = "Change Password";
            this.changepwdbtn.UseVisualStyleBackColor = false;
            this.changepwdbtn.Click += new System.EventHandler(this.changepwdbtn_Click);
            // 
            // confirmpwdtxt
            // 
            this.confirmpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpwdtxt.Location = new System.Drawing.Point(248, 340);
            this.confirmpwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmpwdtxt.Name = "confirmpwdtxt";
            this.confirmpwdtxt.Size = new System.Drawing.Size(240, 26);
            this.confirmpwdtxt.TabIndex = 44;
            // 
            // newpwdtxt
            // 
            this.newpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpwdtxt.Location = new System.Drawing.Point(248, 276);
            this.newpwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.newpwdtxt.Name = "newpwdtxt";
            this.newpwdtxt.Size = new System.Drawing.Size(240, 26);
            this.newpwdtxt.TabIndex = 43;
            // 
            // currentpwdtxt
            // 
            this.currentpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpwdtxt.Location = new System.Drawing.Point(248, 209);
            this.currentpwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.currentpwdtxt.Name = "currentpwdtxt";
            this.currentpwdtxt.Size = new System.Drawing.Size(240, 26);
            this.currentpwdtxt.TabIndex = 42;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(248, 143);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(240, 26);
            this.usernametxt.TabIndex = 41;
            // 
            // confirmpwdlbl
            // 
            this.confirmpwdlbl.AutoSize = true;
            this.confirmpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpwdlbl.Location = new System.Drawing.Point(244, 314);
            this.confirmpwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmpwdlbl.Name = "confirmpwdlbl";
            this.confirmpwdlbl.Size = new System.Drawing.Size(216, 24);
            this.confirmpwdlbl.TabIndex = 40;
            this.confirmpwdlbl.Text = "Confirm New Password: ";
            // 
            // newpwdlbl
            // 
            this.newpwdlbl.AutoSize = true;
            this.newpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.newpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpwdlbl.Location = new System.Drawing.Point(244, 249);
            this.newpwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newpwdlbl.Name = "newpwdlbl";
            this.newpwdlbl.Size = new System.Drawing.Size(146, 24);
            this.newpwdlbl.TabIndex = 39;
            this.newpwdlbl.Text = "New Password: ";
            // 
            // currentpwdlbl
            // 
            this.currentpwdlbl.AutoSize = true;
            this.currentpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.currentpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpwdlbl.Location = new System.Drawing.Point(244, 182);
            this.currentpwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentpwdlbl.Name = "currentpwdlbl";
            this.currentpwdlbl.Size = new System.Drawing.Size(169, 24);
            this.currentpwdlbl.TabIndex = 38;
            this.currentpwdlbl.Text = "Current Password: ";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(244, 116);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(107, 24);
            this.usernamelbl.TabIndex = 37;
            this.usernamelbl.Text = "Username: ";
            // 
            // forcePrintToolStripMenuItem
            // 
            this.forcePrintToolStripMenuItem.Name = "forcePrintToolStripMenuItem";
            this.forcePrintToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.forcePrintToolStripMenuItem.Text = "Force Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.forcePrintToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addRemoveToolStripMenuItem.Text = "Add";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addRemoveToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.searchStudentToolStripMenuItem.Text = "Address";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
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
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.Color.DarkRed;
            this.HomePic.Image = global::PO.Properties.Resources.home_icon;
            this.HomePic.Location = new System.Drawing.Point(350, 469);
            this.HomePic.Margin = new System.Windows.Forms.Padding(2);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(34, 37);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 46;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // SearchMenuStrip
            // 
            this.SearchMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.printToolStripMenuItem});
            this.SearchMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SearchMenuStrip.Name = "SearchMenuStrip";
            this.SearchMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.SearchMenuStrip.Size = new System.Drawing.Size(747, 24);
            this.SearchMenuStrip.TabIndex = 36;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // pODBDataSet
            // 
            this.pODBDataSet.DataSetName = "PODBDataSet";
            this.pODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableBindingSource
            // 
            this.adminTableBindingSource.DataMember = "AdminTable";
            this.adminTableBindingSource.DataSource = this.pODBDataSet;
            // 
            // adminTableTableAdapter
            // 
            this.adminTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableTableAdapter = this.adminTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PO.PODBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminTableDataGridView
            // 
            this.adminTableDataGridView.AutoGenerateColumns = false;
            this.adminTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.adminTableDataGridView.DataSource = this.adminTableBindingSource;
            this.adminTableDataGridView.Location = new System.Drawing.Point(12, 519);
            this.adminTableDataGridView.Name = "adminTableDataGridView";
            this.adminTableDataGridView.Size = new System.Drawing.Size(645, 220);
            this.adminTableDataGridView.TabIndex = 47;
            this.adminTableDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID1";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PO.Properties.Resources.postBG1;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.Controls.Add(this.adminTableDataGridView);
            this.Controls.Add(this.changepwdbtn);
            this.Controls.Add(this.confirmpwdtxt);
            this.Controls.Add(this.newpwdtxt);
            this.Controls.Add(this.currentpwdtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.confirmpwdlbl);
            this.Controls.Add(this.newpwdlbl);
            this.Controls.Add(this.currentpwdlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.SearchMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 641);
            this.MinimumSize = new System.Drawing.Size(780, 641);
            this.Name = "ChangePassword";
            this.Text = "Midwestern State University - Post Office - Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changepwdbtn;
        private System.Windows.Forms.TextBox confirmpwdtxt;
        private System.Windows.Forms.TextBox newpwdtxt;
        private System.Windows.Forms.TextBox currentpwdtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label confirmpwdlbl;
        private System.Windows.Forms.Label newpwdlbl;
        private System.Windows.Forms.Label currentpwdlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.ToolStripMenuItem forcePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.MenuStrip SearchMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private PODBDataSet pODBDataSet;
        private System.Windows.Forms.BindingSource adminTableBindingSource;
        private PODBDataSetTableAdapters.AdminTableTableAdapter adminTableTableAdapter;
        private PODBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView adminTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}