namespace BisarogluOtoGaleri
{
    partial class FrmAracDetay
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
            txtYil = new TextBox();
            txtKilometre = new TextBox();
            txtFiyat = new TextBox();
            cmbVites = new ComboBox();
            cmbYakit = new ComboBox();
            btnKaydet = new Button();
            chkAgirHasar = new CheckBox();
            pbxAracResim = new PictureBox();
            btnResimSec = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnGeri = new Button();
            btnIleri = new Button();
            lblResimSayac = new Label();
            lkeMarka = new DevExpress.XtraEditors.LookUpEdit();
            lkeModel = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)pbxAracResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lkeMarka.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lkeModel.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtYil
            // 
            txtYil.Location = new Point(319, 131);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(100, 23);
            txtYil.TabIndex = 2;
            txtYil.Text = "Yıl:";
            // 
            // txtKilometre
            // 
            txtKilometre.Location = new Point(319, 160);
            txtKilometre.Name = "txtKilometre";
            txtKilometre.Size = new Size(100, 23);
            txtKilometre.TabIndex = 3;
            txtKilometre.Text = "Kilometre:";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(319, 189);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 4;
            txtFiyat.Text = "Fiyat:";
            // 
            // cmbVites
            // 
            cmbVites.FormattingEnabled = true;
            cmbVites.Location = new Point(319, 218);
            cmbVites.Name = "cmbVites";
            cmbVites.Size = new Size(121, 23);
            cmbVites.TabIndex = 5;
            cmbVites.Text = "Vites Tipi:";
            // 
            // cmbYakit
            // 
            cmbYakit.FormattingEnabled = true;
            cmbYakit.Location = new Point(319, 247);
            cmbYakit.Name = "cmbYakit";
            cmbYakit.Size = new Size(121, 23);
            cmbYakit.TabIndex = 6;
            cmbYakit.Text = "Yakıt Türü:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(395, 304);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // chkAgirHasar
            // 
            chkAgirHasar.AutoSize = true;
            chkAgirHasar.Location = new Point(331, 279);
            chkAgirHasar.Name = "chkAgirHasar";
            chkAgirHasar.Size = new Size(109, 19);
            chkAgirHasar.TabIndex = 9;
            chkAgirHasar.Text = "Ağır Hasarlı mı?";
            chkAgirHasar.UseVisualStyleBackColor = true;
            // 
            // pbxAracResim
            // 
            pbxAracResim.BorderStyle = BorderStyle.FixedSingle;
            pbxAracResim.Location = new Point(31, 39);
            pbxAracResim.Name = "pbxAracResim";
            pbxAracResim.Size = new Size(222, 144);
            pbxAracResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAracResim.TabIndex = 10;
            pbxAracResim.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(138, 275);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(104, 23);
            btnResimSec.TabIndex = 11;
            btnResimSec.Text = "Resim Ekle";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(31, 218);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 12;
            btnGeri.Text = "<";
            btnGeri.UseVisualStyleBackColor = true;
            // 
            // btnIleri
            // 
            btnIleri.Location = new Point(167, 218);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(75, 23);
            btnIleri.TabIndex = 13;
            btnIleri.Text = ">";
            btnIleri.UseVisualStyleBackColor = true;
            // 
            // lblResimSayac
            // 
            lblResimSayac.AutoSize = true;
            lblResimSayac.Location = new Point(121, 222);
            lblResimSayac.Name = "lblResimSayac";
            lblResimSayac.Size = new Size(30, 15);
            lblResimSayac.TabIndex = 14;
            lblResimSayac.Text = "0 / 0";
            // 
            // lkeMarka
            // 
            lkeMarka.Location = new Point(319, 65);
            lkeMarka.Name = "lkeMarka";
            lkeMarka.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lkeMarka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lkeMarka.Properties.NullText = "Marka";
            lkeMarka.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lkeMarka.Size = new Size(100, 20);
            lkeMarka.TabIndex = 15;
            lkeMarka.EditValueChanged += lkeMarka_EditValueChanged;
            // 
            // lkeModel
            // 
            lkeModel.Location = new Point(319, 91);
            lkeModel.Name = "lkeModel";
            lkeModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lkeModel.Properties.NullText = "Model";
            lkeModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lkeModel.Size = new Size(100, 20);
            lkeModel.TabIndex = 16;
            // 
            // FrmAracDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lkeModel);
            Controls.Add(lkeMarka);
            Controls.Add(lblResimSayac);
            Controls.Add(btnIleri);
            Controls.Add(btnGeri);
            Controls.Add(btnResimSec);
            Controls.Add(pbxAracResim);
            Controls.Add(chkAgirHasar);
            Controls.Add(btnKaydet);
            Controls.Add(cmbYakit);
            Controls.Add(cmbVites);
            Controls.Add(txtFiyat);
            Controls.Add(txtKilometre);
            Controls.Add(txtYil);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAracDetay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAracDetay";
            Load += FrmAracDetay_Load;
            ((System.ComponentModel.ISupportInitialize)pbxAracResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)lkeMarka.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lkeModel.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtYil;
        private TextBox txtKilometre;
        private TextBox txtFiyat;
        private ComboBox cmbVites;
        private ComboBox cmbYakit;
        private Button btnKaydet;
        private CheckBox chkAgirHasar;
        private PictureBox pbxAracResim;
        private Button btnResimSec;
        private OpenFileDialog openFileDialog1;
        private Button btnGeri;
        private Button btnIleri;
        private Label lblResimSayac;
        private DevExpress.XtraEditors.LookUpEdit lkeMarka;
        private DevExpress.XtraEditors.LookUpEdit lkeModel;
    }
}