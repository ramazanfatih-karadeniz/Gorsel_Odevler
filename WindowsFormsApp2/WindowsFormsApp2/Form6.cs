﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class odev7_2 : Form
    {
        public odev7_2()
        {
            InitializeComponent();
        }
 	/*
       * Ramazan Fatih Karadeniz
       * 2017280029
       * Exercise 7.2
       */
        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan gap = new TimeSpan();
            gap = DateTime.Now - birth.Value;
            total.Text=Convert.ToString(gap.Days* Convert.ToInt32( hours.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            odev7_1 f3 = new odev7_1();
            f3.Closed += (s, args) => this.Close();
            f3.ShowDialog();
        }
    }
}