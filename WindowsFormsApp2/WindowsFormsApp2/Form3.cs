using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev6_3 : Form
    {
        public odev6_3()
        {
            InitializeComponent();
        }
        private double prc,tx,times;
        
        private double checking(string age)
        {
            double var;
            try
            {
               var = Convert.ToInt32(age);
            }
            catch
            {
                toolTip1.Show("Please enter a positive number", calculate);
                return -1;
            }
            toolTip1.Hide(calculate);
            if (var <= 0) return -1;
            return var;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_2 f2 = new odev6_2();
            f2.Closed += (s, args) => this.Close();
            f2.ShowDialog();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_4 f3 = new odev6_4();
            f3.Closed += (s, args) => this.Close();
            f3.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            track.Text =Convert.ToString( trackBar1.Value);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            prc = checking(price.Text);
            times = checking(amount.Text);
            tx = checking(tax.Text);
            if (prc == -1 || times == -1 || tx == -1) return;
            else
            {
                if(disc.Checked==false)
                     answer.Text = "Money To Pay:  " +Convert.ToString((prc +(prc* tx / 100)) * times);
                else
                    answer.Text = "Money To Pay:  " + Convert.ToString((prc + (prc * tx / 100)-(prc*(checking(track.Text)/100))) * times);
            }


        }
    }
}
