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
            lueArac = new DevExpress.XtraEditors.LookUpEdit();
            lueMusteri = new DevExpress.XtraEditors.LookUpEdit();
            label1 = new Label();
            txtFiyat = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
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
            lueArac.Location = new Point(147, 68);
            lueArac.Name = "lueArac";
            lueArac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueArac.Properties.NullText = "";
            lueArac.Size = new Size(100, 20);
            lueArac.TabIndex = 0;
            lueArac.EditValueChanged += lueArac_EditValueChanged;
            // 
            // lueMusteri
            // 
            lueMusteri.Location = new Point(147, 109);
            lueMusteri.Name = "lueMusteri";
            lueMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lueMusteri.Properties.NullText = "Müşteri Seçiniz";
            lueMusteri.Size = new Size(100, 20);
            lueMusteri.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 141);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Satış Fiyatı";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(147, 227);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Properties.ReadOnly = true;
            txtFiyat.Size = new Size(100, 20);
            txtFiyat.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 250);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Tarih:";
            // 
            // dateTarih
            // 
            dateTarih.EditValue = null;
            dateTarih.Location = new Point(147, 268);
            dateTarih.Name = "dateTarih";
            dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Size = new Size(100, 20);
            dateTarih.TabIndex = 5;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Location = new Point(164, 311);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(75, 23);
            btnSatisYap.TabIndex = 6;
            btnSatisYap.Text = "SATIŞ";
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(147, 159);
            txtYil.Name = "txtYil";
            txtYil.Properties.ReadOnly = true;
            txtYil.Size = new Size(100, 20);
            txtYil.TabIndex = 7;
            // 
            // txtYakit
            // 
            txtYakit.Location = new Point(147, 179);
            txtYakit.Name = "txtYakit";
            txtYakit.Properties.ReadOnly = true;
            txtYakit.Size = new Size(100, 20);
            txtYakit.TabIndex = 8;
            // 
            // txtVites
            // 
            txtVites.EditValue = "s";
            txtVites.Location = new Point(147, 201);
            txtVites.Name = "txtVites";
            txtVites.Properties.ReadOnly = true;
            txtVites.Size = new Size(100, 20);
            txtVites.TabIndex = 9;
            // 
            // FrmSatis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtVites);
            Controls.Add(txtYakit);
            Controls.Add(txtYil);
            Controls.Add(btnSatisYap);
            Controls.Add(dateTarih);
            Controls.Add(label2);
            Controls.Add(txtFiyat);
            Controls.Add(label1);
            Controls.Add(lueMusteri);
            Controls.Add(lueArac);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label label2;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private Button btnSatisYap;
        private DevExpress.XtraEditors.TextEdit txtYil;
        private DevExpress.XtraEditors.TextEdit txtYakit;
        private DevExpress.XtraEditors.TextEdit txtVites;
    }
}