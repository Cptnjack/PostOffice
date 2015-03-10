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
        public AddUser()
        {
            InitializeComponent();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage adminhome = new AdminHomePage();
            adminhome.Show();
        }

        private void changepwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changepwd = new ChangePassword();
            changepwd.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch search = new StudentSearch();
            search.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch search = new StudentSearch();
            search.Show();
            //should change "Admin Login" button to "Log Out"..also in the menustrip..add a "Home" option under Admin?
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print Pform = new Print();
            Pform.Show();
        }

        private void forcePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to force print?", "Force Print", MessageBoxButtons.YesNoCancel);
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveUser removeuser = new RemoveUser();
            removeuser.Show();
        }
    }
}
