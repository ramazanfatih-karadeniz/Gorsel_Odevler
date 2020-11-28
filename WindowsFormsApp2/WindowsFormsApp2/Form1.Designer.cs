
namespace WindowsFormsApp2
{
    partial class odev6_1
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(66, 66);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(344, 20);
            this.title.TabIndex = 1;
            this.title.Text = "Eligibility for driving license age control system!";
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.input.Location = new System.Drawing.Point(66, 108);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(149, 17);
            this.input.TabIndex = 2;
            this.input.Text = "Please enter your age :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(286, 165);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 0;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Bisque;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Error";
            // 
            // odev6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 286);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.title);
            this.Controls.Add(this.check);
            this.Name = "odev6_1";
            this.Text = "Driving License System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

