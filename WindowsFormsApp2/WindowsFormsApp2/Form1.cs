using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev6_1 : Form
    {
        public int yas;
        public odev6_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                yas = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                toolTip1.Show("Please enter a number",textBox1);
                return;
            }
            toolTip1.Hide(textBox1);
            
            if (yas >= 18)
                MessageBox.Show("You are eligible!","Congratulations");
            else
                MessageBox.Show("We are sorry but you are not eligible :c","Attention!");
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                button1_Click(sender,e);
            }
        }
    }
}
