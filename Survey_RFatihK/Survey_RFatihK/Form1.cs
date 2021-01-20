using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_RFatihK
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
        * Exercise 4.5
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if(!((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)&&
                (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked)&&
                (radioButton7.Checked || radioButton8.Checked || radioButton9.Checked)&&
                (radioButton10.Checked || radioButton11.Checked || radioButton12.Checked)))
            {
                MessageBox.Show("Please answer every question!", "Error");
                return;
            }
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button1.Visible = false;
            label1.Location =new Point(label1.Location.X - 45,label1.Location.Y +80);
            label1.Text = "Congratulations! You have successfully completed this survey.";
            label1.BackColor = Color.Gold;
            label1.ForeColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.Size = new System.Drawing.Size(350, 50);
            label1.AutoSize = false;
            

        }
    }
}
