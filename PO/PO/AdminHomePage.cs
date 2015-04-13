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

        private void adminSearchStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(loggedin);
            search.Show();
           
            //should change "Admin Login" button to "Log Out"..also in the menustrip..add a "Home" option under Admin?
        }

        private void adminLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(false);
            search.Show();
        }


        private void adduserbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addform = new AddUser(loggedin);
            addform.Show();
        }

        private void adminChangePswrd_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePassword changepwd = new ChangePassword(loggedin);
            changepwd.Show();
        }


        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Print Pform = new Print();
            Pform.Show();
        }

        private void forcePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to force print?", "Force Print", MessageBoxButtons.YesNoCancel);
        }


        private void removeuserbtn_Click(object sender, EventArgs e)
        {
            RemoveUser remove = new RemoveUser(loggedin);
            remove.Show();
            this.Close();
            
        }

        private void addstudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddStudentAddress(loggedin, this);
            f.Show();
        } 
    }
}
