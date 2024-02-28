using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Else_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
              if (textBox1.Text == "Sidar")
             {
                 label1.Text = "Welcome";

             }
             else
             {
                 label1.Text = "Incorrect Entry";
             }

            */

           // ------------------------------------

            /*
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0)
            {
                label1.Text = "True";
            }
            else
            {
                label1.Text = "False";
            }
            */

            //---------------------------------------

            int sayi=Convert.ToInt32(textBox1.Text);

            if(sayi>10 && sayi % 2==0)
            {
                label1.Text = "True";
            }
            else
            {
                label1.Text = "False";
            }

                  
                
        }
    }
}
