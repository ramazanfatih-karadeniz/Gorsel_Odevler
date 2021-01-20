
namespace WindowsFormsApp4
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
            this.Colors = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.FormattingEnabled = true;
            this.Colors.ItemHeight = 15;
            this.Colors.Items.AddRange(new object[] {
            "Green",
            "Blue",
            "Red"});
            this.Colors.Location = new System.Drawing.Point(158, 93);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(120, 94);
            this.Colors.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Colors);
            this.Name = "Form1";
            this.Text = "Odev_8_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Colors;
        private System.Windows.Forms.Button button1;
    }
}

