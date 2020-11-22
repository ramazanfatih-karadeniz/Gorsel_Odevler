namespace Odev_5_3_RFatihK
{
    partial class Odev_5_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odev_5_3));
            this.Radius = new System.Windows.Forms.Label();
            this.Circle = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Circum = new System.Windows.Forms.TextBox();
            this.Volumee = new System.Windows.Forms.TextBox();
            this.Areaa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Radius.Location = new System.Drawing.Point(106, 51);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(126, 20);
            this.Radius.TabIndex = 0;
            this.Radius.Text = "Radius Lenght";
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Circle.Location = new System.Drawing.Point(106, 130);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(125, 20);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Circumference";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Area.Location = new System.Drawing.Point(106, 180);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(47, 20);
            this.Area.TabIndex = 2;
            this.Area.Text = "Area";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Volume.Location = new System.Drawing.Point(106, 230);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(69, 20);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(256, 48);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(143, 20);
            this.Input.TabIndex = 4;
            // 
            // Circum
            // 
            this.Circum.Location = new System.Drawing.Point(256, 130);
            this.Circum.Name = "Circum";
            this.Circum.ReadOnly = true;
            this.Circum.Size = new System.Drawing.Size(143, 20);
            this.Circum.TabIndex = 5;
            // 
            // Volumee
            // 
            this.Volumee.Location = new System.Drawing.Point(256, 230);
            this.Volumee.Name = "Volumee";
            this.Volumee.ReadOnly = true;
            this.Volumee.Size = new System.Drawing.Size(143, 20);
            this.Volumee.TabIndex = 6;
            // 
            // Areaa
            // 
            this.Areaa.Location = new System.Drawing.Point(256, 180);
            this.Areaa.Name = "Areaa";
            this.Areaa.ReadOnly = true;
            this.Areaa.Size = new System.Drawing.Size(143, 20);
            this.Areaa.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(109, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cimcumference";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(209, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(309, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Volume";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.PeachPuff;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip1.ToolTipTitle = "Error";
            // 
            // Odev_5_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 315);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Areaa);
            this.Controls.Add(this.Volumee);
            this.Controls.Add(this.Circum);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Radius);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odev_5_3";
            this.Text = "Circle and Sphere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label Circle;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Circum;
        private System.Windows.Forms.TextBox Volumee;
        private System.Windows.Forms.TextBox Areaa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

