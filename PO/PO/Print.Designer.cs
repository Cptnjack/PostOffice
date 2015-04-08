namespace PO
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SearchMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Image = global::PO.Properties.Resources.home_icon;
            this.pictureBox2.Location = new System.Drawing.Point(554, 372);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.DarkRed;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(452, 288);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(239, 67);
            this.PrintButton.TabIndex = 20;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
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
            this.SearchMenuStrip.TabIndex = 18;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.logOutToolStripMenuItem.Text = "Log In";
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
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // addRemoveToolStripMenuItem
            // 
            this.addRemoveToolStripMenuItem.Enabled = false;
            this.addRemoveToolStripMenuItem.Name = "addRemoveToolStripMenuItem";
            this.addRemoveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addRemoveToolStripMenuItem.Text = "Add";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.removeToolStripMenuItem.Text = "Update";
            // 
            // PreviewBox
            // 
            this.PreviewBox.Location = new System.Drawing.Point(12, 27);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(435, 564);
            this.PreviewBox.TabIndex = 22;
            this.PreviewBox.TabStop = false;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PO.Properties.Resources.postBG1;
            this.ClientSize = new System.Drawing.Size(764, 603);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.SearchMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 641);
            this.MinimumSize = new System.Drawing.Size(780, 641);
            this.Name = "Print";
            this.Text = "Midwestern State University - Post Office - Print";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.MenuStrip SearchMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.PictureBox PreviewBox;
    }
}