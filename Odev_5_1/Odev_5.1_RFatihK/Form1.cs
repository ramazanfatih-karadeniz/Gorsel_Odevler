using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_5._1_RFatihK
{
    public partial class Exercise_5_1 : Form
    {
        public Exercise_5_1()
        {
            InitializeComponent();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void Title_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }
    }
}
