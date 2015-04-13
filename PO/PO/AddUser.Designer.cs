namespace PO
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forcePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changepwdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.adduserbtn = new System.Windows.Forms.Button();
            this.lasttxt = new System.Windows.Forms.TextBox();
            this.lastlbl = new System.Windows.Forms.Label();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.firstlbl = new System.Windows.Forms.Label();
            this.confirmtxt = new System.Windows.Forms.TextBox();
            this.confirmlbl = new System.Windows.Forms.Label();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.adminTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pODBDataSet = new PO.PODBDataSet();
            this.adminTableTableAdapter = new PO.PODBDataSetTableAdapters.AdminTableTableAdapter();
            this.tableAdapterManager = new PO.PODBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SearchMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // forcePrintToolStripMenuItem
            // 
            this.forcePrintToolStripMenuItem.Name = "forcePrintToolStripMenuItem";
            this.forcePrintToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.forcePrintToolStripMenuItem.Text = "Force Print";
            this.forcePrintToolStripMenuItem.Click += new System.EventHandler(this.forcePrintToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
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
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.removeToolStripMenuItem.Text = "Update";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addRemoveToolStripMenuItem.Text = "Add";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // changepwdToolStripMenuItem
            // 
            this.changepwdToolStripMenuItem.Name = "changepwdToolStripMenuItem";
            this.changepwdToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changepwdToolStripMenuItem.Text = "Change Password";
            this.changepwdToolStripMenuItem.Click += new System.EventHandler(this.changepwdToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeUserToolStripMenuItem,
            this.changepwdToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.Color.DarkRed;
            this.HomePic.Image = global::PO.Properties.Resources.home_icon;
            this.HomePic.Location = new System.Drawing.Point(372, 457);
            this.HomePic.Margin = new System.Windows.Forms.Padding(2);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(34, 37);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 48;
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
            this.SearchMenuStrip.TabIndex = 47;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // adduserbtn
            // 
            this.adduserbtn.BackColor = System.Drawing.Color.DarkRed;
            this.adduserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserbtn.ForeColor = System.Drawing.Color.White;
            this.adduserbtn.Location = new System.Drawing.Point(269, 379);
            this.adduserbtn.Margin = new System.Windows.Forms.Padding(2);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Size = new System.Drawing.Size(239, 67);
            this.adduserbtn.TabIndex = 46;
            this.adduserbtn.Text = "Add User";
            this.adduserbtn.UseVisualStyleBackColor = false;
            this.adduserbtn.Click += new System.EventHandler(this.adduserbtn_Click);
            // 
            // lasttxt
            // 
            this.lasttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasttxt.Location = new System.Drawing.Point(158, 237);
            this.lasttxt.Margin = new System.Windows.Forms.Padding(2);
            this.lasttxt.Name = "lasttxt";
            this.lasttxt.Size = new System.Drawing.Size(240, 26);
            this.lasttxt.TabIndex = 45;
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.BackColor = System.Drawing.Color.Transparent;
            this.lastlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastlbl.Location = new System.Drawing.Point(155, 210);
            this.lastlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(101, 24);
            this.lastlbl.TabIndex = 44;
            this.lastlbl.Text = "Last name:";
            // 
            // firsttxt
            // 
            this.firsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firsttxt.Location = new System.Drawing.Point(158, 172);
            this.firsttxt.Margin = new System.Windows.Forms.Padding(2);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.Size = new System.Drawing.Size(240, 26);
            this.firsttxt.TabIndex = 41;
            // 
            // firstlbl
            // 
            this.firstlbl.AutoSize = true;
            this.firstlbl.BackColor = System.Drawing.Color.Transparent;
            this.firstlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstlbl.Location = new System.Drawing.Point(155, 146);
            this.firstlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstlbl.Name = "firstlbl";
            this.firstlbl.Size = new System.Drawing.Size(108, 24);
            this.firstlbl.TabIndex = 40;
            this.firstlbl.Text = "First name: ";
            // 
            // confirmtxt
            // 
            this.confirmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmtxt.Location = new System.Drawing.Point(414, 306);
            this.confirmtxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmtxt.Name = "confirmtxt";
            this.confirmtxt.PasswordChar = '*';
            this.confirmtxt.Size = new System.Drawing.Size(240, 26);
            this.confirmtxt.TabIndex = 39;
            // 
            // confirmlbl
            // 
            this.confirmlbl.AutoSize = true;
            this.confirmlbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmlbl.Location = new System.Drawing.Point(410, 280);
            this.confirmlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmlbl.Name = "confirmlbl";
            this.confirmlbl.Size = new System.Drawing.Size(167, 24);
            this.confirmlbl.TabIndex = 38;
            this.confirmlbl.Text = "Confirm Password:";
            // 
            // pwdtxt
            // 
            this.pwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.Location = new System.Drawing.Point(414, 239);
            this.pwdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(240, 26);
            this.pwdtxt.TabIndex = 37;
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.pwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlbl.Location = new System.Drawing.Point(410, 212);
            this.pwdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(97, 24);
            this.pwdlbl.TabIndex = 36;
            this.pwdlbl.Text = "Password:";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(414, 173);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(240, 26);
            this.usernametxt.TabIndex = 35;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(410, 146);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(107, 24);
            this.usernamelbl.TabIndex = 34;
            this.usernamelbl.Text = "Username: ";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.Color.Transparent;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(155, 278);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(67, 24);
            this.emaillbl.TabIndex = 49;
            this.emaillbl.Text = "Email: ";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(158, 305);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(240, 26);
            this.emailtxt.TabIndex = 50;
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
            this.adminTableDataGridView.Location = new System.Drawing.Point(3, 510);
            this.adminTableDataGridView.Name = "adminTableDataGridView";
            this.adminTableDataGridView.Size = new System.Drawing.Size(651, 220);
            this.adminTableDataGridView.TabIndex = 51;
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
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PO.Properties.Resources.postBG1;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.Controls.Add(this.adminTableDataGridView);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.SearchMenuStrip);
            this.Controls.Add(this.adduserbtn);
            this.Controls.Add(this.lasttxt);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.firstlbl);
            this.Controls.Add(this.confirmtxt);
            this.Controls.Add(this.confirmlbl);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.usernamelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 641);
            this.MinimumSize = new System.Drawing.Size(780, 641);
            this.Name = "AddUser";
            this.Text = "Midwestern State University - Post Office - Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forcePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changepwdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.MenuStrip SearchMenuStrip;
        private System.Windows.Forms.Button adduserbtn;
        private System.Windows.Forms.TextBox lasttxt;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.Label firstlbl;
        private System.Windows.Forms.TextBox confirmtxt;
        private System.Windows.Forms.Label confirmlbl;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox emailtxt;
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