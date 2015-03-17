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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSearch));
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ResultList = new System.Windows.Forms.DataGridView();
            this.PrintQ = new System.Windows.Forms.DataGridView();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.RemoveQ = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numberofcopies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddQ = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LastNametxtbox = new System.Windows.Forms.TextBox();
            this.MiddleInittxtbox = new System.Windows.Forms.TextBox();
            this.FirstNametxtbox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forcePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ResultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintQ)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.DarkRed;
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintBtn.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(465, 659);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(254, 63);
            this.PrintBtn.TabIndex = 32;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ResultList
            // 
            this.ResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultList.Location = new System.Drawing.Point(17, 263);
            this.ResultList.Name = "ResultList";
            this.ResultList.RowTemplate.Height = 24;
            this.ResultList.Size = new System.Drawing.Size(987, 166);
            this.ResultList.TabIndex = 30;
            // 
            // PrintQ
            // 
            this.PrintQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintQ.Location = new System.Drawing.Point(12, 503);
            this.PrintQ.Name = "PrintQ";
            this.PrintQ.RowTemplate.Height = 24;
            this.PrintQ.Size = new System.Drawing.Size(992, 150);
            this.PrintQ.TabIndex = 29;
            // 
            // AdminLogin
            // 
            this.AdminLogin.BackColor = System.Drawing.Color.DarkRed;
            this.AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLogin.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AdminLogin.ForeColor = System.Drawing.Color.White;
            this.AdminLogin.Location = new System.Drawing.Point(12, 670);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(135, 50);
            this.AdminLogin.TabIndex = 31;
            this.AdminLogin.Text = "Admin Login";
            this.AdminLogin.UseVisualStyleBackColor = false;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // RemoveQ
            // 
            this.RemoveQ.BackColor = System.Drawing.Color.DarkRed;
            this.RemoveQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveQ.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveQ.ForeColor = System.Drawing.Color.White;
            this.RemoveQ.Location = new System.Drawing.Point(744, 659);
            this.RemoveQ.Name = "RemoveQ";
            this.RemoveQ.Size = new System.Drawing.Size(254, 63);
            this.RemoveQ.TabIndex = 28;
            this.RemoveQ.Text = "Remove";
            this.RemoveQ.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblResult.Location = new System.Drawing.Point(12, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(119, 30);
            this.lblResult.TabIndex = 27;
            this.lblResult.Text = "Result(s):";
            // 
            // numberofcopies
            // 
            this.numberofcopies.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numberofcopies.FormattingEnabled = true;
            this.numberofcopies.Location = new System.Drawing.Point(616, 455);
            this.numberofcopies.Name = "numberofcopies";
            this.numberofcopies.Size = new System.Drawing.Size(78, 29);
            this.numberofcopies.TabIndex = 26;
            this.numberofcopies.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Number of labels per address: ";
            // 
            // AddQ
            // 
            this.AddQ.BackColor = System.Drawing.Color.DarkRed;
            this.AddQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQ.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddQ.ForeColor = System.Drawing.Color.White;
            this.AddQ.Location = new System.Drawing.Point(744, 435);
            this.AddQ.Name = "AddQ";
            this.AddQ.Size = new System.Drawing.Size(254, 63);
            this.AddQ.TabIndex = 23;
            this.AddQ.Text = "Add To Queue";
            this.AddQ.UseVisualStyleBackColor = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.Controls.Add(this.SearchButton);
            this.SearchBox.Controls.Add(this.panel2);
            this.SearchBox.Controls.Add(this.radioButton1);
            this.SearchBox.Controls.Add(this.panel1);
            this.SearchBox.Controls.Add(this.radioButton2);
            this.SearchBox.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(12, 40);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(992, 179);
            this.SearchBox.TabIndex = 24;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search By: ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkRed;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(732, 110);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(254, 63);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(163, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 63);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(319, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ex: (M12345678)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(142, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 41);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(43, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 34);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name  ";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LastNametxtbox);
            this.panel1.Controls.Add(this.MiddleInittxtbox);
            this.panel1.Controls.Add(this.FirstNametxtbox);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.MiddleName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(158, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 63);
            this.panel1.TabIndex = 3;
            // 
            // LastNametxtbox
            // 
            this.LastNametxtbox.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LastNametxtbox.Location = new System.Drawing.Point(574, 16);
            this.LastNametxtbox.Name = "LastNametxtbox";
            this.LastNametxtbox.Size = new System.Drawing.Size(177, 41);
            this.LastNametxtbox.TabIndex = 5;
            // 
            // MiddleInittxtbox
            // 
            this.MiddleInittxtbox.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MiddleInittxtbox.Location = new System.Drawing.Point(333, 16);
            this.MiddleInittxtbox.Name = "MiddleInittxtbox";
            this.MiddleInittxtbox.Size = new System.Drawing.Size(177, 41);
            this.MiddleInittxtbox.TabIndex = 4;
            // 
            // FirstNametxtbox
            // 
            this.FirstNametxtbox.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FirstNametxtbox.Location = new System.Drawing.Point(74, 16);
            this.FirstNametxtbox.Name = "FirstNametxtbox";
            this.FirstNametxtbox.Size = new System.Drawing.Size(177, 41);
            this.FirstNametxtbox.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.Black;
            this.LastName.Location = new System.Drawing.Point(516, 23);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(54, 25);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last:";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.BackColor = System.Drawing.Color.Transparent;
            this.MiddleName.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleName.ForeColor = System.Drawing.Color.Black;
            this.MiddleName.Location = new System.Drawing.Point(257, 23);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(79, 25);
            this.MiddleName.TabIndex = 1;
            this.MiddleName.Text = "Middle:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.Location = new System.Drawing.Point(14, 23);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(56, 25);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(43, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 34);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "MSU ID";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // SearchMenuStrip
            // 
            this.SearchMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.printToolStripMenuItem});
            this.SearchMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SearchMenuStrip.Name = "SearchMenuStrip";
            this.SearchMenuStrip.Size = new System.Drawing.Size(1016, 28);
            this.SearchMenuStrip.TabIndex = 33;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addRemoveToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Enabled = false;
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.searchStudentToolStripMenuItem.Text = "Address";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.addRemoveToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.removeToolStripMenuItem.Text = "Update";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.forcePrintToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // forcePrintToolStripMenuItem
            // 
            this.forcePrintToolStripMenuItem.Name = "forcePrintToolStripMenuItem";
            this.forcePrintToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.forcePrintToolStripMenuItem.Text = "Force Print";
            this.forcePrintToolStripMenuItem.Click += new System.EventHandler(this.forcePrintToolStripMenuItem_Click);
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PO.Properties.Resources.postBG1;
            this.ClientSize = new System.Drawing.Size(1016, 733);
            this.Controls.Add(this.SearchMenuStrip);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.PrintQ);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.RemoveQ);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.numberofcopies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddQ);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1034, 780);
            this.MinimumSize = new System.Drawing.Size(1034, 780);
            this.Name = "StudentSearch";
            this.Text = "Midwestern State University - Post Office";
            ((System.ComponentModel.ISupportInitialize)(this.ResultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintQ)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.DataGridView ResultList;
        private System.Windows.Forms.DataGridView PrintQ;
        private System.Windows.Forms.Button AdminLogin;
        private System.Windows.Forms.Button RemoveQ;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox numberofcopies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddQ;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LastNametxtbox;
        private System.Windows.Forms.TextBox MiddleInittxtbox;
        private System.Windows.Forms.TextBox FirstNametxtbox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MenuStrip SearchMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forcePrintToolStripMenuItem;
    }
}

