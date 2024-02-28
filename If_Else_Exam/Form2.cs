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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exam1, exam2, project, average;

            exam1 = Convert.ToInt32(textBox1.Text);
            exam2 = Convert.ToInt32(textBox2.Text);
            project = Convert.ToInt32(textBox3.Text);

            average=(exam1+exam2 + project)/3;

            if (average > 50)
            {
                listBox1.Items.Add("Average : "+average.ToString()+ "/"+" You Passed");
            }
            else
            {
                listBox1.Items.Add("Average : " + average.ToString() + "/" + "You Didn't Passed");
            }

           
        }
    }
}
