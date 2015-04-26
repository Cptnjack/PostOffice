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
        private bool loggedin;
<<<<<<< HEAD
        private User u;
=======
        private LabelQueue lq;
        public Print(LabelQueue queue)
        {
            InitializeComponent();
            lq = queue;
            Bitmap bmp = new Bitmap(2550, 3300);

            RectangleF [,] rectf = new RectangleF[30,5];

            Graphics PrintPreview = Graphics.FromImage(bmp);

            int x, y, c = 0;

            for(int count = 0; count < 30;count++)
            {
                // Get coordinates for where to put values.
                x = ((count % 3) * 600) + 300;
                // Accounts for column gap
                if (count % 3 > 0)
                    x = x + ((count % 3) - 1) * 75;
                y = ((count % 10) * 270) + 300;

                for(int count2 = 0; count2<5; count2++)
                {
                    rectf[count,count2] = new RectangleF(x, y, 600, 54);
                    y = y + 54;
                }
            }

            while (c < lq.labels.Length)
            {
                string firstLine, secondLine, thirdLine;

                firstLine = lq.labels[c].GetLastName() + ", " + lq.labels[c].GetFirstName() + " " + lq.labels[c].GetMiddleName();
                secondLine = lq.labels[c].GetNewStreet();
                thirdLine = lq.labels[c].GetNewCity() + ", " + lq.labels[c].GetNewState() + lq.labels[c].GetNewZIP() + lq.labels[c].GetNewCountry();

                PrintPreview.DrawString(firstLine, new Font("Times New Roman",8), Brushes.Black, rectf[c,0]);
                PrintPreview.DrawString(secondLine, new Font("Times New Roman",8), Brushes.Black, rectf[c,0]);
                PrintPreview.DrawString(thirdLine, new Font("Times New Roman",8), Brushes.Black, rectf[c,0]);

                c++;
            }

            PrintPreview.Flush();

            pictureBox1.Image = bmp;
        }

>>>>>>> origin/master
        public Print()
        {
            InitializeComponent();
        }

        public Print(bool i)
        {
            InitializeComponent();
            loggedin = i;
        }

        public Print(User a)
        {
            InitializeComponent();
            u = a;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            DialogResult forceprintresult = MessageBox.Show("Are you sure you want to print?", "Print", MessageBoxButtons.YesNoCancel);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (u.isAdmin())
            {
                this.Close();
                Form f = new AdminHomePage(u);
            }

            else
            {
                this.Close();
                Form f = new StudentSearch(u);
            }
        }
    }
}
