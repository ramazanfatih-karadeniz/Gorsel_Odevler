
namespace WindowsFormsApp2
{
    partial class odev6_2
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
            this.w = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.def = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w.Location = new System.Drawing.Point(135, 57);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(106, 20);
            this.w.TabIndex = 0;
            this.w.Text = "Weight (in kg)";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.h.Location = new System.Drawing.Point(135, 97);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(106, 20);
            this.h.TabIndex = 0;
            this.h.Text = "Height (in cm)";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a.Location = new System.Drawing.Point(135, 161);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(86, 20);
            this.a.TabIndex = 0;
            this.a.Text = "Your BMI is";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d.Location = new System.Drawing.Point(135, 201);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(61, 20);
            this.d.TabIndex = 0;
            this.d.Text = "You are";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(247, 58);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 23);
            this.weight.TabIndex = 1;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(247, 98);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 23);
            this.height.TabIndex = 1;
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(247, 161);
            this.ans.Name = "ans";
            this.ans.ReadOnly = true;
            this.ans.Size = new System.Drawing.Size(100, 23);
            this.ans.TabIndex = 1;
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(247, 198);
            this.def.Name = "def";
            this.def.ReadOnly = true;
            this.def.Size = new System.Drawing.Size(100, 23);
            this.def.TabIndex = 1;
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc.Location = new System.Drawing.Point(140, 126);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(207, 30);
            this.calc.TabIndex = 2;
            this.calc.Text = "CALCULATE BMI";
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
            this.next.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.next.Location = new System.Drawing.Point(397, 276);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(12, 276);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // odev6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.def);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.d);
            this.Controls.Add(this.a);
            this.Controls.Add(this.h);
            this.Controls.Add(this.w);
            this.Name = "odev6_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULTOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.TextBox def;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
    }
}