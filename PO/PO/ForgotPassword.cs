using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;

namespace PO
{
    public partial class ForgotPassword : Form
    {
        private String password;
        private String email;
        private String to;
        private String from;
        private String sub;
        private String msg;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void sendemailbtn_Click(object sender, EventArgs e)
        {
            //get the email from the textbox on the form
            email = emailtxt.Text;
            //fill the invisible datagridview based on the email
            this.adminTableTableAdapter.FillByEmail(pODBDataSet.AdminTable, email);
            //if there is only one entry in the database, get the information
            //and send it to the email.
            if (adminDataGridView.Rows.Count == 1)
            {
                try
                {
                    to = adminDataGridView.Rows[adminDataGridView.Rows[0].Index].Cells[3].Value.ToString();
                    from = "MSUPOHELP@gmail.com";
                    sub = "PO Application Forgotten Password!";
                    password = adminDataGridView.Rows[adminDataGridView.Rows[0].Index].Cells[4].Value.ToString();
                    msg = "It seems you have forgotten your password, so here it is:" + '\n';
                    msg += password;

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    System.Net.NetworkCredential credentials = new
                                        System.Net.NetworkCredential("MSUPOHELP@gmail.com", "MsuSEItDepends2015");
                    smtpClient.Credentials = credentials;

                    string[] tos;
                    this.to = this.to.Replace(',', ' ');

                    tos = this.to.Split();
                    for (int i = 0; i < tos.Length; i++)
                    {
                        MailMessage ml = new MailMessage(this.from, tos[i].ToString(), this.sub,
                                                            this.msg);
                        ml.IsBodyHtml = true;
                        smtpClient.Send(ml);
                    }
                    MessageBox.Show("Your email is on it's way, it may be just a moment!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (ArgumentException p)
                {
                    MessageBox.Show(p.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (SmtpException p)
                {
                    MessageBox.Show(p.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //close child form
                this.Close();
            }

            else
            {
                MessageBox.Show("There doesn't seem to be anyone with that email in the system! Please re-enter your email or contact a system administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.pODBDataSet.AdminTable);
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            //this.adminTableTableAdapter.Fill(this.pODBDataSet.AdminTable);

        }
    }
}
