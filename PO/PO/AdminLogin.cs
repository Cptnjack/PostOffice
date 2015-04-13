using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO
{
    public partial class AdminLogin : Form
    {
        private String username;
        private String pwd;
        private Form f;
        public AdminLogin()
        {
            InitializeComponent();
        }
        public AdminLogin(Form temp)
        {
            InitializeComponent();
            f = temp;
        }

        //home button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new StudentSearch(false);
            f.Show();
        }

        private void LoginHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f = new ForgotPassword();
            f.Show();
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            //first off, handle the possibility that the username/password
            //fields could be blank. totally possible
            if(txtUsername.Text == "")
            {
                MessageBox.Show("You can't leave the Username field blank! Put something in there!", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if(txtPassword.Text =="")
            {
                MessageBox.Show("We don't allow empty passwords! Please enter your password.", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            else
            {   
                username = txtUsername.Text;
                pwd = txtPassword.Text;
                               
                //2 possible things
                //Login correct
                //login incorrect
                //handle them
                
                adminTableTableAdapter1.FillByUsernamePwd(podbDataSet1.AdminTable, username, pwd);
                if (dataGridView1.Rows.Count > 1)
                {
                    //success
                    //go to the adminHomePage form
                    //MessageBox.Show("Login Successful! Click OK to continue", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f = new AdminHomePage(true);
                    f.Show();
                    this.Close();
                }

                else
                {
                    //not success
                    MessageBox.Show("Login Failed! Click OK to continue", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            //this.adminTableTableAdapter1.Fill(this.pODBDataSet.AdminTable);

        }

    }
}
