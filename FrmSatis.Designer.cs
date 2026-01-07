namespace BisarogluOtoGaleri
{
    partial class FrmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis));
            lueArac = new DevExpress.XtraEditors.LookUpEdit();
            lueMusteri = new DevExpress.XtraEditors.LookUpEdit();
            label1 = new Label();
            txtFiyat = new DevExpress.XtraEditors.TextEdit();
            dateTarih = new DevExpress.XtraEditors.DateEdit();
            btnSatisYap = new Button();
            txtYil = new DevExpress.XtraEditors.TextEdit();
            txtYakit = new DevExpress.XtraEditors.TextEdit();
            txtVites = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)lueArac.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lueMusteri.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYil.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYakit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVites.Properties).BeginInit();
            SuspendLayout();
            // 
            // lueArac
            // 
            lueArac.Location = new Point(342, 155);
            lueArac.Name = "lueArac";
            lueArac.Properties.Appearance.BackColor = Color.FromArgb(163, 123, 64);
            lueArac.Properties.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lueArac.Properties.Appearance.ForeColor = Color.Black;
            lueArac.Properties.Appearance.Options.UseBackColor = true;
            lueArac.Properties.Appearance.Options.UseFont = true;
            lueArac.Properties.Appearance.Options.UseForeColor = true;
            lueArac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueArac.Properties.NullText = "";
            lueArac.Size = new Size(577, 32);
            lueArac.TabIndex = 0;
            lueArac.EditValueChanged += lueArac_EditValueChanged;
            // 
            // lueMusteri
            // 
            lueMusteri.Location = new Point(342, 213);
            lueMusteri.Name = "lueMusteri";
            lueMusteri.Properties.Appearance.BackColor = Color.FromArgb(163, 123, 64);
            lueMusteri.Properties.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lueMusteri.Properties.Appearance.ForeColor = Color.Black;
            lueMusteri.Properties.Appearance.Options.UseBackColor = true;
            lueMusteri.Properties.Appearance.Options.UseFont = true;
            lueMusteri.Properties.Appearance.Options.UseForeColor = true;
            lueMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueMusteri.Properties.NullText = "Müşteri Seçiniz";
            lueMusteri.Size = new Size(577, 32);
            lueMusteri.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(513, 272);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 2;
            label1.Text = "Satış Fiyatı";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(789, 326);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Properties.Appearance.BackColor = Color.FromArgb(186, 178, 106);
            txtFiyat.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtFiyat.Properties.Appearance.ForeColor = Color.Black;
            txtFiyat.Properties.Appearance.Options.UseBackColor = true;
            txtFiyat.Properties.Appearance.Options.UseFont = true;
            txtFiyat.Properties.Appearance.Options.UseForeColor = true;
            txtFiyat.Properties.ReadOnly = true;
            txtFiyat.Size = new Size(131, 30);
            txtFiyat.TabIndex = 3;
            // 
            // dateTarih
            // 
            dateTarih.EditValue = null;
            dateTarih.Location = new Point(538, 390);
            dateTarih.Name = "dateTarih";
            dateTarih.Properties.Appearance.BackColor = Color.FromArgb(186, 178, 106);
            dateTarih.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTarih.Properties.Appearance.ForeColor = Color.Black;
            dateTarih.Properties.Appearance.Options.UseBackColor = true;
            dateTarih.Properties.Appearance.Options.UseFont = true;
            dateTarih.Properties.Appearance.Options.UseForeColor = true;
            dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Size = new Size(198, 30);
            dateTarih.TabIndex = 5;
            // 
            // btnSatisYap
            // 
            btnSatisYap.BackgroundImage = Properties.Resources.Adsız;
            btnSatisYap.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatisYap.FlatStyle = FlatStyle.Flat;
            btnSatisYap.Location = new Point(461, 436);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(351, 65);
            btnSatisYap.TabIndex = 6;
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(333, 326);
            txtYil.Name = "txtYil";
            txtYil.Properties.Appearance.BackColor = Color.FromArgb(186, 178, 106);
            txtYil.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtYil.Properties.Appearance.ForeColor = Color.Black;
            txtYil.Properties.Appearance.Options.UseBackColor = true;
            txtYil.Properties.Appearance.Options.UseFont = true;
            txtYil.Properties.Appearance.Options.UseForeColor = true;
            txtYil.Properties.ReadOnly = true;
            txtYil.Size = new Size(140, 30);
            txtYil.TabIndex = 7;
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(492, 326);
            txtYakit.Name = "txtYakit";
            txtYakit.Properties.Appearance.BackColor = Color.FromArgb(186, 178, 106);
            txtYakit.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtYakit.Properties.Appearance.ForeColor = Color.Black;
            txtYakit.Properties.Appearance.Options.UseBackColor = true;
            txtYakit.Properties.Appearance.Options.UseFont = true;
            txtYakit.Properties.Appearance.Options.UseForeColor = true;
            txtYakit.Properties.ReadOnly = true;
            txtYakit.Size = new Size(135, 30);
            txtYakit.TabIndex = 8;
            // 
            // txtVites
            // 
            txtVites.EditValue = "";
            txtVites.Location = new Point(641, 326);
            txtVites.Name = "txtVites";
            txtVites.Properties.Appearance.BackColor = Color.FromArgb(186, 178, 106);
            txtVites.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtVites.Properties.Appearance.ForeColor = Color.Black;
            txtVites.Properties.Appearance.Options.UseBackColor = true;
            txtVites.Properties.Appearance.Options.UseFont = true;
            txtVites.Properties.Appearance.Options.UseForeColor = true;
            txtVites.Properties.ReadOnly = true;
            txtVites.Size = new Size(131, 30);
            txtVites.TabIndex = 9;
            // 
            // FrmSatis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1214, 506);
            Controls.Add(txtVites);
            Controls.Add(txtYakit);
            Controls.Add(txtYil);
            Controls.Add(btnSatisYap);
            Controls.Add(dateTarih);
            Controls.Add(txtFiyat);
            Controls.Add(label1);
            Controls.Add(lueMusteri);
            Controls.Add(lueArac);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSatis";
            Text = "FrmSatis";
            Load += FrmSatis_Load;
            ((System.ComponentModel.ISupportInitialize)lueArac.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lueMusteri.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYil.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYakit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVites.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueArac;
        private DevExpress.XtraEditors.LookUpEdit lueMusteri;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private Button btnSatisYap;
        private DevExpress.XtraEditors.TextEdit txtYil;
        private DevExpress.XtraEditors.TextEdit txtYakit;
        private DevExpress.XtraEditors.TextEdit txtVites;
    }
}