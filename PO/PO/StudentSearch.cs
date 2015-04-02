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
    public partial class StudentSearch : Form
    {
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rosterDataSet.Rosters' table. You can move, or remove it, as needed.
            //this.studentTableTableAdapter.Fill(this.pODBDataSet.StudentTable);

        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.Show();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Print Pform = new Print();
            Pform.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.Show();
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

        private void radiobuttons_CheckChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }

        private void studentDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //figure out what I'm searching by
            if(radioButton1.Checked)
            {
                //perform the query
                studentTableTableAdapter.FillByName(this.pODBDataSet.StudentTable, FirstNametxtbox.Text, MiddleInittxtbox.Text, LastNametxtbox.Text);
            }

            else if(radioButton2.Checked)
            {
                //perform the query
                studentTableTableAdapter.FillByMNum(this.pODBDataSet.StudentTable, textBox1.Text);
            }
        }

        
    }
}
