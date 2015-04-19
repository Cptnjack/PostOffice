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
        private bool loggedin;
        private User u;

        public RemoveUser()
        {
            InitializeComponent();
        }

        public RemoveUser(bool i)
        {
            InitializeComponent();
            loggedin = i;
        }

        public RemoveUser(User a)
        {
            InitializeComponent();
            u = a;
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser add = new AddUser(u);
            add.Show();
        }

        private void changepwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePassword changepwd = new ChangePassword(u);
            changepwd.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentSearch search = new StudentSearch(u);
            search.Show();
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminHomePage adminhome = new AdminHomePage(u);
            adminhome.Show();
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            this.adminTableTableAdapter.FillByUsernameAll(this.pODBDataSet.AdminTable);
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            List<String> L = new List<String>();
            for (int j = 0; j < adminTableDataGridView.Rows.Count-1; j++)
            {
                L.Add(adminTableDataGridView.Rows[j].Cells[4].Value.ToString());
            }

            foreach (String user in L)
            {
                if(u.Username != user)
                    comboBox1.Items.Add(user);
            }
        }

        private void removeuserbtn_Click(object sender, EventArgs e)
        {
            String s = comboBox1.Text;
            this.adminTableTableAdapter.DeleteQueryByUsername(s);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form n = new StudentSearch(new User());
            n.Show();
            this.Close();
        }
    }
}
