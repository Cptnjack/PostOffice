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
    public partial class UpdateStudentAddress : Form
    {
        private Student newP;
        private Student oldP;
        private Form last;
        private bool loggedin = true;

        public UpdateStudentAddress()
        {
            InitializeComponent();
        }

        public UpdateStudentAddress(Student s)
        {
            InitializeComponent();
            oldP = newP = s;
            init(s);
        }

        public UpdateStudentAddress(Student s, Form f)
        {
            InitializeComponent();
            //save the information passed in
            oldP = newP = s;
            last = f;
            init(s);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you entered the data right and wish to update?", "Continue?",
                MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                newP.FName = fnameTextBox.Text;
                newP.MidName = mnameTextBox.Text;
                newP.LName = lnameTextBox.Text;
                newP.Email = emailTextBox.Text;
                newP.MNum = mnumTextBox.Text;
                newP.MStAddress = msuaddressTextBox.Text;
                newP.MCity = "Wichita Falls";
                newP.MState = "TX";
                newP.MZip = "76308";
                newP.NStAddress = newaddressTextBox.Text;
                newP.NCity = newcityTextBox.Text;
                newP.NState = newstateTextBox.Text;
                newP.NZip = newzipTextBox.Text;
                newP.NCountry = newcountryTextBox.Text;

                last = new StudentSearch(loggedin, oldP, newP);
                last.Show();
                this.Close();
            }
        }

        private void HomePic_Click(object sender, EventArgs e)
        {
            last = new AdminHomePage(loggedin);
            last.Show();
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            last.Show();
            this.Close();
        }

        private void radiobuttons_CheckedChanged(object sender, EventArgs e)
        {
            if (sundanceRadioButton.Checked == true)
            {
                msuaddressTextBox.Text = "2602 Midwestern Pkwy";
            }

            else if (SunwatcherRadioButton.Checked == true)
            {
                msuaddressTextBox.Text = "3704 Louis J. Rodriguez";
            }
            else if (poboxRadioButton.Checked == true || otherRadioButton.Checked == true)
            {
                msuaddressTextBox.Text = "";
            }

        }

        private void init(Student s)
        {
            //fill the textboxes on screen
            fnameTextBox.Text = s.FName;
            mnameTextBox.Text = s.MidName;
            lnameTextBox.Text = s.LName;
            emailTextBox.Text = s.Email;
            mnumTextBox.Text = s.MNum;
            msuaddressTextBox.Text = s.MStAddress;
            aptmailTextBox.Text = s.Aptmb;
            //if they lived in sundance
            if (s.MStAddress == "2602 Midwestern Pkwy")
            {
                sundanceRadioButton.Checked = true;
            }

            //if they lived in sunwatcher
            else if (s.MStAddress == "3704 Louis J. Rodriguez")
            {
                SunwatcherRadioButton.Checked = true;
            }

            //if they don't live in either
            else
            {

            }
            newaddressTextBox.Text = s.NStAddress;
            newcityTextBox.Text = s.NCity;
            newstateTextBox.Text = s.NState;
            newzipTextBox.Text = s.NZip;
            newcountryTextBox.Text = s.NCountry;
        }

    }
}
