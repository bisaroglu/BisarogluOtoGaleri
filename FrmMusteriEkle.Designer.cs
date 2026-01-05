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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 74);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 107);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 150);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "TC Kimlik:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 192);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 226);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 259);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Adres:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(245, 71);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(245, 107);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 7;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(236, 223);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 8;
            // 
            // mskTC
            // 
            mskTC.Location = new Point(245, 147);
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(100, 23);
            mskTC.TabIndex = 9;
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(245, 189);
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(100, 23);
            mskTelefon.TabIndex = 10;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(245, 258);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 96);
            txtAdres.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(459, 341);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click_1;
            // 
            // FrmMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(mskTelefon);
            Controls.Add(mskTC);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMusteriEkle";
            Load += FrmMusteriEkle_Load;
            ((System.ComponentModel.ISupportInitialize)txtAdres.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private MaskedTextBox mskTC;
        private MaskedTextBox mskTelefon;
        private DevExpress.XtraEditors.MemoEdit txtAdres;
        private Button btnKaydet;
    }
}