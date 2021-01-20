using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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
         * Odev8.1
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (Colors.SelectedItem == "Green") this.BackColor = Color.Green;
            else if (Colors.SelectedItem == "Red") this.BackColor = Color.Red;
            else if (Colors.SelectedItem == "Blue") this.BackColor = Color.Blue;
            else MessageBox.Show("Please select an item!", "Error");
        }
    }
}
