namespace BisarogluOtoGaleri
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(components);
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            cmbGiris = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)defaultBarAndDockingController1.Controller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbGiris.Properties).BeginInit();
            SuspendLayout();
            // 
            // defaultBarAndDockingController1
            // 
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(10, 40, 20);
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.ForeColor = Color.Gold;
            txtKullaniciAdi.Location = new Point(473, 350);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(338, 29);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(10, 40, 20);
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.Gold;
            txtSifre.Location = new Point(473, 447);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(338, 29);
            txtSifre.TabIndex = 6;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Gold;
            btnGiris.BackgroundImage = Properties.Resources.Gemini_Generated_Image_zhw7o8zhw7o8zhw7;
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Location = new Point(414, 515);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(430, 53);
            btnGiris.TabIndex = 7;
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click_1;
            // 
            // cmbGiris
            // 
            cmbGiris.Location = new Point(414, 257);
            cmbGiris.Name = "cmbGiris";
            cmbGiris.Properties.Appearance.BackColor = Color.FromArgb(10, 40, 20);
            cmbGiris.Properties.Appearance.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbGiris.Properties.Appearance.ForeColor = Color.Gold;
            cmbGiris.Properties.Appearance.Options.UseBackColor = true;
            cmbGiris.Properties.Appearance.Options.UseFont = true;
            cmbGiris.Properties.Appearance.Options.UseForeColor = true;
            cmbGiris.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbGiris.Properties.Items.AddRange(new object[] { "Yönetici", "Satış Uzmanı" });
            cmbGiris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbGiris.Size = new Size(397, 32);
            cmbGiris.TabIndex = 8;
            cmbGiris.SelectedIndexChanged += cmbGiris_SelectedIndexChanged;
            // 
            // LoginForm
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1252, 729);
            Controls.Add(cmbGiris);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Kullanıcı Girişi";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)defaultBarAndDockingController1.Controller).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbGiris.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGiris;
    }
}