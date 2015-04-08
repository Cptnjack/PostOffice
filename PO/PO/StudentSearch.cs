﻿using System;
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
        private Student s;
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
            ResultList.Columns[15].Visible = false;
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
            ResultList.Columns[15].Visible = false;
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

        public StudentSearch(bool i, Student oldP, Student newP)
        {
            InitializeComponent();

            loggedin = i;

            ResultList.Columns[0].Visible = false;
            ResultList.Columns[10].Visible = false;
            ResultList.Columns[11].Visible = false;
            ResultList.Columns[15].Visible = false;
            ResultList.Columns[14].DisplayIndex = 8;
            ResultList.Columns[9].DisplayIndex = 4;

            if (loggedin)
            {
                AdminLogin.Text = "Logout";
                logInToolStripMenuItem.Text = "Logout";
                adminHomeToolStripMenuItem.Visible = true;
                updateButton.Visible = true;
            }

            else if (!loggedin)
            {
                AdminLogin.Text = "Admin Login";
                adminToolStripMenuItem.Text = "Login";
                adminHomeToolStripMenuItem.Visible = false;
                updateButton.Visible = false;
            }

            this.studentTableTableAdapter.UpdateQuery(newP.FName, newP.MidName, newP.LName, newP.NStAddress, newP.NCity,
                newP.NState, newP.NZip, newP.NCountry, newP.Email, newP.MStAddress, newP.MState, newP.MZip, newP.DateAdded,
                newP.MNum, newP.MCity, oldP.FName, oldP.MidName, oldP.LName, oldP.MNum);
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet1.StudentTable' table. You can move, or remove it, as needed.
            //this.studentTableTableAdapter.Fill(this.pODBDataSet1.StudentTable);
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
            //if you don't enter anything, we can't search...
            if (FirstNametxtbox.Text == "" && MiddleInittxtbox.Text == "" && LastNametxtbox.Text == "")
            {
                MessageBox.Show("You have to enter a name to search!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                //if searching by name
                if (radioButton1.Checked)
                {
                    //if searching by first name, last name, AND middle name
                    if (MiddleInittxtbox.Text != "")
                        //perform the query
                        studentTableTableAdapter.FillByName(this.pODBDataSet.StudentTable, FirstNametxtbox.Text, MiddleInittxtbox.Text, LastNametxtbox.Text);

                    //if only searching by first and last name
                    else if (MiddleInittxtbox.Text == "")
                        //perform the query
                        studentTableTableAdapter.FillByFirstLast(this.pODBDataSet.StudentTable, FirstNametxtbox.Text, LastNametxtbox.Text);

                }

                //if searching by MNumber
                else if (radioButton2.Checked)
                {
                    //perform the query
                    studentTableTableAdapter.FillByMNum(this.pODBDataSet.StudentTable, idTextBox.Text);
                }
            }
        }

        private void adminHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Stores the number of selected rows.
            int selectedRowCount = ResultList.Rows.GetRowCount(DataGridViewElementStates.Selected);

            //if there is only one row selected
            //do stuff
            if(selectedRowCount == 1)
            {
                int selectedRowIndex = ResultList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ResultList.Rows[selectedRowIndex];
                String fn, ln, midn, em, madd, mc, mst, mz, nadd, nc, nst, nz, ncountry, dateadded, mnum;
                DateTime date;
                int day, month, year;
                char[] delim = { '/', ' ' };
                String[] info;

                fn = Convert.ToString(selectedRow.Cells[1].Value);
                midn = Convert.ToString(selectedRow.Cells[2].Value);
                ln = Convert.ToString(selectedRow.Cells[3].Value);
                nadd = Convert.ToString(selectedRow.Cells[4].Value);
                nc = Convert.ToString(selectedRow.Cells[5].Value);
                nst = Convert.ToString(selectedRow.Cells[6].Value);
                nz = Convert.ToString(selectedRow.Cells[7].Value);
                em = Convert.ToString(selectedRow.Cells[8].Value);
                madd = Convert.ToString(selectedRow.Cells[9].Value);
                mst = Convert.ToString(selectedRow.Cells[10].Value);
                mz = Convert.ToString(selectedRow.Cells[11].Value);
                dateadded = Convert.ToString(selectedRow.Cells[12].Value);
                mnum = Convert.ToString(selectedRow.Cells[13].Value);
                ncountry = Convert.ToString(selectedRow.Cells[14].Value);
                mc = Convert.ToString(selectedRow.Cells[15].Value);

                info = dateadded.Split(delim);
                month = Convert.ToInt32(info[0]);
                day = Convert.ToInt32(info[1]);
                year = Convert.ToInt32(info[2]);
                date = new DateTime(year, month, day);

                s = new Student(mnum, fn, ln, midn, em, madd, mc, mst, mz, nadd, nc, nst, nz, ncountry, date);
                this.Hide();
                Form next = new UpdateStudentAddress(s, this);
                next.Show();


                //verification that the constructor and tostring work
                //String a = s.ToString();
                //MessageBox.Show(a);


                //this helped me determine which fields were which
                //String a = Convert.ToString(selectedRow.Cells[0].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[1].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[2].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[3].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[4].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[5].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[6].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[7].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[8].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[9].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[10].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[11].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[12].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[13].Value);
                //a += System.Environment.NewLine;
                //a += Convert.ToString(selectedRow.Cells[14].Value);
                //a += System.Environment.NewLine;
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
