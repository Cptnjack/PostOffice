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
        private bool loggedin;
        
        public StudentSearch()
        {
            InitializeComponent();
            loggedin = false;
            AdminLogin.Text = "Admin Login";
            adminToolStripMenuItem.Text = "Login";
            adminHomeToolStripMenuItem.Visible = false;
            updateButton.Visible = false;
            ResultList.Columns[0].Visible = false;
            ResultList.Columns[10].Visible = false;
            ResultList.Columns[11].Visible = false;
            ResultList.Columns[14].DisplayIndex = 8;
            ResultList.Columns[9].DisplayIndex = 4;
        }

        public StudentSearch(bool i)
        {
            InitializeComponent();
            loggedin = i;
            ResultList.Columns[0].Visible = false;
            ResultList.Columns[10].Visible = false;
            ResultList.Columns[11].Visible = false;
            ResultList.Columns[14].DisplayIndex = 8;
            ResultList.Columns[9].DisplayIndex = 4;
            if(loggedin)
            {
                AdminLogin.Text = "Logout";
                logInToolStripMenuItem.Text = "Logout";
                adminHomeToolStripMenuItem.Visible = true;
                updateButton.Visible = true;
            }

            else if(!loggedin)
            {
                AdminLogin.Text = "Admin Login";
                adminToolStripMenuItem.Text = "Login";
                adminHomeToolStripMenuItem.Visible = false;
                updateButton.Visible = false;
            }
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet1.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.pODBDataSet1.StudentTable);
            // TODO: This line of code loads data into the 'rosterDataSet.Rosters' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.pODBDataSet.StudentTable);

        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            if (loggedin)
            {   
                MessageBox.Show("You have successfully been logged out. Click OK to return.", "Logged out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loggedin = false;
                AdminLogin.Text = "Admin Login";
                logInToolStripMenuItem.Text = "Login";
            }

            else
            {
                this.Hide();
                AdminLogin login = new AdminLogin(this);
                login.Show();
            }
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
                studentTableTableAdapter.FillByMNum(this.pODBDataSet.StudentTable, idTextBox.Text);
            }
        }

        private void adminHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = ResultList.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectedRowCount == 1 || selectedRowCount > 1)
            {
                int selectedRowIndex = ResultList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ResultList.Rows[selectedRowIndex];
                String mnum, fn, ln, mn, em, madd, mc, mst, mz, nadd, nc, nst, nz, ncountry;
                mnum = Convert.ToString(selectedRow.Cells[13].Value);
                fn = Convert.ToString(selectedRow.Cells[1]);
                mn = Convert.ToString(selectedRow.Cells[2]);
                ln = Convert.ToString(selectedRow.Cells[3]);
                em = Convert.ToString(selectedRow.Cells[8]);
                madd = Convert.ToString(selectedRow.Cells[9]);
                //mc = Convert.ToString(selectedRow.Cells[])
                //Student s = new Student(mnum, fn, ln, mn, em, madd, mc, mst, mz, nadd, nc, nst, nz, ncountry, DateTime.Now);
                //String a = Convert.ToString(selectedRow.Cells[1].Value);
                //a += " ";
                //a += Convert.ToString(selectedRow.Cells[2].Value);
                //a += " ";
                //a += Convert.ToString(selectedRow.Cells[3].Value);
                //MessageBox.Show(a);
            }

            else if (selectedRowCount > 1)
            {
                MessageBox.Show("Please select only one student to be updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (selectedRowCount < 1)
            {
                MessageBox.Show("You must select a student to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
    }
}
