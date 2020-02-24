namespace bitirme_projesi
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.NudAdet = new System.Windows.Forms.NumericUpDown();
            this.TxtAlis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskYil = new System.Windows.Forms.MaskedTextBox();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1021, 558);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.SkyBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_temizle);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtSatis);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.NudAdet);
            this.groupControl1.Controls.Add(this.TxtAlis);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtModel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtMarka);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.MskYil);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1029, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(340, 558);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.ImageOptions.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(175, 433);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(104, 38);
            this.btn_temizle.TabIndex = 44;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(175, 389);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(104, 38);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(73, 433);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(105, 38);
            this.BtnSil.TabIndex = 20;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(72, 389);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(106, 38);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchDetay
            // 
            this.RchDetay.Location = new System.Drawing.Point(131, 287);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(148, 96);
            this.RchDetay.TabIndex = 8;
            this.RchDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(42, 230);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "ALIŞ FİYAT:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(97, 166);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "YIL:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(73, 290);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "DETAY:";
            // 
            // TxtSatis
            // 
            this.TxtSatis.Location = new System.Drawing.Point(131, 257);
            this.TxtSatis.Name = "TxtSatis";
            this.TxtSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtSatis.Properties.Appearance.Options.UseFont = true;
            this.TxtSatis.Size = new System.Drawing.Size(148, 24);
            this.TxtSatis.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(31, 257);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "SATIŞ FİYAT:";
            // 
            // NudAdet
            // 
            this.NudAdet.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.NudAdet.Location = new System.Drawing.Point(131, 198);
            this.NudAdet.Name = "NudAdet";
            this.NudAdet.Size = new System.Drawing.Size(148, 26);
            this.NudAdet.TabIndex = 5;
            // 
            // TxtAlis
            // 
            this.TxtAlis.Location = new System.Drawing.Point(131, 227);
            this.TxtAlis.Name = "TxtAlis";
            this.TxtAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtAlis.Properties.Appearance.Options.UseFont = true;
            this.TxtAlis.Size = new System.Drawing.Size(148, 24);
            this.TxtAlis.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(83, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "ADET:";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(131, 133);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtModel.Properties.Appearance.Options.UseFont = true;
            this.TxtModel.Size = new System.Drawing.Size(148, 24);
            this.TxtModel.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(72, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "MODEL:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(131, 98);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtMarka.Properties.Appearance.Options.UseFont = true;
            this.TxtMarka.Size = new System.Drawing.Size(148, 24);
            this.TxtMarka.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "MARKA:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(131, 68);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(148, 24);
            this.TxtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(101, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AD:";
            // 
            // MskYil
            // 
            this.MskYil.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.MskYil.Location = new System.Drawing.Point(131, 163);
            this.MskYil.Mask = "0000";
            this.MskYil.Name = "MskYil";
            this.MskYil.Size = new System.Drawing.Size(148, 26);
            this.MskYil.TabIndex = 4;
            this.MskYil.ValidatingType = typeof(int);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(131, 33);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(148, 24);
            this.TxtId.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(104, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUrunler_FormClosed);
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtSatis;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private DevExpress.XtraEditors.TextEdit TxtAlis;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskYil;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
    }
}