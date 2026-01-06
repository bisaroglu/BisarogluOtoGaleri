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
            cmbGirisTürü = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)defaultBarAndDockingController1.Controller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbGirisTürü.Properties).BeginInit();
            SuspendLayout();
            // 
            // defaultBarAndDockingController1
            // 
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.Gold;
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Location = new Point(442, 325);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(158, 23);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.Gold;
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Location = new Point(442, 415);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(158, 23);
            txtSifre.TabIndex = 6;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Gold;
            btnGiris.BackgroundImage = Properties.Resources.Gemini_Generated_Image_zhw7o8zhw7o8zhw7;
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Location = new Point(386, 476);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(401, 53);
            btnGiris.TabIndex = 7;
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click_1;
            // 
            // cmbGirisTürü
            // 
            cmbGirisTürü.EditValue = "Yönetici";
            cmbGirisTürü.Location = new Point(385, 235);
            cmbGirisTürü.Name = "cmbGirisTürü";
            cmbGirisTürü.Properties.Appearance.BackColor = Color.FromArgb(25, 50, 35);
            cmbGirisTürü.Properties.Appearance.Font = new Font("Verdana", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbGirisTürü.Properties.Appearance.ForeColor = Color.Gold;
            cmbGirisTürü.Properties.Appearance.Options.UseBackColor = true;
            cmbGirisTürü.Properties.Appearance.Options.UseFont = true;
            cmbGirisTürü.Properties.Appearance.Options.UseForeColor = true;
            cmbGirisTürü.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbGirisTürü.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Yönetici", "", CheckState.Checked, "Yönetici"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Satış Uzmanı", "", "Satış Uzmanı") });
            cmbGirisTürü.Properties.SelectAllItemVisible = false;
            cmbGirisTürü.Size = new Size(401, 34);
            cmbGirisTürü.TabIndex = 8;
            // 
            // LoginForm
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1168, 673);
            Controls.Add(cmbGirisTürü);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Kullanıcı Girişi";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)defaultBarAndDockingController1.Controller).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbGirisTürü.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbGirisTürü;
    }
}