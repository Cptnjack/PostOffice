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
        public AdminLogin()
        {
            InitializeComponent();
        }

        //home button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch search = new StudentSearch();
            search.Show();
        }

        private void LoginHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword childPassword = new ForgotPassword();
            childPassword.Show();
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage AdminHome = new AdminHomePage();
            AdminHome.Show();
        }
    }
}
