﻿using System;
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
         * Exercise 10
         * */
        private Point last_location = new Point (0,0);
        private int score = 0,gap=90,speed=1;
        
        private void laggy_Move(object sender,MouseEventArgs e)
        {        
        if(last_location!=e.Location)
                {
                last_location = e.Location;
                textBox1.Text = e.X.ToString();
                textBox2.Text = e.Y.ToString();            
                }    
        }
        private void Mouse_Click(object sender,MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                
                int a = bird.Location.Y;
                while (bird.Location.Y > a - 60&&bird.Location.Y>0)
                    bird.Location = new Point(bird.Location.X, bird.Location.Y - 1);
            }
        }
        private void Mouse_DClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int a = bird.Location.Y;
                while (bird.Location.Y > a - 60 && bird.Location.Y > 0)
                    bird.Location = new Point(bird.Location.X, bird.Location.Y - 1);
            }
        }
        private bool check(string a)
        {
            try
            {
                Convert.ToInt32(a);
            }
            catch
            {
                return true;
            }
            return false;
        }
        private int Find_Max()
        {
            int max,j=0;
            string a;
            a=listBox1.Items[0].ToString();
            while(check(a))
            {
                j++;
                a = listBox1.Items[j].ToString();
            }
            if (listBox1.Items.Count != 0) max = (int)listBox1.Items[j];
            else
                return 0;
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                a=listBox1.Items[i].ToString();
                if (!check(a)) 
                    if ((int)listBox1.Items[i] > max) max =(int)listBox1.Items[i];
            }
                
            return max;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            listBox1.Items.Add(score);
            high.Text ="HighScore = " +Find_Max().ToString();
            score = 0;
            label4.Text = "Score:";
            fail.Visible = false;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(2000);
               
            }
                
            else
            {
                backgroundWorker1.CancelAsync();

            }
           
        }
        private bool check_state()
        {
            if ((bird.Bounds.IntersectsWith(p1.Bounds)|| bird.Bounds.IntersectsWith(p2.Bounds) || bird.Bounds.IntersectsWith(p3.Bounds) ||
                bird.Bounds.IntersectsWith(p4.Bounds) || bird.Bounds.IntersectsWith(p5.Bounds) || bird.Bounds.IntersectsWith(p6.Bounds))
                && !checkBox1.Checked)
            {
                
                return true;
            }
                
            return false;
        }
        private int pipe_move(BackgroundWorker worker, DoWorkEventArgs e)
        {
            
             Random r = new Random();
             while (true)
             {
                 if (worker.CancellationPending || check_state())
                 {

                     e.Cancel = true;
                     return 0;
                 }
                 if(bird.Location.Y<400)
                {
                    if(p1.Location.X%5==0)
                    bird.Location = new Point(bird.Location.X,bird.Location.Y+speed);
                   
                }
                else
                {
                    e.Cancel = true;
                    return 0;
                }
                 if(p1.Location.X > -100)
                 {
                     p1.Location = new Point(p1.Location.X-speed, p1.Location.Y);
                     p4.Location = new Point(p4.Location.X - speed, p4.Location.Y);
                 }

                 else
                 {
                    score++;
                    label4.Text ="Score:"+ score.ToString();
                    int x=0, y=0,oldy;
                     oldy = p4.Size.Height;
                     while(x+y+gap!=450)
                     {
                         x = r.Next(300);
                         y = r.Next(300);
                     }

                     p1.Location = new Point(800, p1.Location.Y);
                     p4.Location = new Point(800, p4.Location.Y+(oldy-y));
                     p1.Size = new Size(p1.Size.Width, x);
                     p4.Size = new Size(p4.Size.Width, y);
                 }


                 if (p2.Location.X > -100)
                 {
                     p2.Location = new Point(p2.Location.X - speed, p2.Location.Y);
                     p5.Location = new Point(p5.Location.X - speed, p5.Location.Y);
                 }

                 else
                 {
                    score++;
                    label4.Text = "Score:" + score.ToString();
                    int x = 0, y = 0, oldy;
                     oldy = p5.Size.Height;
                     while (x + y + gap != 450)
                     {
                         x = r.Next(300);
                         y = r.Next(300);
                     }

                     p2.Location = new Point(800, p2.Location.Y);
                     p5.Location = new Point(800, p5.Location.Y + (oldy - y));
                     p2.Size = new Size(p2.Size.Width, x);
                     p5.Size = new Size(p5.Size.Width, y);
                 }

                 if (p3.Location.X > -100)
                 {
                     p3.Location = new Point(p3.Location.X - speed, p3.Location.Y);
                     p6.Location = new Point(p6.Location.X - speed, p6.Location.Y);
                 }

                 else
                 {
                    score++;
                    label4.Text = "Score:" + score.ToString();
                    int x = 0, y = 0, oldy;
                     oldy = p6.Size.Height;
                     while (x + y + gap != 450)
                     {
                         x = r.Next(300);
                         y = r.Next(300);
                     }

                     p3.Location = new Point(800, p3.Location.Y);
                     p6.Location = new Point(800, p6.Location.Y + (oldy - y));
                     p3.Size = new Size(p3.Size.Width, x);
                     p6.Size = new Size(p6.Size.Width, y);
                 }

             }
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            e.Result = pipe_move(worker, e);
        }

      
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                play.Text = "Play again!";
                fail.Visible = true;
                
            }
            else if (e.Error != null) MessageBox.Show(e.Error.Message);
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.LightGray;
            bird.Location = new Point(bird.Location.X,200);
            p1.Location = new Point(657, 0);
            p2.Location = new Point(1063, 0);
            p3.Location = new Point(1322, 0);
            p4.Location = new Point(657, 294);
            p5.Location = new Point(1063, 315);
            p6.Location = new Point(1322, 350);
            p1.Size = new Size(74, 148);
            p2.Size = new Size(76, 178);
            p3.Size = new Size(78, 222);
            p4.Size = new Size(74, 154);
            p5.Size = new Size(76, 135);
            p6.Size = new Size(78, 100);
            label4.Text += score.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox1.Checked)checkBox1.ForeColor = Color.LightGray;
            else checkBox1.ForeColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(listBox1.Visible)
            {
                listBox1.Location = new Point(listBox1.Location.X - 150, listBox1.Location.Y);
                panel1.Size = new Size(panel1.Width + 200, panel1.Height);
                panel1.Location = new Point(panel1.Location.X - 200, panel1.Location.Y); 
                button1.Text = "Old Scores";
                listBox1.Visible = false;
            }
            else
            {
                panel1.Size = new Size(panel1.Width - 200, panel1.Height);
                panel1.Location = new Point(panel1.Location.X + 200, panel1.Location.Y);
                listBox1.Visible = true;
                listBox1.Location = new Point(listBox1.Location.X + 150, listBox1.Location.Y);
                button1.Text = "Hide Scores";
            }
            
        }
        private void set_difficulty(string a)
        {
            if(a=="Very Easy")
            {
                speed = 1;
                gap = 150;
            }
            else if(a=="Easy")
            {
                speed = 1;
                gap = 120;
            }
            else if (a == "Normal")
            {
                speed = 1;
                gap = 90;
            }
            else if (a == "Hard")
            {
                speed = 2;
                gap = 90;
            }
            else
            {
                speed = 2;
                gap = 60;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (diff.Visible)
            {
                if (diff.SelectedItem!=null)
                {
                    string a;
                    a = diff.SelectedItem.ToString();
                    if (listBox1.Items.Count != 0)
                    {
                        if (listBox1.Items[listBox1.Items.Count - 1].ToString() != a) listBox1.Items.Add(diff.SelectedItem);
                    }
                    else
                        listBox1.Items.Add(diff.SelectedItem);
                    diff.Location = new Point(diff.Location.X - 150, listBox1.Location.Y);
                    panel1.Size = new Size(panel1.Width + 200, panel1.Height);
                    panel1.Location = new Point(panel1.Location.X - 200, panel1.Location.Y);
                    set_difficulty(a);
                    diff.Text = "Choose Difficulty";
                    diff.Visible = false;
                }
                else
                    MessageBox.Show("Please select an item!");        
            }
            else
            {
                diff.Visible = true;
                panel1.Size = new Size(panel1.Width - 200, panel1.Height);
                panel1.Location = new Point(panel1.Location.X + 200, panel1.Location.Y);
                diff.Location = new Point(diff.Location.X +150, diff.Location.Y);
                diff.Text = "Select Difficulty";
            }
        }
    }
}
