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
        private User u;
        private Student s;

        public StudentSearch()
        {
            InitializeComponent();
            loggedin = false;
            init();
        }

        public StudentSearch(bool i)
        {
            InitializeComponent();

            loggedin = i;

            init();
        }

        public StudentSearch(bool i, Student newP)
        {
            InitializeComponent();

            loggedin = i;

            init();

            this.studentTableTableAdapter.UpdateQuery(newP.FName, newP.MidName, newP.LName, newP.NStAddress, newP.NCity,
                newP.NState, newP.NZip, newP.Email, newP.MStAddress, newP.MState, newP.MZip, newP.DateAdded,
                newP.MNum, newP.NCountry, newP.MCity, newP.Aptmb, newP.ID);
        }

        public StudentSearch(User a)
        {
            InitializeComponent();
            u = a;
            init();
        }

        public StudentSearch(User a, Student newP)
        {
            InitializeComponent();

            u = a;

            init();

            this.studentTableTableAdapter.UpdateQuery(newP.FName, newP.MidName, newP.LName, newP.NStAddress, newP.NCity,
                newP.NState, newP.NZip, newP.Email, newP.MStAddress, newP.MState, newP.MZip, newP.DateAdded,
                newP.MNum, newP.NCountry, newP.MCity, newP.Aptmb, newP.ID);
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rosterDataSet.Rosters' table. You can move, or remove it, as needed.
            //this.studentTableTableAdapter.Fill(this.pODBDataSet.StudentTable);

        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            if (u.isAdmin())
            {
                MessageBox.Show("You have successfully been logged out. Click OK to return.", "Logged out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loggedin = false;
                u = new User();
                AdminLogin.Text = "Admin Login";
                logInToolStripMenuItem.Text = "Login";
                updateButton.Visible = false;
                addressToolStripMenuItem.Visible = false;
                homePictureBox.Visible = false;
            }

            else
            {
                this.Hide();
                AdminLogin login = new AdminLogin(this);
                login.Show();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Print Pform = new Print(u);
            int init = Convert.ToInt32(QueueView.RowCount);
            Label[] label = new Label[init];

            for (int c = 0; c < init; c++)
                label[c] = new Label();

            int count = Convert.ToInt32(QueueView.RowCount);
            
            for (int c = 0; c < count; c++)
            {
                string fn, mn, ln, ns, nc, nstate, ncountry, nz;
                
                // Gets information and converts to strings
                fn = Convert.ToString(QueueView.Rows[c].Cells[2].Value);
                mn = Convert.ToString(QueueView.Rows[c].Cells[3].Value);
                ln = Convert.ToString(QueueView.Rows[c].Cells[1].Value);
                ns = Convert.ToString(QueueView.Rows[c].Cells[4].Value);
                nc = Convert.ToString(QueueView.Rows[c].Cells[5].Value);
                nstate = Convert.ToString(QueueView.Rows[c].Cells[6].Value);
                nz = Convert.ToString(QueueView.Rows[c].Cells[7].Value);
                ncountry = Convert.ToString(QueueView.Rows[c].Cells[8].Value);
                
                // Stores label information
                label[c].setLastName(ln);
                label[c].setFirstName(fn);
                label[c].setMiddleName(mn);
                label[c].setNewStreet(ns);
                label[c].setNewCity(nc);
                label[c].setNewState(nstate);
                label[c].setNewZIP(nz);
                label[c].setNewCountry(ncountry);
            }
            
            LabelQueue lq = new LabelQueue(label);
           // Print Pform = new Print(lq);
            Pform.Show();
        }

        private void forcePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to force print?", "Force Print", MessageBoxButtons.YesNoCancel);
        }

        private void radiobuttons_CheckChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //if searching by name
            if (radioButton1.Checked)
            {
                //if you don't enter anything, we can't search...
                if (FirstNametxtbox.Text == "" && MiddleInittxtbox.Text == "" && LastNametxtbox.Text == "")
                {
                    MessageBox.Show("You have to enter a name to search!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if(FirstNametxtbox.Text == "" && LastNametxtbox.Text != "")
                {
                    MessageBox.Show("You left the First Name field blank. Please provide a First Name.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (FirstNametxtbox.Text != "" && LastNametxtbox.Text == "")
                {
                    MessageBox.Show("You left the Last Name field blank. Please provide a Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
            }

            //if searching by MNumber
            else if (radioButton2.Checked)
            {
                if (idTextBox.Text != "")
                    //perform the query
                    studentTableTableAdapter.FillByMNum(this.pODBDataSet.StudentTable, idTextBox.Text);
            }
        }

        private void adminHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (u.isAdmin())
            {
                this.Close();
                AdminHomePage a = new AdminHomePage(u);
                a.Show();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Stores the number of selected rows.
            int selectedRowCount = ResultList.Rows.GetRowCount(DataGridViewElementStates.Selected);

            //if there is only one row selected
            //do stuff
            if (selectedRowCount == 1)
            {
                int selectedRowIndex = ResultList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ResultList.Rows[selectedRowIndex];
                int id;
                String fn, ln, midn, em, madd, mc, mst, mz, nadd, nc, nst, nz, ncountry, dateadded, mnum, amb;
                DateTime date;
                int day, month, year;
                char[] delim = { '/', ' ' };
                String[] info;
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
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
                amb = Convert.ToString(selectedRow.Cells[16].Value);

                info = dateadded.Split(delim);
                month = Convert.ToInt32(info[0]);
                day = Convert.ToInt32(info[1]);
                year = Convert.ToInt32(info[2]);
                date = new DateTime(year, month, day);

                s = new Student(mnum, fn, ln, midn, em, madd, mc, mst, mz, nadd, nc, nst, nz, ncountry, date, amb, id);
                this.Hide();
                Form next = new UpdateStudentAddress(s, this, u);
                next.Show();
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

        private void init()
        {
            ResultList.Columns[0].Visible = false;
            ResultList.Columns[10].Visible = false;
            ResultList.Columns[11].Visible = false;
            ResultList.Columns[15].Visible = false;
            ResultList.Columns[14].DisplayIndex = 8;
            ResultList.Columns[9].DisplayIndex = 4;
            ResultList.Columns[16].DisplayIndex = 5;

            if (u.isAdmin())
            {
                AdminLogin.Text = "Logout";
                logInToolStripMenuItem.Text = "Logout";
                adminHomeToolStripMenuItem.Visible = true;
                updateButton.Visible = true;
                addressToolStripMenuItem.Visible = true;
                homePictureBox.Visible = true;
            }

            else if (!u.isAdmin())
            {
                AdminLogin.Text = "Admin Login";
                adminToolStripMenuItem.Text = "Login";
                adminHomeToolStripMenuItem.Visible = false;
                updateButton.Visible = false;
                addressToolStripMenuItem.Visible = false;
                homePictureBox.Visible = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddStudentAddress(u, this);
            f.Show();
        }

        //decided that a delete button was not necessary, but I left the code in here just in case
        //that in the future it is wished to be implemented, it is already written
        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    int selectedRowCount = ResultList.Rows.GetRowCount(DataGridViewElementStates.Selected);

        //    //if there is only one row selected
        //    //do stuff
        //    if (selectedRowCount == 1)
        //    {
        //        int selectedRowIndex = ResultList.SelectedCells[0].RowIndex;
        //        DataGridViewRow selectedRow = ResultList.Rows[selectedRowIndex];
        //        String fn, ln, midn, nadd, nc, nst, ncountry, amb;

        //        fn = Convert.ToString(selectedRow.Cells[1].Value);
        //        midn = Convert.ToString(selectedRow.Cells[2].Value);
        //        ln = Convert.ToString(selectedRow.Cells[3].Value);
        //        nadd = Convert.ToString(selectedRow.Cells[4].Value);
        //        nc = Convert.ToString(selectedRow.Cells[5].Value);
        //        nst = Convert.ToString(selectedRow.Cells[6].Value);
        //        ncountry = Convert.ToString(selectedRow.Cells[14].Value);
        //        amb = Convert.ToString(selectedRow.Cells[16].Value);
        //        if (midn == "")
        //            this.studentTableTableAdapter.DeleteQueryNoM(fn, ln, nadd, nc, ncountry, amb);
        //        else
        //            this.studentTableTableAdapter.DeleteQueryMN(fn, midn, ln, nadd, nc, ncountry, amb);
        //        this.studentTableTableAdapter.Fill(this.pODBDataSet.StudentTable);

        //    }

        //    else
        //    {
        //        MessageBox.Show("Please select a student to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void AddQ_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = ResultList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = ResultList.Rows[selectedRowIndex];
            int rowIndex;

            int counter = Convert.ToInt32(numberofcopies.Text);
            int total = Convert.ToInt32(QueueView.RowCount) + counter;

            // The empty row is the 31st row, which means 31 rows amounts to 30 labels.
            if (total > 31)
            {
                MessageBox.Show("This action will put you over 30 labels.  Please delete some or reduce the number of labels to be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                total = total - counter;
            }
            else
            {
                if (total == 31)
                    MessageBox.Show("You now have 30 labels in the queue.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (counter > 0)
                {                   
                    rowIndex = this.QueueView.Rows.Add();
                    var row = this.QueueView.Rows[rowIndex];

                    row.Cells[0].Value = selectedRow.Cells[3].Value; // Last Name
                    row.Cells[1].Value = selectedRow.Cells[1].Value; // First Name
                    row.Cells[2].Value = selectedRow.Cells[2].Value; // Middle Name
                    row.Cells[3].Value = selectedRow.Cells[4].Value; // New Street
                    row.Cells[4].Value = selectedRow.Cells[5].Value; // New City
                    row.Cells[5].Value = selectedRow.Cells[6].Value; // New State
                    row.Cells[6].Value = selectedRow.Cells[7].Value; // New Country
                    row.Cells[7].Value = selectedRow.Cells[14].Value;// New ZIP
                    row.Cells[8].Value = selectedRow.Cells[12].Value;// Date Added

                    counter--;
                }
            }
        }

        private void RemoveQ_Click(object sender, EventArgs e)
        {
            if (this.QueueView.SelectedRows.Count > 0)
            {
                QueueView.Rows.RemoveAt(this.QueueView.SelectedRows[0].Index);
            }
        }
    }
}
