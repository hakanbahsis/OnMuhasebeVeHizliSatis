namespace Satis.BackOffice.Ödeme_Türü
{
    partial class FrmOdemeTuruHareket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuruHareket));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.kasaHareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewKasaHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlKasaBakiye = new DevExpress.XtraGrid.GridControl();
            this.kasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewKasaBakiye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKasaKodu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridContGenelToplam = new DevExpress.XtraGrid.GridControl();
            this.gridGenelToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKasaBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1262, 55);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Ödeme Türü Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 513);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1262, 80);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1150, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 47);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(128, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 47);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.Appearance.Options.UseTextOptions = true;
            this.btnGuncelle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 28);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 47);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlKasaHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1262, 458);
            this.splitContainerControl1.SplitterPosition = 281;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlKasaHareket
            // 
            this.gridControlKasaHareket.DataSource = this.kasaHareketBindingSource;
            this.gridControlKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridControlKasaHareket.MainView = this.gridViewKasaHareket;
            this.gridControlKasaHareket.Name = "gridControlKasaHareket";
            this.gridControlKasaHareket.Size = new System.Drawing.Size(1262, 281);
            this.gridControlKasaHareket.TabIndex = 0;
            this.gridControlKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKasaHareket});
            // 
            // kasaHareketBindingSource
            // 
            this.kasaHareketBindingSource.DataSource = typeof(Satis.Entities.Tables.KasaHareket);
            // 
            // gridViewKasaHareket
            // 
            this.gridViewKasaHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFisKodu,
            this.colHareket,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colCariKodu,
            this.colCariAdi,
            this.colTarih,
            this.colTutar,
            this.colAciklama});
            this.gridViewKasaHareket.GridControl = this.gridControlKasaHareket;
            this.gridViewKasaHareket.Name = "gridViewKasaHareket";
            this.gridViewKasaHareket.OptionsView.ShowGroupPanel = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 100;
            // 
            // colHareket
            // 
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            this.colHareket.Width = 142;
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.Visible = true;
            this.colKasaKodu.VisibleIndex = 2;
            this.colKasaKodu.Width = 89;
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.Visible = true;
            this.colKasaAdi.VisibleIndex = 3;
            this.colKasaAdi.Width = 150;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 4;
            this.colCariKodu.Width = 118;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 5;
            this.colCariAdi.Width = 157;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 6;
            this.colTarih.Width = 157;
            // 
            // colTutar
            // 
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 8;
            this.colTutar.Width = 146;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 183;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1262, 171);
            this.splitContainerControl2.SplitterPosition = 627;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlKasaBakiye);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(627, 171);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Kasalara Göre Bakiye Toplamları";
            // 
            // gridControlKasaBakiye
            // 
            this.gridControlKasaBakiye.DataSource = this.kasaBindingSource;
            this.gridControlKasaBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKasaBakiye.Location = new System.Drawing.Point(2, 25);
            this.gridControlKasaBakiye.MainView = this.gridViewKasaBakiye;
            this.gridControlKasaBakiye.Name = "gridControlKasaBakiye";
            this.gridControlKasaBakiye.Size = new System.Drawing.Size(623, 144);
            this.gridControlKasaBakiye.TabIndex = 0;
            this.gridControlKasaBakiye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKasaBakiye});
            // 
            // kasaBindingSource
            // 
            this.kasaBindingSource.DataSource = typeof(Satis.Entities.Tables.Kasa);
            // 
            // gridViewKasaBakiye
            // 
            this.gridViewKasaBakiye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKasaKodu1,
            this.colKasaAdi1,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.gridViewKasaBakiye.GridControl = this.gridControlKasaBakiye;
            this.gridViewKasaBakiye.Name = "gridViewKasaBakiye";
            this.gridViewKasaBakiye.OptionsView.ShowGroupPanel = false;
            // 
            // colKasaKodu1
            // 
            this.colKasaKodu1.Caption = "Kasa Kodu";
            this.colKasaKodu1.FieldName = "KasaKodu";
            this.colKasaKodu1.Name = "colKasaKodu1";
            this.colKasaKodu1.Visible = true;
            this.colKasaKodu1.VisibleIndex = 0;
            // 
            // colKasaAdi1
            // 
            this.colKasaAdi1.Caption = "Kasa Adı";
            this.colKasaAdi1.FieldName = "KasaAdi";
            this.colKasaAdi1.Name = "colKasaAdi1";
            this.colKasaAdi1.Visible = true;
            this.colKasaAdi1.VisibleIndex = 1;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.Visible = true;
            this.colKasaGiris.VisibleIndex = 2;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.Visible = true;
            this.colKasaCikis.VisibleIndex = 3;
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridContGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(629, 171);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Genel Toplamlar";
            // 
            // gridContGenelToplam
            // 
            this.gridContGenelToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContGenelToplam.Location = new System.Drawing.Point(2, 25);
            this.gridContGenelToplam.MainView = this.gridGenelToplam;
            this.gridContGenelToplam.Name = "gridContGenelToplam";
            this.gridContGenelToplam.Size = new System.Drawing.Size(625, 144);
            this.gridContGenelToplam.TabIndex = 2;
            this.gridContGenelToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGenelToplam});
            // 
            // gridGenelToplam
            // 
            this.gridGenelToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIslem,
            this.colKayitSayisi,
            this.colToplam});
            this.gridGenelToplam.GridControl = this.gridContGenelToplam;
            this.gridGenelToplam.Name = "gridGenelToplam";
            this.gridGenelToplam.OptionsView.ShowGroupPanel = false;
            // 
            // colIslem
            // 
            this.colIslem.Caption = "İşlem";
            this.colIslem.FieldName = "Bilgi";
            this.colIslem.Name = "colIslem";
            this.colIslem.OptionsColumn.AllowEdit = false;
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 0;
            // 
            // colKayitSayisi
            // 
            this.colKayitSayisi.Caption = "Kayıt Sayısı";
            this.colKayitSayisi.FieldName = "KayitSayisi";
            this.colKayitSayisi.Name = "colKayitSayisi";
            this.colKayitSayisi.OptionsColumn.AllowEdit = false;
            this.colKayitSayisi.Visible = true;
            this.colKayitSayisi.VisibleIndex = 1;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam";
            this.colToplam.FieldName = "Toplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowEdit = false;
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 2;
            // 
            // FrmOdemeTuruHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 593);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmOdemeTuruHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOdemeTuruHareket";
            this.Load += new System.EventHandler(this.FrmOdemeTuruHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKasaBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKasaBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenelToplam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridContGenelToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraGrid.GridControl gridControlKasaBakiye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKasaBakiye;
        private System.Windows.Forms.BindingSource kasaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu1;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colBakiye;
        private DevExpress.XtraGrid.GridControl gridControlKasaHareket;
        private System.Windows.Forms.BindingSource kasaHareketBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKasaHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private System.Windows.Forms.ImageList ımageList1;
    }
}