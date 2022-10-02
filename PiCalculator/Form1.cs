using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d;
            double termVal = 4, num = 4, den = 3;
            d = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= d; i++)
            {
                if (i % 2 == 0)
                {
                    termVal -= num / den;
                }
                else
                {
                    termVal += num / den;
                }
                den += 2;
            }
            label2.Text = "Approximate value of pi after " + d + " terms";
            label3.Text = "= " + termVal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
