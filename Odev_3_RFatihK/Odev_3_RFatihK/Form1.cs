using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_3_RFatihK
{
    public partial class Form1 : Form
    {
        private int chs = 0;
        public Form1()
        {

            InitializeComponent();
        }
        /*
         * Ramazan Fatih Karadeniz
         * 2017280029
         * Exercise 4.1 & 4.2
         */

       

        #region default
        private void set_default()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            pictureBox1.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            button3.Visible = false;
        }
        #endregion
        private void page_Show(int num)
        {
            switch (num)
            {
                case 0:
                    #region visiblty
                    set_default();
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    pictureBox1.Visible = true;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    label1.Location = new Point(201, 102);
                    textBox1.Location = new Point(306, 100);
                    textBox2.Location = new Point(306, 125);
                    textBox3.Location = new Point(306, 150);
                    #endregion
                    label1.Text = "Name : ";
                    label2.Text = "Sirname :";
                    label3.Text = "Student Id :";
                    label4.Text = "School :";
                    label5.Text = "Department :";
                    this.Text = "Student ID Cart";
                    button1.Enabled = false;
                    button2.Enabled = true;
                    break;
                case 1:
                    #region visiblty
                    set_default();
                    label1.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    button3.Visible = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    label1.Location = new Point(150, 75);
                    textBox1.Location = new Point(175, 125);
                    textBox2.Location = new Point(175, 150);
                    textBox3.Location = new Point(175, 225);
                    button3.Location = new Point(190, 185);
                    #endregion
                    label1.Text = "Plase Enter Two Numbers";
                    this.Text = "Program Summing Two Numbers";


                    button1.Enabled = true;
                    button2.Enabled = false;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
            {
                chs--;
                page_Show(chs);
            }
        private void button2_Click(object sender, EventArgs e)
            {
                chs++;
                page_Show(chs);
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            checkBox1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Plase Enter Numbers!", "Error");
            }
        }
        }
}

