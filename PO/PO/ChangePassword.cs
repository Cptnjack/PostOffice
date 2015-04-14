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
    public partial class ChangePassword : Form
    {
        private bool loggedin;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(bool i)
        {
            InitializeComponent();
            loggedin = i;
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminHomePage adminhome = new AdminHomePage(loggedin);
            adminhome.Show();
        }

        private void changepwdbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "" || currentpwdtxt.Text == "" || newpwdtxt.Text == "" || confirmpwdtxt.Text == "")
            {
                MessageBox.Show("Please do not leave any fields blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (newpwdtxt.Text != confirmpwdtxt.Text)
            {
                MessageBox.Show("The passwords entered don't match. Please re-enter them.", "Password Match Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.adminTableTableAdapter.FillByUsernamePwd(this.pODBDataSet.AdminTable, usernametxt.Text, currentpwdtxt.Text);

            if (adminTableDataGridView.Rows.Count - 1 != 1)
            {
                MessageBox.Show("The information you entered is not correct. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.adminTableTableAdapter.UpdateQuery( newpwdtxt.Text, usernametxt.Text);
            }

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.pODBDataSet.AdminTable);

        }

        private void ChangePassword_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.pODBDataSet.AdminTable);

        }
    }
}
