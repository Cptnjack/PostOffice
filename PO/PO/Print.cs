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
        public Print()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to print?", "Print", MessageBoxButtons.YesNoCancel);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSearch search = new StudentSearch();
            search.Show();
            //if(admin logged in){
            //this.Hide();
            //AdminHomePage adminhome = new AdminHomePage();
            //adminhome.Show();
        }

        private void PreviewBox_OnPaint(object sender, EventArgs e)
        {

        }
    }
}