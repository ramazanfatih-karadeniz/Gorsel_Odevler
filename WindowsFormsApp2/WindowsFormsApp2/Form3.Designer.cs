
namespace WindowsFormsApp2
{
    partial class odev6_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.CheckBox();
            this.price = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.tax = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.track = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tax Rate (%)";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer.Location = new System.Drawing.Point(190, 240);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(97, 17);
            this.answer.TabIndex = 0;
            this.answer.Text = "Money To Pay:";
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disc.Location = new System.Drawing.Point(126, 124);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(80, 21);
            this.disc.TabIndex = 1;
            this.disc.Text = "Discount";
            this.disc.UseVisualStyleBackColor = true;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(246, 36);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 23);
            this.price.TabIndex = 2;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(246, 65);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 23);
            this.amount.TabIndex = 2;
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(246, 95);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(100, 23);
            this.tax.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(202, 202);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(246, 151);
            this.trackBar1.Maximum = 99;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // track
            // 
            this.track.AutoSize = true;
            this.track.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.track.Location = new System.Drawing.Point(246, 127);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(31, 20);
            this.track.TabIndex = 5;
            this.track.Text = "%0";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Bisque;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip1.ToolTipTitle = "ERROR";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(397, 276);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 276);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // odev6_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.track);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.price);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "odev6_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.CheckBox disc;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label track;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
    }
}