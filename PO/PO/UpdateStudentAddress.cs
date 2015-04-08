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
            //fill the textboxes on screen
            fnameTextBox.Text = s.FName;
            mnameTextBox.Text = s.MidName;
            lnameTextBox.Text = s.LName;
            emailTextBox.Text = s.Email;
            mnumTextBox.Text = s.MNum;
            msuaddressTextBox.Text = s.MStAddress;
            msucityTextBox.Text = s.MCity;
            msustateTextBox.Text = s.MState;
            msuzipTextBox.Text = s.MZip;
            newaddressTextBox.Text = s.NStAddress;
            newcityTextBox.Text = s.NCity;
            newstateTextBox.Text = s.NState;
            newzipTextBox.Text = s.NZip;
            newcountryTextBox.Text = s.NCountry;
        }

        public UpdateStudentAddress(Student s, Form f)
        {
            InitializeComponent();
            //save the information passed in
            oldP = newP = s;
            last = f;

            //fill the textboxes on screen
            fnameTextBox.Text = s.FName;
            mnameTextBox.Text = s.MidName;
            lnameTextBox.Text = s.LName;
            emailTextBox.Text = s.Email;
            mnumTextBox.Text = s.MNum;
            msuaddressTextBox.Text = s.MStAddress;
            msucityTextBox.Text = s.MCity;
            msustateTextBox.Text = s.MState;
            msuzipTextBox.Text = s.MZip;
            newaddressTextBox.Text = s.NStAddress;
            newcityTextBox.Text = s.NCity;
            newstateTextBox.Text = s.NState;
            newzipTextBox.Text = s.NZip;
            newcountryTextBox.Text = s.NCountry;
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
                newP.MCity = msucityTextBox.Text;
                newP.MState = msustateTextBox.Text;
                newP.MZip = msuzipTextBox.Text;
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
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            last.Show();
            this.Close();
        }
    }
}
