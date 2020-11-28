using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev6_4 : Form
    {
        public odev6_4()
        {
            InitializeComponent();
        }
        private double a, b;
        private double checking(string age)
        {
            double var;
            try
            {
                var = Convert.ToInt32(age);
            }
            catch
            {
                toolTip1.Show("Please enter a positive number", calc);
                return -1;
            }

            if (var <= 0) return -1;
            return var;
        }
        private void calc_Click(object sender, EventArgs e)
        {
            a = checking(textBox1.Text);
            b = checking(textBox2.Text);
            if (a == -1 || b == -1) return;
            else
            {
                if (sum.Checked) textBox3.Text = Convert.ToString(a + b);
                else if (mines.Checked) textBox3.Text = Convert.ToString(a - b);
                else if (prod.Checked) textBox3.Text = Convert.ToString(a * b);
                else  textBox3.Text = Convert.ToString(a / b);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_3 f2 = new odev6_3();
            f2.Closed += (s, args) => this.Close();
            f2.ShowDialog();
        }
    

        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev7_1 f3 = new odev7_1();
            f3.Closed += (s, args) => this.Close();
            f3.ShowDialog();
        }
    
    }
}
