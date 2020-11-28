
namespace WindowsFormsApp2
{
    partial class odev6_4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.f = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.RadioButton();
            this.mines = new System.Windows.Forms.RadioButton();
            this.prod = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f.Location = new System.Drawing.Point(92, 75);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(96, 20);
            this.f.TabIndex = 0;
            this.f.Text = "First number";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.s.Location = new System.Drawing.Point(92, 112);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(117, 20);
            this.s.TabIndex = 0;
            this.s.Text = "Second number";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.r.Location = new System.Drawing.Point(92, 241);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(50, 20);
            this.r.TabIndex = 0;
            this.r.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 1;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Checked = true;
            this.sum.Location = new System.Drawing.Point(92, 166);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(37, 24);
            this.sum.TabIndex = 2;
            this.sum.TabStop = true;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            // 
            // mines
            // 
            this.mines.AutoSize = true;
            this.mines.Location = new System.Drawing.Point(192, 166);
            this.mines.Name = "mines";
            this.mines.Size = new System.Drawing.Size(33, 24);
            this.mines.TabIndex = 2;
            this.mines.TabStop = true;
            this.mines.Text = "-";
            this.mines.UseVisualStyleBackColor = true;
            // 
            // prod
            // 
            this.prod.AutoSize = true;
            this.prod.Location = new System.Drawing.Point(292, 166);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(34, 24);
            this.prod.TabIndex = 2;
            this.prod.TabStop = true;
            this.prod.Text = "*";
            this.prod.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(392, 166);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(33, 24);
            this.div.TabIndex = 3;
            this.div.TabStop = true;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 1;
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc.Location = new System.Drawing.Point(192, 191);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(113, 27);
            this.calc.TabIndex = 4;
            this.calc.Text = "CALCULATE";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Bisque;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip1.ToolTipTitle = "ERROR";
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.next.Location = new System.Drawing.Point(397, 276);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(12, 276);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // odev6_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.div);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.mines);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.s);
            this.Controls.Add(this.f);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "odev6_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton sum;
        private System.Windows.Forms.RadioButton mines;
        private System.Windows.Forms.RadioButton prod;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
    }
}