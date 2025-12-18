namespace BisarogluOtoGaleri
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_u5vnm6u5vnm6u5vn;
            pictureBox1.Location = new Point(-47, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(892, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Hata veren o satırı sildik, yerine görevini yazdık:
            timer1.Stop(); // Sayacı durdur
            this.Close();  // Formu kapat (Bu kapanınca Login açılacak)
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Burası boş kalsa da olur, hata düzelmesi için ekliyoruz.
        }
        #endregion
        private void Timer1_Tick(object sender, EventArgs e)
        {
           // timer1.Stop(); // Saati durdur
            this.Close();  // Formu kapat -> Bu komut Program.cs'deki kilidi açar ve Login'e geçer.
        }
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}