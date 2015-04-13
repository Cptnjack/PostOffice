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
    public partial class AddUser : Form
    {
        private bool loggedin;
        public AddUser()
        {
            InitializeComponent();
            loggedin = false;
        }

        public AddUser(bool i)
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

        private void changepwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePassword changepwd = new ChangePassword(loggedin);
            changepwd.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(false);
            search.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(loggedin);
            search.Show();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Print Pform = new Print(loggedin);
            Pform.Show();
        }

        private void forcePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to force print?", "Force Print", MessageBoxButtons.YesNoCancel);
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RemoveUser removeuser = new RemoveUser(loggedin);
            removeuser.Show();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.FillByUsernameAll(this.pODBDataSet.AdminTable);
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            if (pwdtxt.Text == confirmtxt.Text)
            {
                try
                {
                    this.adminTableTableAdapter.InsertQuery(firsttxt.Text, lasttxt.Text, emailtxt.Text, pwdtxt.Text, usernametxt.Text);
                    MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    Form f = new AdminHomePage(loggedin);
                }
                catch (System.Data.OleDb.OleDbException ex)
                {
                    MessageBox.Show("There already exists a user with that username. Please choose another.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametxt.Text = "";
                }
            }

            else
                MessageBox.Show("The passwords entered are not the same" + System.Environment.NewLine + "Please"
                    + " re-enter them.", "Password match error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void adminTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pODBDataSet);

        }
    }
}
