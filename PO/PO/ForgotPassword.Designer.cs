namespace PO
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.cancelbtn = new System.Windows.Forms.Button();
            this.sendemailbtn = new System.Windows.Forms.Button();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.pODBDataSet = new PO.PODBDataSet();
            this.adminTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableTableAdapter = new PO.PODBDataSetTableAdapters.AdminTableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(227, 192);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(112, 34);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // sendemailbtn
            // 
            this.sendemailbtn.BackColor = System.Drawing.Color.DarkRed;
            this.sendemailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendemailbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendemailbtn.ForeColor = System.Drawing.Color.White;
            this.sendemailbtn.Location = new System.Drawing.Point(100, 192);
            this.sendemailbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendemailbtn.Name = "sendemailbtn";
            this.sendemailbtn.Size = new System.Drawing.Size(112, 34);
            this.sendemailbtn.TabIndex = 12;
            this.sendemailbtn.Text = "Send Email";
            this.sendemailbtn.UseVisualStyleBackColor = false;
            this.sendemailbtn.Click += new System.EventHandler(this.sendemailbtn_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emailtxt.Location = new System.Drawing.Point(147, 119);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(192, 19);
            this.emailtxt.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(94, 121);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "email: ";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(32, 36);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(387, 36);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Please enter your email address. \r\nA message will be sent to you shortly with you" +
    "r password.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AllowUserToAddRows = false;
            this.adminDataGridView.AllowUserToDeleteRows = false;
            this.adminDataGridView.AutoGenerateColumns = false;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.adminDataGridView.DataSource = this.adminTableBindingSource;
            this.adminDataGridView.Location = new System.Drawing.Point(-41, 231);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.ReadOnly = true;
            this.adminDataGridView.Size = new System.Drawing.Size(524, 150);
            this.adminDataGridView.TabIndex = 14;
            this.adminDataGridView.Visible = false;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PO.Properties.Resources.postBG2;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.adminDataGridView);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.sendemailbtn);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 300);
            this.MinimumSize = new System.Drawing.Size(454, 300);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password?";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button sendemailbtn;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView adminDataGridView;
        private PODBDataSet pODBDataSet;
        private System.Windows.Forms.BindingSource adminTableBindingSource;
        private PODBDataSetTableAdapters.AdminTableTableAdapter adminTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}