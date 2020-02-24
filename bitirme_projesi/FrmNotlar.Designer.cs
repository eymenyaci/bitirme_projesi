namespace bitirme_projesi
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.Bilgiler = new DevExpress.XtraEditors.GroupControl();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtHitap = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bilgiler)).BeginInit();
            this.Bilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.SkyBlue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.SkyBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, -4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1023, 678);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // RchDetay
            // 
            this.RchDetay.Location = new System.Drawing.Point(110, 222);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(204, 174);
            this.RchDetay.TabIndex = 34;
            this.RchDetay.Text = "";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(210, 412);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(104, 38);
            this.btn_guncelle.TabIndex = 33;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sil.ImageOptions.Image")));
            this.Btn_sil.Location = new System.Drawing.Point(108, 456);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(105, 38);
            this.Btn_sil.TabIndex = 32;
            this.Btn_sil.Text = "SİL";
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_kaydet
            // 
            this.Btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_kaydet.ImageOptions.Image")));
            this.Btn_kaydet.Location = new System.Drawing.Point(110, 412);
            this.Btn_kaydet.Name = "Btn_kaydet";
            this.Btn_kaydet.Size = new System.Drawing.Size(106, 38);
            this.Btn_kaydet.TabIndex = 31;
            this.Btn_kaydet.Text = "KAYDET";
            this.Btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.MskSaat.Location = new System.Drawing.Point(110, 98);
            this.MskSaat.Mask = "90:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(204, 26);
            this.MskSaat.TabIndex = 27;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.MskTarih.Location = new System.Drawing.Point(110, 62);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(204, 26);
            this.MskTarih.TabIndex = 26;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtOlusturan
            // 
            this.TxtOlusturan.Location = new System.Drawing.Point(110, 160);
            this.TxtOlusturan.Name = "TxtOlusturan";
            this.TxtOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtOlusturan.Properties.Appearance.Options.UseFont = true;
            this.TxtOlusturan.Size = new System.Drawing.Size(204, 24);
            this.TxtOlusturan.TabIndex = 23;
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.btn_temizle);
            this.Bilgiler.Controls.Add(this.TxtHitap);
            this.Bilgiler.Controls.Add(this.RchDetay);
            this.Bilgiler.Controls.Add(this.btn_guncelle);
            this.Bilgiler.Controls.Add(this.Btn_sil);
            this.Bilgiler.Controls.Add(this.Btn_kaydet);
            this.Bilgiler.Controls.Add(this.MskSaat);
            this.Bilgiler.Controls.Add(this.MskTarih);
            this.Bilgiler.Controls.Add(this.TxtOlusturan);
            this.Bilgiler.Controls.Add(this.BtnGuncelle);
            this.Bilgiler.Controls.Add(this.labelControl9);
            this.Bilgiler.Controls.Add(this.labelControl8);
            this.Bilgiler.Controls.Add(this.TxtBaslik);
            this.Bilgiler.Controls.Add(this.labelControl5);
            this.Bilgiler.Controls.Add(this.labelControl3);
            this.Bilgiler.Controls.Add(this.labelControl4);
            this.Bilgiler.Controls.Add(this.labelControl2);
            this.Bilgiler.Controls.Add(this.TxtId);
            this.Bilgiler.Controls.Add(this.labelControl1);
            this.Bilgiler.Location = new System.Drawing.Point(1030, -4);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(340, 678);
            this.Bilgiler.TabIndex = 5;
            this.Bilgiler.Text = "Müşteri Bilgileri";
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.ImageOptions.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(210, 456);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(104, 38);
            this.btn_temizle.TabIndex = 43;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // TxtHitap
            // 
            this.TxtHitap.Location = new System.Drawing.Point(110, 192);
            this.TxtHitap.Name = "TxtHitap";
            this.TxtHitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtHitap.Properties.Appearance.Options.UseFont = true;
            this.TxtHitap.Size = new System.Drawing.Size(204, 24);
            this.TxtHitap.TabIndex = 35;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(143, 712);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(207, 57);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "GÜNCELLE";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(46, 195);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "HİTAP:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 228);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "DETAY:";
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(110, 130);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtBaslik.Properties.Appearance.Options.UseFont = true;
            this.TxtBaslik.Size = new System.Drawing.Size(204, 24);
            this.TxtBaslik.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "OLUŞTURAN:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "BAŞLIK:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(53, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "SAAT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "TARİH:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(110, 32);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(204, 24);
            this.TxtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 670);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bilgiler)).EndInit();
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_sil;
        private DevExpress.XtraEditors.SimpleButton Btn_kaydet;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.TextEdit TxtOlusturan;
        private DevExpress.XtraEditors.GroupControl Bilgiler;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtHitap;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
    }
}