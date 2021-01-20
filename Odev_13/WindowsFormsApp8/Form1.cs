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

        Bitmap Backbuffer;

    Timer GameTimer = new Timer();
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            
            GameTimer.Interval = 100;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            GameTimer.Start();

            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Form1_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(Form1_MouseDown);
        }
        int x, y,scary=600,script=0;
        bool stars = true;
        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();

            }

        }
        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                x = (ClientRectangle.X - e.X) / 6 * -1;
                y = (ClientRectangle.Y - e.Y) / 9 * -1;
            
        }
        
        bool eye = true;
        PointF[] points = new PointF[500];
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        void Draw()
        {
            if (Backbuffer != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    g.Clear(Color.Black);
                    Random r = new Random();
                    Pen kalem = new Pen(Color.Navy, scary);
                    Pen kalem2 = new Pen(Color.White, 1);

                    if (!stars)
                    {


                        for (int i = 0; i < 500; i++)
                        {

                            int a = r.Next(ClientSize.Width);
                            int b = r.Next(ClientSize.Height);
                            points[i] = new PointF(a, b);
                        }

                       
                        foreach (PointF point in points)
                        {
                            int a = (r.Next(3) + 1);
                            int b = r.Next(200);
                            if (Math.Abs(point.X - ClientSize.Width / 2) < 10
                             && Math.Abs(point.Y - ClientSize.Height / 2) < 10)
                                g.FillEllipse(Brushes.White, point.X, point.Y, 5, 5);
                            else
                                g.DrawLine(kalem2, ClientSize.Width / 2 + (ClientSize.Width / 2 - point.X) / a * -1,
                                    ClientSize.Height / 2 + (ClientSize.Height / 2 - point.Y) / a * -1
                                    , point.X,
                                  point.Y);



                        }
                    }
                    if(eye)
                        g.Clear(Color.Navy);
                    else
                    {
                        
                        g.FillEllipse(Brushes.IndianRed, ClientRectangle.Width / 2-120 +x, ClientRectangle.Height / 2-120 +y, 160, 160);
                        g.FillEllipse(Brushes.Black, ClientRectangle.Width / 2 -55 +x, ClientRectangle.Height / 2 -85 +y, 30, 100);
                        g.DrawEllipse(kalem, 0,0,900,600);
                    }
                    Font f = new Font("Segoe UI", 12, FontStyle.Bold);
                    switch (script+1)
                    {
                        case 1:                          
                            g.DrawString("Where am I? Who are you?", f, Brushes.White, new PointF(100, 100));                           
                            break;

                        case 2:
                            g.DrawString("I am a multidimensional creature!\nLet me out!", f, Brushes.White, new PointF(100, 100));
                            break;
                        case 3:
                            g.DrawString("I am gonna get out of here. \nSee you later!", f, Brushes.White, new PointF(100, 100));
                            break;
                        case 4:
                            g.DrawString("But.. You!\n Oh. How is it possible?", f, Brushes.White, new PointF(100, 100));
                            break;
                        case 5:
                            g.DrawString("There is no escape!\nWhat are you?", f, Brushes.White, new PointF(100, 100));
                            break;
                        case 6:
                            g.DrawString("I accept my destiny...", f, Brushes.White, new PointF(100, 100));
                            break;
                    }

                }
               

                Invalidate();
            }
        }
        void Eye_Move(int a,int b,int c,int d)
        {
            while (x != a && y != b)
            {
                for (int i = 0; i < 1000000; i++) ;
                x+=c;
                y+=d;
            }
        }
        int Eye_Open(BackgroundWorker worker,DoWorkEventArgs e)
        {
            button2.Enabled = false;
            if (script == 0)
            {
                scary = 600;
                x = 60;
                y = 60;
                while (scary > 500)
                {
                    for (int i = 0; i < 10000000; i++) ;
                    scary -= 1;

                }
                while (scary < 600)
                {
                    for (int i = 0; i < 10000000; i++) ;
                    scary += 1;
                }

                while (scary > 300)
                {
                    for (int i = 0; i < 1000000; i++) ;
                    scary -= 3;

                }
                Eye_Move(150, 20, 1, -1);
                Eye_Move(50, 70, -1, 1);
                Eye_Move(20, 10, -1, -1);
                Eye_Move(150, 120, 1, 1);
                Eye_Move(90, 90, -1, -1);
                Eye_Move(30, 120, -1, 1);
                Eye_Move(-30, 20, -1, -1);
                Eye_Move(150, -20, 1, -1);
                Eye_Move(80, 80, 1, 1);
                Eye_Move(60, 60, -1, -1);
            }
            if (script == 0)
                stars = false;
            else if (script == 1)
                stars = true;
            else if (script == 2)
                stars = false;
            else
            {
                stars = false;
                if (script == 5)
                    stars = true;
                if (scary < 600)
                    while (scary < 600)
                    {
                        for (int i = 0; i < 1000000; i++) ;
                        scary += 1;
                    }
                else if (scary < 1150)
                    while (scary < 1150)
                    {
                        for (int i = 0; i < 1000000; i++) ;
                        scary += 1;
                    }
                else
                    while (scary >= 300)
                    {
                        for (int i = 0; i < 1000000; i++) ;
                        scary -= 1;
                    }
            }
            button2.Enabled = true;
            return 1;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Control.CheckForIllegalCrossThreadCalls = false;
            e.Result = Eye_Open(worker, e);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            script++;
            stars = true;
            MouseEventArgs e1 = new MouseEventArgs(MouseButtons.Left, 1, 2, 2, 3);
           
            switch (script)
            {
                case 1:                   
                    button2.Text = "You are a prisoner.";
                    Form1_MouseDown(sender, e1);
                    break;
                case 2:button2.Text = "Dimensions does not matter here.";
                    Form1_MouseDown(sender, e1);
                    break;
                case 3:button2.Text = "You can not escape!";
                    Form1_MouseDown(sender, e1);
                    break;
                case 4:button2.Text = "Now I can see you. I am your guard";
                    Form1_MouseDown(sender, e1);
                    break;
                case 5:button2.Text = "Now turn back first dimention";
                    Form1_MouseDown(sender, e1);
                    break;
                case 6: button2.Text = "Rest a little. You have all the time :)";
                    Form1_MouseDown(sender, e1);
                    break;
            }
        }

        void GameTimer_Tick(object sender, EventArgs e)
        {        
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Visible = false;
            eye = false;
            MouseEventArgs e1 = new MouseEventArgs(MouseButtons.Left, 1, 2, 2, 3);
            Form1_MouseDown(sender, e1);
        }
    }
}
