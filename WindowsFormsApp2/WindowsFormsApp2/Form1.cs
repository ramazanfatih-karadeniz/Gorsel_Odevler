using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev6_1 : Form
    {
        private int yas;
       
        public odev6_1()
        {
            InitializeComponent();
           
        }
        private int checking(string age)
        {
            try
            {
                yas = Convert.ToInt32(age);
            }
            catch
            {
                toolTip1.Show("Please enter a number", textBox1);
                return -1;
            }
            toolTip1.Hide(textBox1);
            return yas;
        }
        private void check_Click(object sender, EventArgs e)
        {
           yas=checking(textBox1.Text);
            if (yas == -1) return;
            else if (yas >= 18)
                MessageBox.Show("You are eligible!","Congratulations");
            else
                MessageBox.Show("We are sorry but you are not eligible :c","Attention!");
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                check_Click(sender,e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev6_2 f2 = new odev6_2();
            f2.Closed += (s, args) => this.Close();
            f2.ShowDialog();
        }
    }
}
