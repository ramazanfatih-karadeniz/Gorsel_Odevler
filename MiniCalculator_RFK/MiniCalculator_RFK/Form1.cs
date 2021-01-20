using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculator_RFK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Ramazan Fatih Karadeniz
         * 2017280029
         * Exercise 4.3
         */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox5.Text));
            }
            catch
            {
                Error.Visible = true;
                return;
            }
            Error.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox10.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox7.Text));
            }
            catch
            {
                Error.Visible = true;
                return;
            }
            Error.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox12.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox6.Text));
            }
            catch
            {
                Error.Visible = true;
                return;
            }
            Error.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) / Convert.ToDouble(textBox9.Text));
            }
            catch
            {
                Error.Visible = true;
                return;
            }
            Error.Visible = false;
        }
    }
}
