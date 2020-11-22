namespace Odev_5._1_RFatihK
{
    partial class Exercise_5_1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise_5_1));
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Undo = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Complete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Title.Location = new System.Drawing.Point(111, 82);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(65, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Article:";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(216, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Undo
            // 
            this.Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Undo.BackgroundImage")));
            this.Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Undo.Location = new System.Drawing.Point(109, 140);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 2;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(209, 140);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Complete
            // 
            this.Complete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Complete.BackgroundImage")));
            this.Complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Complete.Location = new System.Drawing.Point(309, 140);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(75, 23);
            this.Complete.TabIndex = 4;
            this.Complete.Text = "Complete";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // Exercise_5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 247);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercise_5_1";
            this.Text = "Ramazan Fatih Karadeniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Complete;
    }
}

