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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 20% discount for those who buy books between 0-20
            // 40% discount for those who buy books between 21-40
            // 50% discount for those who buy books between 41++
            // Book Price = 8 TL

            int bookAmount=Convert.ToInt32(textBox1.Text);
            double sum;

            if(bookAmount>0 && bookAmount <= 20)
            {
                sum = (bookAmount * 8) - (bookAmount * 8 * 0.2);
                label3.Text=sum.ToString();
            }
            if(bookAmount > 20 && bookAmount <= 40)
            {
                sum = (bookAmount * 8) - (bookAmount * 8 * 0.4);
                label3.Text = sum.ToString();
            }
            if (bookAmount > 40)
            {
                sum = (bookAmount * 8) - (bookAmount * 8 * 0.5);
                label3.Text = sum.ToString();
            }


        }
    }
}
