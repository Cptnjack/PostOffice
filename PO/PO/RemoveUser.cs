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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser add = new AddUser();
            add.Show();
        }

        private void changepwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changepwd = new ChangePassword();
            changepwd.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch search = new StudentSearch();
            search.Show();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage adminhome = new AdminHomePage();
            adminhome.Show();
        }
    }
}
