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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             int  month=Convert.ToInt32(textBox1.Text);

            switch (month)
            {
                case 1: label2.Text = "January"; break;
                case 2: label2.Text = "February"; break;
                case 3: label2.Text = "March"; break;
                case 4: label2.Text = "April"; break;
                case 5: label2.Text = "May"; break;
                case 6: label2.Text = "June"; break;
                case 7: label2.Text = "July"; break;
                case 8: label2.Text = "August"; break;
                case 9: label2.Text = "September"; break;
                case 10: label2.Text = "October"; break;
                case 11: label2.Text = "November"; break;
                case 12: label2.Text = "December"; break;

                default: label2.Text = "Incorret"; break;
            */

            string season=textBox1.Text;
            switch (season)
            {
                case "spring": label2.Text = "March,April,May";break;
                case "summer": label2.Text = "June,July,August";break;
                case "autmn": label2.Text = "September,October,November";break;
                case "winter": label2.Text = "December,January,February";break;
                default:label2.Text = "Incorrect";
                    break;
            }

        
        }
    }
}
