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
         * Odev 9.1 && 9.2 && 9.3
         * */
       
        // ASAL SAYILARI HESAPLAMAK İÇİN FONKSİYON
        private int asal_hesapla(BackgroundWorker worker, int i, DoWorkEventArgs e)
        {

            int j;
            Control.CheckForIllegalCrossThreadCalls = false;
            

           
            int v = listBox1.Items.Count == 0 ? j = 2 : Convert.ToInt32(listBox1.Items[listBox1.Items.Count - 1]) >= i ?
            j = 2 : j = Convert.ToInt32(listBox1.Items[listBox1.Items.Count - 1]);
            if (j == 2) listBox1.Items.Clear();
           
               
            for (;j<=i;j++)
            {

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return 0;
                }
                bool flag = true;
                int k = listBox1.Items.Count - 1;
                int f;
                if (k != -1)  f = (int)listBox1.Items[k];
                
                    for (;k>=0;k--)
                    {
                    
                    if (j % (int)(listBox1.Items[k]) == 0)
                        flag = false;
                    }
                    if (flag) listBox1.Items.Add(j);
                
            }


            button1.Enabled = false;
            return 0;
        }
        // FIBONACCI SAYILARINI HESAPLAMAK İÇİN FONKSİYON
        private int fib_hesapla(BackgroundWorker worker, int i, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            long f1=1, f2=1, f3=0,n;
            if(listBox2.Items.Count>0)
                 listBox2.Items.Clear();
            
            for( n=1;n<=i&&f3< 9223372036854775807/3; n++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return 0;
                }
                if (n < 3)
                    listBox2.Items.Add(f2);
                else
                {
                    f3 = f2;
                    f2 += f1;
                    f1 = f3;
                    listBox2.Items.Add(f2);
                }
            }
            return 0;
        }
        private int div_hesapla(BackgroundWorker worker, int i, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            listBox3.Items.Clear();
            for(int m =1;m<i;m++)
            {

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return 0;
                }
                if (i % m == 0) listBox3.Items.Add(m);
            }
            return 0;
        }
        // TÜM THREAD LARI DURDURMAK İÇİN BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="STOP")
            {
            button1.Text = "CONTINUE";
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
            backgroundWorker3.CancelAsync();
            }
            else
            {
                button1.Text = "STOP";
                textBox1_TextChanged(sender,e);
            }
                
        }
        // TEXTBOX DEĞİŞİNCE 3 THREAD DA ÇAĞRILIR VE HESAPLAMA BAŞLAR
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
            button1.Text = "STOP";
            button1.Enabled = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(2000);
            else
            {
                backgroundWorker1.CancelAsync();
                
            }
                
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync(2000);
            else
            {
                backgroundWorker1.CancelAsync();
               
            }

            if (!backgroundWorker3.IsBusy)
                backgroundWorker3.RunWorkerAsync(2000);
            else
            {
                backgroundWorker1.CancelAsync();
                
            }
                
            }
            else
            {
                listBox1.Items.Clear();
            }
        }
        // PRIME NUMBERS THREAD ININ BAŞLADIĞI YER
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            int i = 0;
            prime.Text = "Calculating..";
            try
            {
                i = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error! Please enter a positive number!", "Error");
            }
            e.Result = asal_hesapla(worker, i, e);
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) prime.Text= "Operation is canceled";
            else if (e.Error != null) MessageBox.Show(e.Error.Message);
            else prime.Text="Calculated!";
        }
        // FIBONACCI THEREAD ININ BAŞLADIĞI YER
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            int i = 0;
            fib.Text = "Calculating..";
            try
            {
                i = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error! Please enter a positive number!", "Error");
            }
            e.Result = fib_hesapla(worker, i, e);
        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) fib.Text = "Operation is canceled";
            else if (e.Error != null) MessageBox.Show(e.Error.Message);
            else fib.Text = "Calculated!";
        }

        // EXACT DIVISOR THEREAD ININ BAŞLADIĞI YER
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            int i = 0;
            div.Text = "Calculating..";
            try
            {
                i = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error! Please enter a positive number!", "Error");
            }
            e.Result = div_hesapla(worker, i, e);
        }
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) div.Text = "Operation is canceled";
            else if (e.Error != null) MessageBox.Show(e.Error.Message);
            else div.Text = "Calculated!";
        }
    }
}
