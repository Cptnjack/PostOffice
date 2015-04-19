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
    public partial class AdminHomePage : Form
    {
        private bool loggedin;
        private User u;
        public AdminHomePage()
        {
            InitializeComponent();
            loggedin = false;
        }

        public AdminHomePage(bool i)
        {
            InitializeComponent();
            loggedin = i;
        }

        public AdminHomePage(User a)
        {
            InitializeComponent();
            u = a;
            if (u.isAdmin())
                this.Text = "Logged in as: " + u.Username;
            else
                this.Text = "How did you get here?";
        }

        private void adminSearchStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(u);
            search.Show();

            //should change "Admin Login" button to "Log Out"..also in the menustrip..add a "Home" option under Admin?
        }

        private void adminLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(new User());
            search.Show();
        }


        private void adduserbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addform = new AddUser(u);
            addform.Show();
        }

        private void adminChangePswrd_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePassword changepwd = new ChangePassword(u);
            changepwd.Show();
        }


        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Print Pform = new Print(u);
            Pform.Show();
        }

        private void forcePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to force print?", "Force Print", MessageBoxButtons.YesNoCancel);
        }


        private void removeuserbtn_Click(object sender, EventArgs e)
        {
            RemoveUser remove = new RemoveUser(u);
            remove.Show();
            this.Close();

        }

        private void addstudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddStudentAddress(u, this);
            f.Show();
        }
    }
}
