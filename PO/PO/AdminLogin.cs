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
    public partial class AdminLogin : Form
    {
        private String username;
        private String pwd;
        private Form f;

        public AdminLogin()
        {
            InitializeComponent();
        }

        public AdminLogin(Form temp)
        {
            InitializeComponent();
            f = temp;
        }

        //home button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            f = new StudentSearch(new User());
            f.Show();
        }


        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            //first off, handle the possibility that the username/password
            //fields could be blank. totally possible
            if (txtUsername.Text == "")
            {
                MessageBox.Show("You can't leave the Username field blank! Put something in there!", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("We don't allow empty passwords! Please enter your password.", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            else
            {
                username = txtUsername.Text;
                pwd = txtPassword.Text;

                //2 possible things
                //Login correct
                //login incorrect
                //handle them

                adminTableTableAdapter.FillByUsernamePwd(this.pODBDataSet.AdminTable, username, pwd);
                dataGridView1.Invalidate();
                dataGridView1.Refresh();
                
                if (dataGridView1.Rows.Count-1 == 1)
                {
                    //success
                    //go to the adminHomePage form
                    //MessageBox.Show("Login Successful! Click OK to continue", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows[0].Selected = true;
                    int selected = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow d = dataGridView1.Rows[selected];

                    String fn = Convert.ToString(d.Cells[0].Value);
                    String ln = Convert.ToString(d.Cells[1].Value);
                    String un = Convert.ToString(d.Cells[4].Value);
                    f = new AdminHomePage(new Admin(fn, ln, un));
                    f.Show();
                    this.Close();
                }

                else
                {
                    //not success
                    MessageBox.Show("Login Failed! Click OK to continue", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            //this.adminTableTableAdapter1.Fill(this.pODBDataSet.AdminTable);

        }

        private void LoginHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f = new ForgotPassword();
            f.Show();
        }

        private void AdminLogin_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pODBDataSet.AdminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.pODBDataSet.AdminTable);

        }

    }
}
