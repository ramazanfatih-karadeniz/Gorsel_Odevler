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
         * Odev [11.1 : 11.5]
         */
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
            

        }

        private void Text_KeyPress(object sender,KeyPressEventArgs e)
        {
            string a = e.KeyChar.ToString().ToUpper();
            if (a == "X" || a == "Q" || a == "W")
                MessageBox.Show("Only Turkish Letters!","Warning!");
        }
        private void Pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = e.KeyChar.ToString();
            if (a == "?" || a == "!" || a == ".")
                MessageBox.Show("Do not use \"?\" or \"!\" or \".\"", "Warning!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(textBox3.Text);
            textBox3.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string i in list)
                listBox1.Items.Add(i);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            bool flag = false;
            List<string> sorted = new List<string>();
            foreach (string i in list)
            {
                sorted.Add(i);
                try
                {
                    int k = Convert.ToInt32(i);
                }
                catch
                {
                    flag = true;
                }
            }
            List<int> sorted_int = new List<int>();
            if (!flag)
            {
                sorted_int = sorted.ConvertAll(int.Parse);
                sorted_int.Sort();
                sorted.ToArray();
                sorted.OrderByDescending(c=>c);
                foreach (int i in sorted_int)
                    listBox2.Items.Add(i);
            }
            else
            {
                sorted.Sort();
                foreach (string i in sorted)
                    listBox2.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = list.Min();
        }
    }
}
