namespace BisarogluOtoGaleri
{
    partial class FrmMusteriEkle
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            mskTC = new MaskedTextBox();
            mskTelefon = new MaskedTextBox();
            txtAdres = new DevExpress.XtraEditors.MemoEdit();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)txtAdres.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(172, 133, 76);
            txtAd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(319, 207);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(288, 29);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(172, 133, 76);
            txtSoyad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(627, 208);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(297, 29);
            txtSoyad.TabIndex = 7;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.FromArgb(172, 133, 76);
            txtMail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtMail.Location = new Point(787, 275);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(296, 29);
            txtMail.TabIndex = 8;
            // 
            // mskTC
            // 
            mskTC.BackColor = Color.FromArgb(172, 133, 76);
            mskTC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(158, 274);
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(292, 29);
            mskTC.TabIndex = 9;
            // 
            // mskTelefon
            // 
            mskTelefon.BackColor = Color.FromArgb(172, 133, 76);
            mskTelefon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mskTelefon.Location = new Point(469, 275);
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(295, 29);
            mskTelefon.TabIndex = 10;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(153, 356);
            txtAdres.Name = "txtAdres";
            txtAdres.Properties.Appearance.BackColor = Color.FromArgb(172, 133, 76);
            txtAdres.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAdres.Properties.Appearance.ForeColor = Color.Black;
            txtAdres.Properties.Appearance.Options.UseBackColor = true;
            txtAdres.Properties.Appearance.Options.UseFont = true;
            txtAdres.Properties.Appearance.Options.UseForeColor = true;
            txtAdres.Size = new Size(938, 85);
            txtAdres.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.BackgroundImage = Properties.Resources.Gemini_Generated_Image_nead5wnead5wnead1;
            btnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(399, 451);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(441, 50);
            btnKaydet.TabIndex = 13;
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // FrmMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_nead5wnead5wnead;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 545);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(mskTelefon);
            Controls.Add(mskTC);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMusteriEkle";
            Load += FrmMusteriEkle_Load;
            ((System.ComponentModel.ISupportInitialize)txtAdres.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private MaskedTextBox mskTC;
        private MaskedTextBox mskTelefon;
        private DevExpress.XtraEditors.MemoEdit txtAdres;
        private Button btnKaydet;
    }
}