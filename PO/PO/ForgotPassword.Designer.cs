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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.cancelbtn = new System.Windows.Forms.Button();
            this.sendemailbtn = new System.Windows.Forms.Button();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsrname = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(303, 236);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(150, 42);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // sendemailbtn
            // 
            this.sendemailbtn.BackColor = System.Drawing.Color.DarkRed;
            this.sendemailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendemailbtn.Font = new System.Drawing.Font("Adobe Heiti Std R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendemailbtn.ForeColor = System.Drawing.Color.White;
            this.sendemailbtn.Location = new System.Drawing.Point(134, 236);
            this.sendemailbtn.Name = "sendemailbtn";
            this.sendemailbtn.Size = new System.Drawing.Size(150, 42);
            this.sendemailbtn.TabIndex = 12;
            this.sendemailbtn.Text = "Send Email";
            this.sendemailbtn.UseVisualStyleBackColor = false;
            this.sendemailbtn.Click += new System.EventHandler(this.sendemailbtn_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Adobe Heiti Std R", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emailtxt.Location = new System.Drawing.Point(214, 175);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(255, 33);
            this.emailtxt.TabIndex = 11;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Adobe Heiti Std R", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.usernametxt.Location = new System.Drawing.Point(214, 129);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(255, 33);
            this.usernametxt.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(130, 187);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "email: ";
            // 
            // lblUsrname
            // 
            this.lblUsrname.AutoSize = true;
            this.lblUsrname.BackColor = System.Drawing.Color.Transparent;
            this.lblUsrname.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrname.Location = new System.Drawing.Point(97, 141);
            this.lblUsrname.Name = "lblUsrname";
            this.lblUsrname.Size = new System.Drawing.Size(93, 21);
            this.lblUsrname.TabIndex = 8;
            this.lblUsrname.Text = "username: ";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(42, 44);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(499, 48);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Please enter your username and your email address. \r\nA message will be sent to yo" +
    "u shortly with your password.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PO.Properties.Resources.postBG2;
            this.ClientSize = new System.Drawing.Size(582, 313);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.sendemailbtn);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsrname);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 360);
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button sendemailbtn;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsrname;
        private System.Windows.Forms.Label lblMessage;
    }
}