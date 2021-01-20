using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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
         * hafta 12 exercises
         */

        int[] a = { 5, 4, 2, 6, 3, 2, 1, 5, 7, 8, 9, 4, 5, 0, 1, 2, 9, 8, 7, 6, 3 };
        private void button1_Click(object sender, EventArgs e)
        {
            double t = 0, ort;
            foreach (int i in a)
                t += i;
            ort = t / a.Length;
            t = 0;
            foreach (int i in a)
                t += Math.Pow(i - ort, 2);
            MessageBox.Show("Standart sapma: "+Math.Sqrt(t/(a.Length-1)), "Sonuc 12.1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int max = a.Max();
            int[] b= new int[max+1];

           for(int i =0; i< a.Length;i++)
                b[a[i]]++;
            for(int i = 0; i < b.Length;i++)
                listBox1.Items.Add(i + ":" + b[i]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int[,] notlar = new int[5, 3]
                {{44,55,66},{43,65,26},{34,15,62},{37,12,63},{84,35,16}};
            int m1, m2, f;
            m1 = m2 = f = 0;
            for (int i = 0; i< 5;i++)
            {
                m1 += notlar[i, 0];
                m2 += notlar[i, 1];
                 f += notlar[i, 2];
                double av = ((notlar[i, 0] + notlar[i, 1]) * 0.40 + notlar[i, 2] * 0.60) ;
                listBox1.Items.Add("Ogrenci " + i + "=" + Math.Round(av,2));
            }
            listBox2.Items.Add((m1 / 5.0).ToString());
            listBox2.Items.Add((m2 / 5.0).ToString());
            listBox2.Items.Add((f / 5.0).ToString());
            int max = notlar.Cast<int>().Max();
            listBox2.Items.Add("max =" + max);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
            richTextBox1.Text += "Generated Matrix: \n";
            int[,] array = new int[5,5];
            Random r = new Random();
            int dig = 0;
            for (int i = 0; i <5; i++)
            {
                int row = 0;
                
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = r.Next(100);
                    if (i == j) dig += array[i, j];
                    row += array[i, j];
                }
                richTextBox1.Text += "Average of the row " + (i + 1).ToString() + " : " +
                    Math.Round((row / 5.0),2).ToString() + "\n";
            }

            for (int i = 0; i <5; i++)
            {
                int col = 0;
                for (int j = 0; j < 5; j++)
                {
                    col += array[j, i];
                }
                richTextBox1.Text += "Average of the col " + (i + 1).ToString() + " : " +
                    Math.Round((col / 5.0), 2).ToString() + "\n";
            }
            int digr = 0,k=4;
            for (int i = 0; i < 5; i++)
            {
                digr += array[i, k];
                k--;
            }
            richTextBox1.Text += "Average of the left diagonal " + " : " +
                    Math.Round((dig / 5.0), 2).ToString() + "\n";
            richTextBox1.Text += "Average of the right diagonal "+ " : " +
                    Math.Round((digr / 5.0), 2).ToString() + "\n";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
            richTextBox1.Text += "Generated Matrix: \n";
            int[,] array = new int[3, 3];
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = r.Next(50);
                    array1[i, j] = r.Next(50);
                    array2[i, j] = array[i, j] + array1[i, j];
                    richTextBox1.AppendText(array2[i, j].ToString() + ", ");
                }
                richTextBox1.AppendText("\n");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
            richTextBox1.Text += "Generated Matrix: \n";
            int[,] array = new int[3, 3];
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = r.Next(50);
                    array1[i, j] = r.Next(50);
                   
                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array2[i, j] += array[i, k] * array1[k, j];
                    }
                    richTextBox1.AppendText(array2[i, j].ToString() + ", ");
                }
                richTextBox1.AppendText("\n");
            }
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0,x;
            try
            {
                x = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox1.Clear();
                textBox1.PlaceholderText = "Integers!";
                return;
            }
            foreach (int i in a)
                if (i == x)
                    count++;
            MessageBox.Show(x + " sayisindan " + count + " tane vardır", "12.3");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                textBox2.Clear();
                textBox2.PlaceholderText = "Integers!";
                return;
            }
            MessageBox.Show("a dizisindeki "+x+" sayisinin ilk indisi: "+ Array.IndexOf(a,x) , "12.4");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int x,sayac=1;
            try
            {
                x = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                textBox3.Clear();
                textBox3.PlaceholderText = "Integers!";
                return;
            }
            
            for(int i = 0; i<a.Length; i++)
                if (a[i]==x)
                {
                    listBox2.Items.Add(x + " , " + sayac + " : " + i);
                    sayac++;
                }
            if (sayac == 1)
                listBox2.Items.Add("Bu sayı bu dizide yok");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
        }
    }
}
