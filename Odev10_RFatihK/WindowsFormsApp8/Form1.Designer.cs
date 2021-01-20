
namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.n = new System.Windows.Forms.TextBox();
            this.s1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbs = new System.Windows.Forms.RadioButton();
            this.ints = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(202, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 214);
            this.listBox1.TabIndex = 1;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(65, 54);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(48, 23);
            this.n.TabIndex = 2;
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(25, 107);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(48, 23);
            this.s1.TabIndex = 2;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(114, 107);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(48, 23);
            this.s2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "N= ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Between";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "And";
            // 
            // dbs
            // 
            this.dbs.AutoSize = true;
            this.dbs.Location = new System.Drawing.Point(94, 181);
            this.dbs.Name = "dbs";
            this.dbs.Size = new System.Drawing.Size(68, 19);
            this.dbs.TabIndex = 4;
            this.dbs.Text = "Doubles";
            this.dbs.UseVisualStyleBackColor = true;
            this.dbs.CheckedChanged += new System.EventHandler(this.dbs_CheckedChanged);
            // 
            // ints
            // 
            this.ints.AutoSize = true;
            this.ints.Checked = true;
            this.ints.Location = new System.Drawing.Point(21, 181);
            this.ints.Name = "ints";
            this.ints.Size = new System.Drawing.Size(67, 19);
            this.ints.TabIndex = 4;
            this.ints.TabStop = true;
            this.ints.Text = "Integers";
            this.ints.UseVisualStyleBackColor = true;
            this.ints.CheckedChanged += new System.EventHandler(this.ints_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mean",
            "Min",
            "Max",
            "Range",
            "St. Dev"});
            this.comboBox1.Location = new System.Drawing.Point(21, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Select Operation";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 333);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ints);
            this.Controls.Add(this.dbs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton ints;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton dbs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

