namespace Odev_5._2_RFatihK
{
    partial class Odev_5_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odev_5_2));
            this.Blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Blue.Location = new System.Drawing.Point(200, 75);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(100, 40);
            this.Blue.TabIndex = 0;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.MouseHover += new System.EventHandler(this.Blue_MouseHover);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Red.Location = new System.Drawing.Point(200, 150);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(100, 40);
            this.Red.TabIndex = 1;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.MouseHover += new System.EventHandler(this.Red_MouseHover);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Green.Location = new System.Drawing.Point(200, 225);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(100, 40);
            this.Green.TabIndex = 2;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.MouseHover += new System.EventHandler(this.Green_MouseHover);
            // 
            // Odev_5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 320);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odev_5_2";
            this.Text = "Ramazan Fatih Karadeniz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
    }
}

