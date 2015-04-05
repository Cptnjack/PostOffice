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
        public AddStudentAddress()
        {
            InitializeComponent();
            loggedin = false;
        }

        public AddStudentAddress(bool i)
        {
            InitializeComponent();
            loggedin = i;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
