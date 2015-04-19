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
    public partial class Print : Form
    {
        private bool loggedin;
        private User u;
        public Print()
        {
            InitializeComponent();
        }

        public Print(bool i)
        {
            InitializeComponent();
            loggedin = i;
        }

        public Print(User a)
        {
            InitializeComponent();
            u = a;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to print?", "Print", MessageBoxButtons.YesNoCancel);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (u.isAdmin())
            {
                this.Close();
                Form f = new AdminHomePage(u);
            }

            else
            {
                this.Close();
                Form f = new StudentSearch(u);
            }
        }
    }
}
