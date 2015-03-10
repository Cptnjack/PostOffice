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
            this.middletxt = new System.Windows.Forms.TextBox();
            this.middlelbl = new System.Windows.Forms.Label();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.firstlbl = new System.Windows.Forms.Label();
            this.confirmtxt = new System.Windows.Forms.TextBox();
            this.confirmlbl = new System.Windows.Forms.Label();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SearchMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // forcePrintToolStripMenuItem
            // 
            this.forcePrintToolStripMenuItem.Name = "forcePrintToolStripMenuItem";
            this.forcePrintToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.forcePrintToolStripMenuItem.Text = "Force Print";
            this.forcePrintToolStripMenuItem.Click += new System.EventHandler(this.forcePrintToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
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
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.removeToolStripMenuItem.Text = "Update";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.addRemoveToolStripMenuItem.Text = "Add";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
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
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.searchStudentToolStripMenuItem.Text = "Address";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // changepwdToolStripMenuItem
            // 
            this.changepwdToolStripMenuItem.Name = "changepwdToolStripMenuItem";
            this.changepwdToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
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
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.Color.DarkRed;
            this.HomePic.Image = global::PO.Properties.Resources.home_icon;
            this.HomePic.Location = new System.Drawing.Point(496, 562);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(45, 45);
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
            this.SearchMenuStrip.Size = new System.Drawing.Size(1016, 28);
            this.SearchMenuStrip.TabIndex = 47;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // adduserbtn
            // 
            this.adduserbtn.BackColor = System.Drawing.Color.DarkRed;
            this.adduserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduserbtn.Font = new System.Drawing.Font("Adobe Heiti Std R", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserbtn.ForeColor = System.Drawing.Color.White;
            this.adduserbtn.Location = new System.Drawing.Point(359, 466);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Size = new System.Drawing.Size(319, 82);
            this.adduserbtn.TabIndex = 46;
            this.adduserbtn.Text = "Add User";
            this.adduserbtn.UseVisualStyleBackColor = false;
            // 
            // lasttxt
            // 
            this.lasttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasttxt.Location = new System.Drawing.Point(165, 399);
            this.lasttxt.Name = "lasttxt";
            this.lasttxt.Size = new System.Drawing.Size(319, 30);
            this.lasttxt.TabIndex = 45;
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.BackColor = System.Drawing.Color.Transparent;
            this.lastlbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastlbl.Location = new System.Drawing.Point(160, 366);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(130, 30);
            this.lastlbl.TabIndex = 44;
            this.lastlbl.Text = "Last name:";
            // 
            // middletxt
            // 
            this.middletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middletxt.Location = new System.Drawing.Point(165, 316);
            this.middletxt.Name = "middletxt";
            this.middletxt.Size = new System.Drawing.Size(319, 30);
            this.middletxt.TabIndex = 43;
            // 
            // middlelbl
            // 
            this.middlelbl.AutoSize = true;
            this.middlelbl.BackColor = System.Drawing.Color.Transparent;
            this.middlelbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlelbl.Location = new System.Drawing.Point(160, 283);
            this.middlelbl.Name = "middlelbl";
            this.middlelbl.Size = new System.Drawing.Size(162, 30);
            this.middlelbl.TabIndex = 42;
            this.middlelbl.Text = "Middle name:";
            // 
            // firsttxt
            // 
            this.firsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firsttxt.Location = new System.Drawing.Point(165, 235);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.Size = new System.Drawing.Size(319, 30);
            this.firsttxt.TabIndex = 41;
            // 
            // firstlbl
            // 
            this.firstlbl.AutoSize = true;
            this.firstlbl.BackColor = System.Drawing.Color.Transparent;
            this.firstlbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstlbl.Location = new System.Drawing.Point(160, 202);
            this.firstlbl.Name = "firstlbl";
            this.firstlbl.Size = new System.Drawing.Size(138, 30);
            this.firstlbl.TabIndex = 40;
            this.firstlbl.Text = "First name: ";
            // 
            // confirmtxt
            // 
            this.confirmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmtxt.Location = new System.Drawing.Point(558, 399);
            this.confirmtxt.Name = "confirmtxt";
            this.confirmtxt.Size = new System.Drawing.Size(319, 30);
            this.confirmtxt.TabIndex = 39;
            // 
            // confirmlbl
            // 
            this.confirmlbl.AutoSize = true;
            this.confirmlbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmlbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmlbl.Location = new System.Drawing.Point(553, 366);
            this.confirmlbl.Name = "confirmlbl";
            this.confirmlbl.Size = new System.Drawing.Size(216, 30);
            this.confirmlbl.TabIndex = 38;
            this.confirmlbl.Text = "Confirm Password:";
            // 
            // pwdtxt
            // 
            this.pwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.Location = new System.Drawing.Point(558, 316);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(319, 30);
            this.pwdtxt.TabIndex = 37;
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.pwdlbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlbl.Location = new System.Drawing.Point(553, 283);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(123, 30);
            this.pwdlbl.TabIndex = 36;
            this.pwdlbl.Text = "Password:";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(558, 235);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(319, 30);
            this.usernametxt.TabIndex = 35;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Adobe Heiti Std R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(553, 202);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(135, 30);
            this.usernamelbl.TabIndex = 34;
            this.usernamelbl.Text = "Username: ";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PO.Properties.Resources.postBG1;
            this.ClientSize = new System.Drawing.Size(1016, 733);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.SearchMenuStrip);
            this.Controls.Add(this.adduserbtn);
            this.Controls.Add(this.lasttxt);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.middletxt);
            this.Controls.Add(this.middlelbl);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.firstlbl);
            this.Controls.Add(this.confirmtxt);
            this.Controls.Add(this.confirmlbl);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.usernamelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1034, 780);
            this.MinimumSize = new System.Drawing.Size(1034, 780);
            this.Name = "AddUser";
            this.Text = "Midwestern State University - Post Office - Add User";
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
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
        private System.Windows.Forms.TextBox middletxt;
        private System.Windows.Forms.Label middlelbl;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.Label firstlbl;
        private System.Windows.Forms.TextBox confirmtxt;
        private System.Windows.Forms.Label confirmlbl;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label usernamelbl;
    }
}