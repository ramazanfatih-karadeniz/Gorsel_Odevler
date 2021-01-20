using System;

using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1_RamazanFatihKaradeniz
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Click_Count_Click(object sender, EventArgs e)
        {
           

            if (count == 0)
            {

                button.Text = "Clicked!";
                MessageBox.Show("Welcome! This is the first time that you clicked!", "Message Box",MessageBoxButtons.OKCancel); 
         
            }

            else
            {

                MessageBox.Show("Welcome again! You've Clicked " + (count+1) + " times", "Message Box", MessageBoxButtons.OKCancel);
                button.Location = new Point(ClientSize.Width/(count+1), ClientSize.Height/(count+1));
            
            }
            count++;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            button.Text="Click";
            button.Size = new Size(80, 80);
            button.Location = new Point(ClientSize.Width/2-50,ClientSize.Height/2-40);
            
           
        }
    }
}
