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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracDetay));
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
            txtYil.BackColor = Color.DarkKhaki;
            txtYil.BorderStyle = BorderStyle.FixedSingle;
            txtYil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtYil.Location = new Point(213, 182);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(100, 29);
            txtYil.TabIndex = 2;
            txtYil.Text = "Yıl:";
            // 
            // txtKilometre
            // 
            txtKilometre.BackColor = Color.DarkKhaki;
            txtKilometre.BorderStyle = BorderStyle.FixedSingle;
            txtKilometre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKilometre.Location = new Point(213, 309);
            txtKilometre.Name = "txtKilometre";
            txtKilometre.Size = new Size(100, 29);
            txtKilometre.TabIndex = 3;
            txtKilometre.Text = "Kilometre:";
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = Color.DarkKhaki;
            txtFiyat.BorderStyle = BorderStyle.FixedSingle;
            txtFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtFiyat.Location = new Point(213, 384);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 29);
            txtFiyat.TabIndex = 4;
            txtFiyat.Text = "Fiyat:";
            // 
            // cmbVites
            // 
            cmbVites.BackColor = Color.DarkKhaki;
            cmbVites.FlatStyle = FlatStyle.Flat;
            cmbVites.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbVites.FormattingEnabled = true;
            cmbVites.Items.AddRange(new object[] { "Otomatik", "Manuel" });
            cmbVites.Location = new Point(213, 269);
            cmbVites.Name = "cmbVites";
            cmbVites.Size = new Size(121, 29);
            cmbVites.TabIndex = 5;
            cmbVites.Text = "Vites Tipi:";
            // 
            // cmbYakit
            // 
            cmbYakit.BackColor = Color.DarkKhaki;
            cmbYakit.FlatStyle = FlatStyle.Flat;
            cmbYakit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbYakit.FormattingEnabled = true;
            cmbYakit.Items.AddRange(new object[] { "Dizel", "Benzin", "Elektrik", "LPG" });
            cmbYakit.Location = new Point(213, 226);
            cmbYakit.Name = "cmbYakit";
            cmbYakit.Size = new Size(121, 29);
            cmbYakit.TabIndex = 6;
            cmbYakit.Text = "Yakıt Türü:";
            cmbYakit.SelectedIndexChanged += cmbYakit_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ControlDarkDark;
            btnKaydet.BackgroundImage = Properties.Resources.Gemini_Generated_Image_e1l3x8e1l3x8e1l3__1_;
            btnKaydet.BackgroundImageLayout = ImageLayout.Stretch;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(213, 435);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(351, 59);
            btnKaydet.TabIndex = 8;
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // chkAgirHasar
            // 
            chkAgirHasar.AutoSize = true;
            chkAgirHasar.BackColor = Color.DarkKhaki;
            chkAgirHasar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkAgirHasar.Location = new Point(213, 348);
            chkAgirHasar.Name = "chkAgirHasar";
            chkAgirHasar.Size = new Size(149, 25);
            chkAgirHasar.TabIndex = 9;
            chkAgirHasar.Text = "Ağır Hasarlı mı?";
            chkAgirHasar.UseVisualStyleBackColor = false;
            // 
            // pbxAracResim
            // 
            pbxAracResim.BackColor = Color.DarkKhaki;
            pbxAracResim.BorderStyle = BorderStyle.FixedSingle;
            pbxAracResim.Location = new Point(704, 107);
            pbxAracResim.Name = "pbxAracResim";
            pbxAracResim.Size = new Size(457, 232);
            pbxAracResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxAracResim.TabIndex = 10;
            pbxAracResim.TabStop = false;
            pbxAracResim.Tag = "";
            // 
            // btnResimSec
            // 
            btnResimSec.BackColor = Color.DarkKhaki;
            btnResimSec.BackgroundImage = (Image)resources.GetObject("btnResimSec.BackgroundImage");
            btnResimSec.BackgroundImageLayout = ImageLayout.Stretch;
            btnResimSec.FlatStyle = FlatStyle.Flat;
            btnResimSec.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnResimSec.Location = new Point(820, 424);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(236, 38);
            btnResimSec.TabIndex = 11;
            btnResimSec.UseVisualStyleBackColor = false;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Olive;
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Location = new Point(778, 361);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 12;
            btnGeri.Text = "<";
            btnGeri.UseVisualStyleBackColor = false;
            // 
            // btnIleri
            // 
            btnIleri.BackColor = Color.Olive;
            btnIleri.FlatStyle = FlatStyle.Flat;
            btnIleri.Location = new Point(1017, 363);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(75, 23);
            btnIleri.TabIndex = 13;
            btnIleri.Text = ">";
            btnIleri.UseVisualStyleBackColor = false;
            // 
            // lblResimSayac
            // 
            lblResimSayac.AutoSize = true;
            lblResimSayac.BackColor = Color.DarkKhaki;
            lblResimSayac.Location = new Point(918, 369);
            lblResimSayac.Name = "lblResimSayac";
            lblResimSayac.Size = new Size(30, 15);
            lblResimSayac.TabIndex = 14;
            lblResimSayac.Text = "0 / 0";
            // 
            // lkeMarka
            // 
            lkeMarka.Location = new Point(213, 104);
            lkeMarka.Name = "lkeMarka";
            lkeMarka.Properties.Appearance.BackColor = Color.DarkKhaki;
            lkeMarka.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lkeMarka.Properties.Appearance.ForeColor = Color.Black;
            lkeMarka.Properties.Appearance.Options.UseBackColor = true;
            lkeMarka.Properties.Appearance.Options.UseFont = true;
            lkeMarka.Properties.Appearance.Options.UseForeColor = true;
            lkeMarka.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lkeMarka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lkeMarka.Properties.NullText = "";
            lkeMarka.Properties.NullValuePrompt = "Marka";
            lkeMarka.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lkeMarka.Size = new Size(100, 26);
            lkeMarka.TabIndex = 15;
            lkeMarka.EditValueChanged += lkeMarka_EditValueChanged;
            // 
            // lkeModel
            // 
            lkeModel.Location = new Point(213, 142);
            lkeModel.Name = "lkeModel";
            lkeModel.Properties.Appearance.BackColor = Color.DarkKhaki;
            lkeModel.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lkeModel.Properties.Appearance.ForeColor = Color.Black;
            lkeModel.Properties.Appearance.Options.UseBackColor = true;
            lkeModel.Properties.Appearance.Options.UseFont = true;
            lkeModel.Properties.Appearance.Options.UseForeColor = true;
            lkeModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lkeModel.Properties.NullText = "";
            lkeModel.Properties.NullValuePrompt = "Model";
            lkeModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lkeModel.Size = new Size(100, 26);
            lkeModel.TabIndex = 16;
            // 
            // FrmAracDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_1f5dtm1f5dtm1f5d;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 545);
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
            FormBorderStyle = FormBorderStyle.None;
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