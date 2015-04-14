namespace PO
{
    partial class StudentSearch
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LastNametxtbox = new System.Windows.Forms.TextBox();
            this.MiddleInittxtbox = new System.Windows.Forms.TextBox();
            this.FirstNametxtbox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forcePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ResultList = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.PrintQ = new System.Windows.Forms.DataGridView();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.RemoveQ = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numberofcopies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddQ = new System.Windows.Forms.Button();
            this.pODBDataSet = new PO.PODBDataSet();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableTableAdapter = new PO.PODBDataSetTableAdapters.StudentTableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newStreetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSUAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSUStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSUZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustangNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSUCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptMBNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.SearchMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultList)).BeginInit();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(129, 347);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 51);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(122, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 51);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(239, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ex: (M12345678)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID: ";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTextBox.Location = new System.Drawing.Point(106, 12);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(128, 23);
            this.idTextBox.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(32, 32);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name  ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.radiobuttons_CheckChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LastNametxtbox);
            this.panel1.Controls.Add(this.MiddleInittxtbox);
            this.panel1.Controls.Add(this.FirstNametxtbox);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.MiddleName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(118, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 51);
            this.panel1.TabIndex = 3;
            // 
            // LastNametxtbox
            // 
            this.LastNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LastNametxtbox.Location = new System.Drawing.Point(430, 13);
            this.LastNametxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNametxtbox.Name = "LastNametxtbox";
            this.LastNametxtbox.Size = new System.Drawing.Size(134, 23);
            this.LastNametxtbox.TabIndex = 5;
            // 
            // MiddleInittxtbox
            // 
            this.MiddleInittxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MiddleInittxtbox.Location = new System.Drawing.Point(250, 13);
            this.MiddleInittxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.MiddleInittxtbox.Name = "MiddleInittxtbox";
            this.MiddleInittxtbox.Size = new System.Drawing.Size(134, 23);
            this.MiddleInittxtbox.TabIndex = 4;
            // 
            // FirstNametxtbox
            // 
            this.FirstNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FirstNametxtbox.Location = new System.Drawing.Point(56, 13);
            this.FirstNametxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNametxtbox.Name = "FirstNametxtbox";
            this.FirstNametxtbox.Size = new System.Drawing.Size(134, 23);
            this.FirstNametxtbox.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.Black;
            this.LastName.Location = new System.Drawing.Point(387, 19);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(44, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last:";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.BackColor = System.Drawing.Color.Transparent;
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.ForeColor = System.Drawing.Color.Black;
            this.MiddleName.Location = new System.Drawing.Point(193, 19);
            this.MiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(59, 20);
            this.MiddleName.TabIndex = 1;
            this.MiddleName.Text = "Middle:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.Location = new System.Drawing.Point(10, 19);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(44, 20);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkRed;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(549, 89);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(190, 51);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(32, 89);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 28);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "MSU ID";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radiobuttons_CheckChanged);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.adminHomeToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // adminHomeToolStripMenuItem
            // 
            this.adminHomeToolStripMenuItem.Name = "adminHomeToolStripMenuItem";
            this.adminHomeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.adminHomeToolStripMenuItem.Text = "Admin Home";
            this.adminHomeToolStripMenuItem.Click += new System.EventHandler(this.adminHomeToolStripMenuItem_Click);
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.addressToolStripMenuItem.Text = "Address";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.add_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateButton_Click);
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
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // forcePrintToolStripMenuItem
            // 
            this.forcePrintToolStripMenuItem.Name = "forcePrintToolStripMenuItem";
            this.forcePrintToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.forcePrintToolStripMenuItem.Text = "Force Print";
            this.forcePrintToolStripMenuItem.Click += new System.EventHandler(this.forcePrintToolStripMenuItem_Click);
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.DarkRed;
            this.homePictureBox.Image = global::PO.Properties.Resources.home_icon;
            this.homePictureBox.Location = new System.Drawing.Point(129, 538);
            this.homePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(36, 41);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePictureBox.TabIndex = 49;
            this.homePictureBox.TabStop = false;
            this.homePictureBox.Click += new System.EventHandler(this.adminHomeToolStripMenuItem_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkRed;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(15, 347);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 51);
            this.updateButton.TabIndex = 48;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // SearchMenuStrip
            // 
            this.SearchMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.printToolStripMenuItem});
            this.SearchMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SearchMenuStrip.Name = "SearchMenuStrip";
            this.SearchMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.SearchMenuStrip.Size = new System.Drawing.Size(764, 24);
            this.SearchMenuStrip.TabIndex = 47;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.DarkRed;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(351, 529);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(190, 51);
            this.PrintBtn.TabIndex = 46;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // ResultList
            // 
            this.ResultList.AutoGenerateColumns = false;
            this.ResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.newStreetAddressDataGridViewTextBoxColumn,
            this.newCityDataGridViewTextBoxColumn,
            this.newStateDataGridViewTextBoxColumn,
            this.newZipDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mSUAddressDataGridViewTextBoxColumn,
            this.mSUStateDataGridViewTextBoxColumn,
            this.mSUZipDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.mustangNumberDataGridViewTextBoxColumn,
            this.newCountryDataGridViewTextBoxColumn,
            this.mSUCityDataGridViewTextBoxColumn,
            this.aptMBNoDataGridViewTextBoxColumn});
            this.ResultList.DataSource = this.studentTableBindingSource;
            this.ResultList.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.ResultList.Location = new System.Drawing.Point(15, 208);
            this.ResultList.Margin = new System.Windows.Forms.Padding(2);
            this.ResultList.Name = "ResultList";
            this.ResultList.RowHeadersVisible = false;
            this.ResultList.RowTemplate.Height = 24;
            this.ResultList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultList.Size = new System.Drawing.Size(740, 135);
            this.ResultList.TabIndex = 44;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.Controls.Add(this.SearchButton);
            this.SearchBox.Controls.Add(this.panel2);
            this.SearchBox.Controls.Add(this.radioButton1);
            this.SearchBox.Controls.Add(this.panel1);
            this.SearchBox.Controls.Add(this.radioButton2);
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(11, 26);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Padding = new System.Windows.Forms.Padding(2);
            this.SearchBox.Size = new System.Drawing.Size(744, 145);
            this.SearchBox.TabIndex = 38;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search By: ";
            // 
            // PrintQ
            // 
            this.PrintQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintQ.Location = new System.Drawing.Point(11, 403);
            this.PrintQ.Margin = new System.Windows.Forms.Padding(2);
            this.PrintQ.Name = "PrintQ";
            this.PrintQ.RowTemplate.Height = 24;
            this.PrintQ.Size = new System.Drawing.Size(744, 122);
            this.PrintQ.TabIndex = 43;
            // 
            // AdminLogin
            // 
            this.AdminLogin.BackColor = System.Drawing.Color.DarkRed;
            this.AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AdminLogin.ForeColor = System.Drawing.Color.White;
            this.AdminLogin.Location = new System.Drawing.Point(11, 538);
            this.AdminLogin.Margin = new System.Windows.Forms.Padding(2);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(101, 41);
            this.AdminLogin.TabIndex = 45;
            this.AdminLogin.Text = "Admin Login";
            this.AdminLogin.UseVisualStyleBackColor = false;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // RemoveQ
            // 
            this.RemoveQ.BackColor = System.Drawing.Color.DarkRed;
            this.RemoveQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveQ.ForeColor = System.Drawing.Color.White;
            this.RemoveQ.Location = new System.Drawing.Point(560, 529);
            this.RemoveQ.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveQ.Name = "RemoveQ";
            this.RemoveQ.Size = new System.Drawing.Size(190, 51);
            this.RemoveQ.TabIndex = 42;
            this.RemoveQ.Text = "Remove";
            this.RemoveQ.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblResult.Location = new System.Drawing.Point(11, 181);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 24);
            this.lblResult.TabIndex = 41;
            this.lblResult.Text = "Result(s):";
            // 
            // numberofcopies
            // 
            this.numberofcopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numberofcopies.FormattingEnabled = true;
            this.numberofcopies.Location = new System.Drawing.Point(464, 364);
            this.numberofcopies.Margin = new System.Windows.Forms.Padding(2);
            this.numberofcopies.Name = "numberofcopies";
            this.numberofcopies.Size = new System.Drawing.Size(60, 25);
            this.numberofcopies.TabIndex = 40;
            this.numberofcopies.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Number of labels per address: ";
            // 
            // AddQ
            // 
            this.AddQ.BackColor = System.Drawing.Color.DarkRed;
            this.AddQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddQ.ForeColor = System.Drawing.Color.White;
            this.AddQ.Location = new System.Drawing.Point(560, 347);
            this.AddQ.Margin = new System.Windows.Forms.Padding(2);
            this.AddQ.Name = "AddQ";
            this.AddQ.Size = new System.Drawing.Size(190, 51);
            this.AddQ.TabIndex = 37;
            this.AddQ.Text = "Add To Queue";
            this.AddQ.UseVisualStyleBackColor = false;
            // 
            // pODBDataSet
            // 
            this.pODBDataSet.DataSetName = "PODBDataSet";
            this.pODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.pODBDataSet;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // newStreetAddressDataGridViewTextBoxColumn
            // 
            this.newStreetAddressDataGridViewTextBoxColumn.DataPropertyName = "New Street Address";
            this.newStreetAddressDataGridViewTextBoxColumn.HeaderText = "New Street Address";
            this.newStreetAddressDataGridViewTextBoxColumn.Name = "newStreetAddressDataGridViewTextBoxColumn";
            // 
            // newCityDataGridViewTextBoxColumn
            // 
            this.newCityDataGridViewTextBoxColumn.DataPropertyName = "New City";
            this.newCityDataGridViewTextBoxColumn.HeaderText = "New City";
            this.newCityDataGridViewTextBoxColumn.Name = "newCityDataGridViewTextBoxColumn";
            // 
            // newStateDataGridViewTextBoxColumn
            // 
            this.newStateDataGridViewTextBoxColumn.DataPropertyName = "New State";
            this.newStateDataGridViewTextBoxColumn.HeaderText = "New State";
            this.newStateDataGridViewTextBoxColumn.Name = "newStateDataGridViewTextBoxColumn";
            // 
            // newZipDataGridViewTextBoxColumn
            // 
            this.newZipDataGridViewTextBoxColumn.DataPropertyName = "New Zip";
            this.newZipDataGridViewTextBoxColumn.HeaderText = "New Zip";
            this.newZipDataGridViewTextBoxColumn.Name = "newZipDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // mSUAddressDataGridViewTextBoxColumn
            // 
            this.mSUAddressDataGridViewTextBoxColumn.DataPropertyName = "MSU Address";
            this.mSUAddressDataGridViewTextBoxColumn.HeaderText = "MSU Address";
            this.mSUAddressDataGridViewTextBoxColumn.Name = "mSUAddressDataGridViewTextBoxColumn";
            // 
            // mSUStateDataGridViewTextBoxColumn
            // 
            this.mSUStateDataGridViewTextBoxColumn.DataPropertyName = "MSU State";
            this.mSUStateDataGridViewTextBoxColumn.HeaderText = "MSU State";
            this.mSUStateDataGridViewTextBoxColumn.Name = "mSUStateDataGridViewTextBoxColumn";
            // 
            // mSUZipDataGridViewTextBoxColumn
            // 
            this.mSUZipDataGridViewTextBoxColumn.DataPropertyName = "MSU Zip";
            this.mSUZipDataGridViewTextBoxColumn.HeaderText = "MSU Zip";
            this.mSUZipDataGridViewTextBoxColumn.Name = "mSUZipDataGridViewTextBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // mustangNumberDataGridViewTextBoxColumn
            // 
            this.mustangNumberDataGridViewTextBoxColumn.DataPropertyName = "Mustang Number";
            this.mustangNumberDataGridViewTextBoxColumn.HeaderText = "Mustang Number";
            this.mustangNumberDataGridViewTextBoxColumn.Name = "mustangNumberDataGridViewTextBoxColumn";
            // 
            // newCountryDataGridViewTextBoxColumn
            // 
            this.newCountryDataGridViewTextBoxColumn.DataPropertyName = "New Country";
            this.newCountryDataGridViewTextBoxColumn.HeaderText = "New Country";
            this.newCountryDataGridViewTextBoxColumn.Name = "newCountryDataGridViewTextBoxColumn";
            // 
            // mSUCityDataGridViewTextBoxColumn
            // 
            this.mSUCityDataGridViewTextBoxColumn.DataPropertyName = "MSU City";
            this.mSUCityDataGridViewTextBoxColumn.HeaderText = "MSU City";
            this.mSUCityDataGridViewTextBoxColumn.Name = "mSUCityDataGridViewTextBoxColumn";
            // 
            // aptMBNoDataGridViewTextBoxColumn
            // 
            this.aptMBNoDataGridViewTextBoxColumn.DataPropertyName = "AptMBNo";
            this.aptMBNoDataGridViewTextBoxColumn.HeaderText = "AptMBNo";
            this.aptMBNoDataGridViewTextBoxColumn.Name = "aptMBNoDataGridViewTextBoxColumn";
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.homePictureBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.SearchMenuStrip);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.PrintQ);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.RemoveQ);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.numberofcopies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddQ);
            this.MaximumSize = new System.Drawing.Size(780, 641);
            this.MinimumSize = new System.Drawing.Size(780, 641);
            this.Name = "StudentSearch";
            this.Text = "StudentSearch";
            this.Load += new System.EventHandler(this.StudentSearch_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultList)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LastNametxtbox;
        private System.Windows.Forms.TextBox MiddleInittxtbox;
        private System.Windows.Forms.TextBox FirstNametxtbox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forcePrintToolStripMenuItem;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.MenuStrip SearchMenuStrip;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.DataGridView ResultList;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.DataGridView PrintQ;
        private System.Windows.Forms.Button AdminLogin;
        private System.Windows.Forms.Button RemoveQ;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox numberofcopies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddQ;
        private PODBDataSet pODBDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private PODBDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newStreetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSUAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSUStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSUZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustangNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSUCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptMBNoDataGridViewTextBoxColumn;
    }
}