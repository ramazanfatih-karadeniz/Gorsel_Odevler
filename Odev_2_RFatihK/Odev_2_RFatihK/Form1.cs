using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2_RFatihK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          MessageBox.Show (data1.Text + " " + data2.Text,"Welcome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = Convert.ToString(Convert.ToDouble(data1.Text) + Convert.ToDouble(data2.Text));
            }
            catch 
            {
                MessageBox.Show("Please Enter a Number","Error!");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = data1.Text;
            MessageBox.Show(data1.Text, "Exercise 2.3");
            this.Text = data1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you?", "Ro-BOT");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int first;
            int second;
            int ans;
            try
            {
                first = int.Parse(data1.Text);
                second = int.Parse(data2.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a Number", "Error!");
                return;
            }
            
            ans = first + second;
            MessageBox.Show(ans.ToString(),"Answer");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Data 1 :";
            this.Text = "Ramazan Fatih Karadeniz";
            data1.Text = "";
            data2.Text = "";
            result.Text = "";
        }
    }
}
