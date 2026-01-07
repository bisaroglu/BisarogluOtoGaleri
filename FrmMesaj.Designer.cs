
namespace BisarogluOtoGaleri
{
    partial class FrmMesaj
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
            lblBaslik = new DevExpress.XtraEditors.LabelControl();
            lblMesaj = new DevExpress.XtraEditors.LabelControl();
            btnTamam = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.Appearance.ForeColor = Color.DarkKhaki;
            lblBaslik.Appearance.Options.UseFont = true;
            lblBaslik.Appearance.Options.UseForeColor = true;
            lblBaslik.Appearance.Options.UseTextOptions = true;
            lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblBaslik.Location = new Point(142, 49);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(110, 19);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "labelControl1";
            // 
            // lblMesaj
            // 
            lblMesaj.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMesaj.Appearance.ForeColor = Color.DarkKhaki;
            lblMesaj.Appearance.Options.UseFont = true;
            lblMesaj.Appearance.Options.UseForeColor = true;
            lblMesaj.Appearance.Options.UseTextOptions = true;
            lblMesaj.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblMesaj.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            lblMesaj.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblMesaj.Location = new Point(49, 76);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(296, 42);
            lblMesaj.TabIndex = 1;
            lblMesaj.Text = "labelControl1";
            lblMesaj.Click += lblMesaj_Click;
            // 
            // btnTamam
            // 
            btnTamam.Appearance.BackColor = Color.Olive;
            btnTamam.Appearance.BorderColor = Color.Black;
            btnTamam.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTamam.Appearance.ForeColor = SystemColors.InfoText;
            btnTamam.Appearance.Options.UseBackColor = true;
            btnTamam.Appearance.Options.UseBorderColor = true;
            btnTamam.Appearance.Options.UseFont = true;
            btnTamam.Appearance.Options.UseForeColor = true;
            btnTamam.DialogResult = DialogResult.OK;
            btnTamam.Location = new Point(162, 128);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(75, 23);
            btnTamam.TabIndex = 2;
            btnTamam.Text = "TAMAM";
            // 
            // FrmMesaj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 40, 20);
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_x0wak8x0wak8x0wa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 200);
            Controls.Add(btnTamam);
            Controls.Add(lblMesaj);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaj";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMesaj";
            Load += FrmMesaj_Load;
            ResumeLayout(false);
        }

        private void FrmMesaj_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.LabelControl lblMesaj;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
    }
}