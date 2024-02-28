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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1=Convert.ToInt32(textBox1.Text);
            int number2=Convert.ToInt32(textBox2.Text);
            string symbol = textBox3.Text;
            // int result = Convert.ToInt32(textBox4.Text);
            int result = 0;

            switch (symbol)
            {
                case "+": result=number1 + number2; break;  
                case "-": result=number1 - number2; break;  
                case "/": result=number1 / number2; break;  
                case "*": result=number1 * number2; break;  
                default:
                    break;
            }
            textBox4.Text = result.ToString();
        }
    }
}
