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
    public partial class AddStudentAddress : Form
    {
        private bool loggedin;
        private Form last;
        public AddStudentAddress()
        {
            InitializeComponent();
            loggedin = false;
        }

        public AddStudentAddress(bool i, Form f)
        {
            InitializeComponent();
            loggedin = i;
            last = f;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (sundanceRadioButton.Checked == true)
            {
                msuaddressTextBox.Text = "2602 Midwestern Pkwy";
                aptmailTextBox.Text = "";
            }

            else if (SunwatcherRadioButton.Checked == true)
            {
                msuaddressTextBox.Text = "3704 Louis J. Rodriguez";
                aptmailTextBox.Text = "";
            }

            else if (poboxRadioButton.Checked == true || otherRadioButton.Checked == true)
            {
                msuaddressTextBox.Text = "";
                aptmailTextBox.Text = "";
            }
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            //if you left some text boxes blank, throw up an "Error"
            //really it's just a messagebox that says there was an error
            if (firstTextBox.Text == "" || lastTextBox.Text == "" || msuaddressTextBox.Text == "" || aptmailTextBox.Text == ""
                || address1TextBox.Text == "" || naCityTextBox.Text == "" || nacountryTextBox.Text == "")
            {
                MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //otherwise put it in the database
            else
            {
                this.studentTableTableAdapter.Insert(firstTextBox.Text, middleTextBox.Text, lastTextBox.Text, address1TextBox.Text+address2TextBox,
                    naCityTextBox.Text, nastateTextBox.Text, nazipTextBox.Text,  emailTextBox.Text,
                    msuaddressTextBox.Text, "TX", "76308", DateTime.Now, idTextBox.Text, nacountryTextBox.Text, "Wichita Falls", aptmailTextBox.Text);
                this.Close();
                last.Show();
            }
        }

        private void AddStudentAddress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.StudentTable' table. You can move, or remove it, as needed.
            //this.studentTableTableAdapter.Fill(this.pODBDataSet.StudentTable);
        }

        private void AddStudentAddress_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.pODBDataSet.StudentTable);

        }

    }
}
