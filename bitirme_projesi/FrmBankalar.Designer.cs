namespace bitirme_projesi
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.Cmbİlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbİl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Bilgiler = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtHesapturu = new DevExpress.XtraEditors.TextEdit();
            this.TxtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.TxtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.TxtIban = new DevExpress.XtraEditors.TextEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbİlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbİl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bilgiler)).BeginInit();
            this.Bilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapturu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
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
            // Btn_guncelle
            // 
            this.Btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guncelle.ImageOptions.Image")));
            this.Btn_guncelle.Location = new System.Drawing.Point(186, 408);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(104, 38);
            this.Btn_guncelle.TabIndex = 33;
            this.Btn_guncelle.Text = "GÜNCELLE";
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(84, 452);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(105, 38);
            this.Btn_Sil.TabIndex = 32;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(83, 408);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(106, 38);
            this.Btn_Kaydet.TabIndex = 31;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Cmbİlce
            // 
            this.Cmbİlce.Location = new System.Drawing.Point(142, 122);
            this.Cmbİlce.Name = "Cmbİlce";
            this.Cmbİlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Cmbİlce.Properties.Appearance.Options.UseFont = true;
            this.Cmbİlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbİlce.Size = new System.Drawing.Size(148, 24);
            this.Cmbİlce.TabIndex = 3;
            // 
            // Cmbİl
            // 
            this.Cmbİl.Location = new System.Drawing.Point(142, 92);
            this.Cmbİl.Name = "Cmbİl";
            this.Cmbİl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Cmbİl.Properties.Appearance.Options.UseFont = true;
            this.Cmbİl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbİl.Size = new System.Drawing.Size(148, 24);
            this.Cmbİl.TabIndex = 2;
            this.Cmbİl.SelectedIndexChanged += new System.EventHandler(this.Cmbİl_SelectedIndexChanged);
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.MskTelefon.Location = new System.Drawing.Point(142, 272);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(148, 26);
            this.MskTelefon.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(73, 245);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 18);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "YETKİLİ:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(83, 310);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "TARİH:";
            // 
            // Bilgiler
            // 
            this.Bilgiler.Controls.Add(this.BtnTemizle);
            this.Bilgiler.Controls.Add(this.lookUpEdit1);
            this.Bilgiler.Controls.Add(this.MskTarih);
            this.Bilgiler.Controls.Add(this.labelControl12);
            this.Bilgiler.Controls.Add(this.TxtHesapturu);
            this.Bilgiler.Controls.Add(this.TxtYetkili);
            this.Bilgiler.Controls.Add(this.TxtHesapNo);
            this.Bilgiler.Controls.Add(this.TxtIban);
            this.Bilgiler.Controls.Add(this.Btn_guncelle);
            this.Bilgiler.Controls.Add(this.Btn_Sil);
            this.Bilgiler.Controls.Add(this.Btn_Kaydet);
            this.Bilgiler.Controls.Add(this.Cmbİlce);
            this.Bilgiler.Controls.Add(this.Cmbİl);
            this.Bilgiler.Controls.Add(this.MskTelefon);
            this.Bilgiler.Controls.Add(this.labelControl11);
            this.Bilgiler.Controls.Add(this.labelControl10);
            this.Bilgiler.Controls.Add(this.BtnGuncelle);
            this.Bilgiler.Controls.Add(this.labelControl9);
            this.Bilgiler.Controls.Add(this.labelControl8);
            this.Bilgiler.Controls.Add(this.labelControl7);
            this.Bilgiler.Controls.Add(this.labelControl6);
            this.Bilgiler.Controls.Add(this.TxtSube);
            this.Bilgiler.Controls.Add(this.labelControl5);
            this.Bilgiler.Controls.Add(this.labelControl3);
            this.Bilgiler.Controls.Add(this.labelControl4);
            this.Bilgiler.Controls.Add(this.TxtAd);
            this.Bilgiler.Controls.Add(this.labelControl2);
            this.Bilgiler.Controls.Add(this.TxtId);
            this.Bilgiler.Controls.Add(this.labelControl1);
            this.Bilgiler.Location = new System.Drawing.Point(1030, -4);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(340, 678);
            this.Bilgiler.TabIndex = 5;
            this.Bilgiler.Text = "Banka Bilgileri";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(186, 452);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(104, 38);
            this.BtnTemizle.TabIndex = 42;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(142, 367);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Bir firma seçin";
            this.lookUpEdit1.Size = new System.Drawing.Size(148, 24);
            this.lookUpEdit1.TabIndex = 11;
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.MskTarih.Location = new System.Drawing.Point(142, 302);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(148, 26);
            this.MskTarih.TabIndex = 9;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(44, 340);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(92, 18);
            this.labelControl12.TabIndex = 39;
            this.labelControl12.Text = "HESAP TÜRÜ:";
            // 
            // TxtHesapturu
            // 
            this.TxtHesapturu.Location = new System.Drawing.Point(142, 334);
            this.TxtHesapturu.Name = "TxtHesapturu";
            this.TxtHesapturu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtHesapturu.Properties.Appearance.Options.UseFont = true;
            this.TxtHesapturu.Size = new System.Drawing.Size(148, 24);
            this.TxtHesapturu.TabIndex = 10;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(142, 242);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtYetkili.Properties.Appearance.Options.UseFont = true;
            this.TxtYetkili.Size = new System.Drawing.Size(148, 24);
            this.TxtYetkili.TabIndex = 7;
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.Location = new System.Drawing.Point(142, 212);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtHesapNo.Properties.Appearance.Options.UseFont = true;
            this.TxtHesapNo.Size = new System.Drawing.Size(148, 24);
            this.TxtHesapNo.TabIndex = 6;
            // 
            // TxtIban
            // 
            this.TxtIban.Location = new System.Drawing.Point(142, 182);
            this.TxtIban.Name = "TxtIban";
            this.TxtIban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtIban.Properties.Appearance.Options.UseFont = true;
            this.TxtIban.Size = new System.Drawing.Size(148, 24);
            this.TxtIban.TabIndex = 5;
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
            this.labelControl9.Location = new System.Drawing.Point(96, 155);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "ŞUBE:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(62, 215);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "HESAP NO:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(101, 125);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "İLÇE:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(118, 95);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "İL:";
            // 
            // TxtSube
            // 
            this.TxtSube.Location = new System.Drawing.Point(142, 152);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtSube.Properties.Appearance.Options.UseFont = true;
            this.TxtSube.Size = new System.Drawing.Size(148, 24);
            this.TxtSube.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(96, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "IBAN:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 275);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "TELEFON:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(81, 370);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "FİRMA:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(142, 62);
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
            this.labelControl2.Location = new System.Drawing.Point(53, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "BANKA ADI:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(142, 32);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(148, 24);
            this.TxtId.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(115, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 670);
            this.Controls.Add(this.Bilgiler);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbİlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbİl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bilgiler)).EndInit();
            this.Bilgiler.ResumeLayout(false);
            this.Bilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapturu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbİlce;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbİl;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl Bilgiler;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSube;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtHesapturu;
        private DevExpress.XtraEditors.TextEdit TxtYetkili;
        private DevExpress.XtraEditors.TextEdit TxtHesapNo;
        private DevExpress.XtraEditors.TextEdit TxtIban;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}