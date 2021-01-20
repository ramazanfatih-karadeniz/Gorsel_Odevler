
namespace WindowsFormsApp7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fail = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.high = new System.Windows.Forms.Label();
            this.diff = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(522, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(78, 222);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 3;
            this.p3.TabStop = false;
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(363, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(76, 178);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 3;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.Control;
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(157, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(74, 148);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 3;
            this.p1.TabStop = false;
            // 
            // p6
            // 
            this.p6.Image = ((System.Drawing.Image)(resources.GetObject("p6.Image")));
            this.p6.Location = new System.Drawing.Point(522, 350);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(78, 100);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 3;
            this.p6.TabStop = false;
            // 
            // p5
            // 
            this.p5.Image = ((System.Drawing.Image)(resources.GetObject("p5.Image")));
            this.p5.Location = new System.Drawing.Point(363, 315);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(76, 135);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 3;
            this.p5.TabStop = false;
            // 
            // p4
            // 
            this.p4.Image = ((System.Drawing.Image)(resources.GetObject("p4.Image")));
            this.p4.Location = new System.Drawing.Point(157, 294);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(74, 154);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 3;
            this.p4.TabStop = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.play.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.play.Location = new System.Drawing.Point(40, 197);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 37);
            this.play.TabIndex = 4;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.fail);
            this.panel1.Controls.Add(this.bird);
            this.panel1.Controls.Add(this.p4);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.p5);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.p6);
            this.panel1.Location = new System.Drawing.Point(146, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 450);
            this.panel1.TabIndex = 5;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_DClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.laggy_Move);
            // 
            // fail
            // 
            this.fail.AutoSize = true;
            this.fail.BackColor = System.Drawing.Color.DarkRed;
            this.fail.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fail.Location = new System.Drawing.Point(220, 167);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(201, 65);
            this.fail.TabIndex = 5;
            this.fail.Text = "FAILED!";
            this.fail.Visible = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(28, 167);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(40, 40);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 4;
            this.bird.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 457);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 208);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "LAGGY BIRD";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(13, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "No Collision Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 319);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Old Scores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // high
            // 
            this.high.AutoSize = true;
            this.high.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.high.Location = new System.Drawing.Point(8, 91);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(90, 20);
            this.high.TabIndex = 11;
            this.high.Text = "HighScore=";
            // 
            // diff
            // 
            this.diff.FormattingEnabled = true;
            this.diff.ItemHeight = 15;
            this.diff.Items.AddRange(new object[] {
            "Very Easy",
            "Easy",
            "Normal",
            "Hard",
            "Insane"});
            this.diff.Location = new System.Drawing.Point(8, 125);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(127, 109);
            this.diff.TabIndex = 12;
            this.diff.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(8, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Choose Difficulty";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(797, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.high);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Laggy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox bird;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label fail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label high;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox diff;
    }
}

