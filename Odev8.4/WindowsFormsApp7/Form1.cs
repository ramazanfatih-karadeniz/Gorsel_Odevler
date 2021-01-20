using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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
         * */
        private int i, j;
        private bool flag=true;
        private void checker()
        {
            try
            {
                i = Convert.ToInt32(textBox1.Text);
                j = Convert.ToInt32(textBox2.Text);
                if (i > j)
                {
                    MessageBox.Show("First number can not bigger than second number", "Attention!");
                    i = 'a';
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number", "Error!");
                flag = false;
            }
           
        }
        private void sumall()
        {
            int sum=0 ;
            flag = true;
            checker();
            if (!flag) return;
          
            for (;i<j;i++) sum+=i;
            textBox3.Text = Convert.ToString(sum);
        }
        private void sumother()
        {
            int sum = 0;
            flag = true;
            checker();
            if (!flag) return;
            for (; i < j; i+=2) sum += i;
            textBox3.Text = Convert.ToString(sum);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) sumall();
            else sumother();
        }
    }
}
