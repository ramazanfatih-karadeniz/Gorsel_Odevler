using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3_2_RFatihK
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
        * Exercises 4.4 & 4.6 & 4.7
        */
        private int chs = 0;
        private void _pages(int sel)
        {
            switch (sel)
            {
                case 0:
                    #region vis
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button1.Location = new System.Drawing.Point(210, 226);
                    button1.Size = new System.Drawing.Size(78, 23);
                    label2.Location = new System.Drawing.Point(86, 199);
                    textBox3.Location = new System.Drawing.Point(198, 200);
                    label1.Location = new System.Drawing.Point(162, 78);
                    #endregion
                    back.Enabled = false;
                    next.Enabled = true;
                    button1.Text = "Calculate";
                    label1.Text = "Avarage Of 3 Numbers";
                    textBox3.ReadOnly = false;
                    break;
                case 1:
                    #region vis
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button1.Location = new System.Drawing.Point(125,200);
                    button2.Location = new System.Drawing.Point(175, 200);
                    button3.Location = new System.Drawing.Point(225, 200);
                    button4.Location = new System.Drawing.Point(275, 200);
                    label2.Location = new Point(label2.Location.X, 229);
                    label1.Location = new System.Drawing.Point(182, 78);
                    textBox3.Location = new Point(textBox3.Location.X, 230);
                    button1.Size = new System.Drawing.Size(30, 20);

                    #endregion
                    back.Enabled = true;
                    next.Enabled = true;
                    label4.Text = "First Number";
                    label3.Text = "Second Number";
                    label1.Text = "Basic Calculator";
                    button1.Text = "+ ";
                    label2.Text = "Result";
                    textBox3.ReadOnly = true;
                    break;
                case 2:
                    #region vis
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button1.Location = new System.Drawing.Point(210, 200);
                    button1.Size = new System.Drawing.Size(78, 23);
                    label2.Location = new Point(label2.Location.X, 229);
                    
                    textBox3.Location = new Point(textBox3.Location.X, 230);
                    #endregion
                    button1.Text = "Calculate";
                    next.Enabled = false;
                    label4.Text = "Radius";
                    label3.Text = "Height";
                    label1.Text = "Volume Calculator";
                    textBox3.ReadOnly = true;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (chs)
            {
                case 0:
                    try
                    {

                    
                    MessageBox.Show(Convert.ToString(
                        (Convert.ToDouble(textBox1.Text) +
                        Convert.ToDouble(textBox2.Text) +
                        Convert.ToDouble(textBox3.Text)) / 3),"Avarage");
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter Numbers!", "Error");
                    }
 
                    break;
                case 1:
                    try
                    {

                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) +
                        Convert.ToDouble(textBox2.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter Numbers!", "Error");
                    }

                    break;
                case 2:
                    try
                    {

                        textBox3.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 2) *
                        Convert.ToDouble(textBox2.Text) * 
                        Math.PI);
                    }
                    catch
                    {
                        MessageBox.Show("Please Enter Numbers!", "Error");
                    }

                    break;
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) *
                Convert.ToDouble(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Please Enter Numbers!", "Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) /
                Convert.ToDouble(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Please Enter Numbers!", "Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) -
                Convert.ToDouble(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Please Enter Numbers!", "Error");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            chs--;
            _pages(chs);
        }

        private void next_Click(object sender, EventArgs e)
        {
            chs++;
            _pages(chs);
        }
    }
}
