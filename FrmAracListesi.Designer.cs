namespace BisarogluOtoGaleri
{
    partial class FrmAracListesi
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            peK4 = new DevExpress.XtraEditors.PictureEdit();
            peK3 = new DevExpress.XtraEditors.PictureEdit();
            peK2 = new DevExpress.XtraEditors.PictureEdit();
            peK1 = new DevExpress.XtraEditors.PictureEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)peK4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peK3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peK2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peK1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(tableLayoutPanel1);
            groupControl1.Location = new Point(651, 85);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(385, 325);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Araç Resimleri";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(peK4, 1, 1);
            tableLayoutPanel1.Controls.Add(peK3, 0, 1);
            tableLayoutPanel1.Controls.Add(peK2, 1, 0);
            tableLayoutPanel1.Controls.Add(peK1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(381, 300);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // peK4
            // 
            peK4.BackgroundImageLayout = ImageLayout.Stretch;
            peK4.Dock = DockStyle.Fill;
            peK4.Location = new Point(193, 153);
            peK4.Name = "peK4";
            peK4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peK4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            peK4.Size = new Size(185, 144);
            peK4.TabIndex = 6;
            // 
            // peK3
            // 
            peK3.BackgroundImageLayout = ImageLayout.Stretch;
            peK3.Dock = DockStyle.Fill;
            peK3.Location = new Point(3, 153);
            peK3.Name = "peK3";
            peK3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peK3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            peK3.Size = new Size(184, 144);
            peK3.TabIndex = 5;
            // 
            // peK2
            // 
            peK2.BackgroundImageLayout = ImageLayout.Stretch;
            peK2.Dock = DockStyle.Fill;
            peK2.Location = new Point(193, 3);
            peK2.Name = "peK2";
            peK2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peK2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            peK2.Size = new Size(185, 144);
            peK2.TabIndex = 4;
            // 
            // peK1
            // 
            peK1.BackgroundImageLayout = ImageLayout.Stretch;
            peK1.Dock = DockStyle.Fill;
            peK1.Location = new Point(3, 3);
            peK1.Name = "peK1";
            peK1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            peK1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            peK1.Size = new Size(184, 144);
            peK1.TabIndex = 0;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(656, 547);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // FrmAracListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 546);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAracListesi";
            Text = "FrmAracListesi";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)peK4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peK3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peK2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peK1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit peK4;
        private DevExpress.XtraEditors.PictureEdit peK3;
        private DevExpress.XtraEditors.PictureEdit peK2;
        private DevExpress.XtraEditors.PictureEdit peK1;
    }
}