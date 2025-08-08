namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.KisiEditFormTable
{
    partial class ForTestTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colVeli = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryVeli = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIletisimTuru = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryAdres = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIletisimTuruAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIzinDurumu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIzinTarihi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSosyalMedyaPlatformuAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBaslik = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIlgili = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colUlkeKodu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colNumara = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colDahiliNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEPosta = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colKanallar = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKullaniciAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSosyalMedyaUrl = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSIPKullaniciAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSIPServer = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colWeb = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOncelik = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colVoipMi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colVarsayilanMi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAramaAktifMi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSmsAktifMi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colWhatsAppAktifMi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEmailAktifMi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAciklama = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.repositoryYakinlik = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(11, 95);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryYakinlik,
            this.repositoryAdres,
            this.repositoryVeli});
            this.grid.Size = new System.Drawing.Size(594, 253);
            this.grid.TabIndex = 6;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 20;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colVeli,
            this.colIletisimTuru,
            this.colBaslik,
            this.colUlkeKodu,
            this.colNumara,
            this.colDahiliNo,
            this.colEPosta,
            this.colKanallar,
            this.colKullaniciAdi,
            this.colSosyalMedyaUrl,
            this.colSIPKullaniciAdi,
            this.colSIPServer,
            this.colIlgili,
            this.colOncelik,
            this.colVoipMi,
            this.colVarsayilanMi,
            this.colAramaAktifMi,
            this.colSmsAktifMi,
            this.colWhatsAppAktifMi,
            this.colEmailAktifMi,
            this.colWeb,
            this.colAciklama,
            this.colSosyalMedyaPlatformuAdi,
            this.colIzinTarihi,
            this.colIzinDurumu,
            this.colIletisimTuruAdi});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "İletişim Bilgileri Seçiniz";
            this.tablo.StatusBarKisaYol = "Shift+Insert";
            this.tablo.StatusBarKisaYolAciklama = "Seçim Yap";
            this.tablo.ViewCaption = "İletişim Bilgileri";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colVeli);
            this.gridBand1.Columns.Add(this.colIletisimTuru);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 155;
            // 
            // colVeli
            // 
            this.colVeli.Caption = "Veli";
            this.colVeli.ColumnEdit = this.repositoryVeli;
            this.colVeli.FieldName = "Veli";
            this.colVeli.Name = "colVeli";
            this.colVeli.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVeli.OptionsFilter.AllowAutoFilter = false;
            this.colVeli.OptionsFilter.AllowFilter = false;
            this.colVeli.StatusBarAciklama = "Kişi Öğrenci Velisi ise İşaretleyiniz.";
            this.colVeli.StatusBarKisaYol = "Space :";
            this.colVeli.StatusBarKisaYolAciklama = "İşaretle";
            this.colVeli.Visible = true;
            this.colVeli.Width = 65;
            // 
            // repositoryVeli
            // 
            this.repositoryVeli.AutoHeight = false;
            this.repositoryVeli.Name = "repositoryVeli";
            // 
            // colIletisimTuru
            // 
            this.colIletisimTuru.Caption = "İletişim Türü";
            this.colIletisimTuru.ColumnEdit = this.repositoryAdres;
            this.colIletisimTuru.FieldName = "IletisimTuru";
            this.colIletisimTuru.Name = "colIletisimTuru";
            this.colIletisimTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIletisimTuru.OptionsFilter.AllowAutoFilter = false;
            this.colIletisimTuru.OptionsFilter.AllowFilter = false;
            this.colIletisimTuru.StatusBarAciklama = "Adres Türü Seçiniz";
            this.colIletisimTuru.StatusBarKisaYol = "F4 :";
            this.colIletisimTuru.StatusBarKisaYolAciklama = "Seçim Yap";
            this.colIletisimTuru.Visible = true;
            this.colIletisimTuru.Width = 90;
            // 
            // repositoryAdres
            // 
            this.repositoryAdres.AutoHeight = false;
            this.repositoryAdres.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryAdres.Name = "repositoryAdres";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Kimlik Bilgileri";
            this.gridBand2.Columns.Add(this.colIletisimTuruAdi);
            this.gridBand2.Columns.Add(this.colIzinDurumu);
            this.gridBand2.Columns.Add(this.colIzinTarihi);
            this.gridBand2.Columns.Add(this.colSosyalMedyaPlatformuAdi);
            this.gridBand2.Columns.Add(this.colBaslik);
            this.gridBand2.Columns.Add(this.colIlgili);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 627;
            // 
            // colIletisimTuruAdi
            // 
            this.colIletisimTuruAdi.Caption = "İletisim Türü";
            this.colIletisimTuruAdi.FieldName = "IletisimTuruAdi";
            this.colIletisimTuruAdi.Name = "colIletisimTuruAdi";
            this.colIletisimTuruAdi.OptionsColumn.AllowEdit = false;
            this.colIletisimTuruAdi.StatusBarAciklama = null;
            this.colIletisimTuruAdi.StatusBarKisaYol = null;
            this.colIletisimTuruAdi.StatusBarKisaYolAciklama = null;
            this.colIletisimTuruAdi.Visible = true;
            // 
            // colIzinDurumu
            // 
            this.colIzinDurumu.Caption = "İzin Durumu";
            this.colIzinDurumu.FieldName = "IzinDurumu";
            this.colIzinDurumu.Name = "colIzinDurumu";
            this.colIzinDurumu.OptionsColumn.AllowEdit = false;
            this.colIzinDurumu.StatusBarAciklama = null;
            this.colIzinDurumu.StatusBarKisaYol = null;
            this.colIzinDurumu.StatusBarKisaYolAciklama = null;
            this.colIzinDurumu.Visible = true;
            // 
            // colIzinTarihi
            // 
            this.colIzinTarihi.Caption = "İzinTarihi";
            this.colIzinTarihi.FieldName = "IzinTarihi";
            this.colIzinTarihi.Name = "colIzinTarihi";
            this.colIzinTarihi.OptionsColumn.AllowEdit = false;
            this.colIzinTarihi.StatusBarAciklama = null;
            this.colIzinTarihi.StatusBarKisaYol = null;
            this.colIzinTarihi.StatusBarKisaYolAciklama = null;
            this.colIzinTarihi.Visible = true;
            // 
            // colSosyalMedyaPlatformuAdi
            // 
            this.colSosyalMedyaPlatformuAdi.Caption = "Sosyal Medya Platformu ";
            this.colSosyalMedyaPlatformuAdi.FieldName = "SosyalMedyaPlatformuAdi";
            this.colSosyalMedyaPlatformuAdi.Name = "colSosyalMedyaPlatformuAdi";
            this.colSosyalMedyaPlatformuAdi.OptionsColumn.AllowEdit = false;
            this.colSosyalMedyaPlatformuAdi.StatusBarAciklama = null;
            this.colSosyalMedyaPlatformuAdi.StatusBarKisaYol = null;
            this.colSosyalMedyaPlatformuAdi.StatusBarKisaYolAciklama = null;
            this.colSosyalMedyaPlatformuAdi.Visible = true;
            this.colSosyalMedyaPlatformuAdi.Width = 204;
            // 
            // colBaslik
            // 
            this.colBaslik.Caption = "Başlık";
            this.colBaslik.FieldName = "Baslik";
            this.colBaslik.Name = "colBaslik";
            this.colBaslik.OptionsColumn.AllowEdit = false;
            this.colBaslik.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBaslik.OptionsFilter.AllowAutoFilter = false;
            this.colBaslik.OptionsFilter.AllowFilter = false;
            this.colBaslik.StatusBarAciklama = null;
            this.colBaslik.StatusBarKisaYol = null;
            this.colBaslik.StatusBarKisaYolAciklama = null;
            this.colBaslik.Visible = true;
            this.colBaslik.Width = 91;
            // 
            // colIlgili
            // 
            this.colIlgili.Caption = "İlgili";
            this.colIlgili.FieldName = "Ilgili";
            this.colIlgili.Name = "colIlgili";
            this.colIlgili.OptionsColumn.AllowEdit = false;
            this.colIlgili.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIlgili.OptionsFilter.AllowAutoFilter = false;
            this.colIlgili.OptionsFilter.AllowFilter = false;
            this.colIlgili.StatusBarAciklama = null;
            this.colIlgili.StatusBarKisaYol = null;
            this.colIlgili.StatusBarKisaYolAciklama = null;
            this.colIlgili.Visible = true;
            this.colIlgili.Width = 107;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Telefon";
            this.gridBand3.Columns.Add(this.colUlkeKodu);
            this.gridBand3.Columns.Add(this.colNumara);
            this.gridBand3.Columns.Add(this.colDahiliNo);
            this.gridBand3.Columns.Add(this.colEPosta);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 362;
            // 
            // colUlkeKodu
            // 
            this.colUlkeKodu.Caption = "Ülke Kodu";
            this.colUlkeKodu.FieldName = "UlkeKodu";
            this.colUlkeKodu.Name = "colUlkeKodu";
            this.colUlkeKodu.OptionsColumn.AllowEdit = false;
            this.colUlkeKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUlkeKodu.OptionsFilter.AllowAutoFilter = false;
            this.colUlkeKodu.OptionsFilter.AllowFilter = false;
            this.colUlkeKodu.StatusBarAciklama = null;
            this.colUlkeKodu.StatusBarKisaYol = null;
            this.colUlkeKodu.StatusBarKisaYolAciklama = null;
            this.colUlkeKodu.Visible = true;
            this.colUlkeKodu.Width = 100;
            // 
            // colNumara
            // 
            this.colNumara.Caption = "Numara";
            this.colNumara.FieldName = "Numara";
            this.colNumara.Name = "colNumara";
            this.colNumara.OptionsColumn.AllowEdit = false;
            this.colNumara.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNumara.OptionsFilter.AllowAutoFilter = false;
            this.colNumara.OptionsFilter.AllowFilter = false;
            this.colNumara.StatusBarAciklama = null;
            this.colNumara.StatusBarKisaYol = null;
            this.colNumara.StatusBarKisaYolAciklama = null;
            this.colNumara.Visible = true;
            this.colNumara.Width = 91;
            // 
            // colDahiliNo
            // 
            this.colDahiliNo.Caption = "Dahili";
            this.colDahiliNo.FieldName = "DahiliNo";
            this.colDahiliNo.Name = "colDahiliNo";
            this.colDahiliNo.OptionsColumn.AllowEdit = false;
            this.colDahiliNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDahiliNo.OptionsFilter.AllowAutoFilter = false;
            this.colDahiliNo.OptionsFilter.AllowFilter = false;
            this.colDahiliNo.StatusBarAciklama = null;
            this.colDahiliNo.StatusBarKisaYol = null;
            this.colDahiliNo.StatusBarKisaYolAciklama = null;
            this.colDahiliNo.Visible = true;
            this.colDahiliNo.Width = 100;
            // 
            // colEPosta
            // 
            this.colEPosta.Caption = "E-Posta";
            this.colEPosta.FieldName = "EPosta";
            this.colEPosta.Name = "colEPosta";
            this.colEPosta.OptionsColumn.AllowEdit = false;
            this.colEPosta.StatusBarAciklama = null;
            this.colEPosta.StatusBarKisaYol = null;
            this.colEPosta.StatusBarKisaYolAciklama = null;
            this.colEPosta.Visible = true;
            this.colEPosta.Width = 71;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Bilişim";
            this.gridBand4.Columns.Add(this.colKanallar);
            this.gridBand4.Columns.Add(this.colKullaniciAdi);
            this.gridBand4.Columns.Add(this.colSosyalMedyaUrl);
            this.gridBand4.Columns.Add(this.colSIPKullaniciAdi);
            this.gridBand4.Columns.Add(this.colSIPServer);
            this.gridBand4.Columns.Add(this.colWeb);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 553;
            // 
            // colKanallar
            // 
            this.colKanallar.Caption = "Kanallar";
            this.colKanallar.FieldName = "Kanallar";
            this.colKanallar.Name = "colKanallar";
            this.colKanallar.OptionsColumn.AllowEdit = false;
            this.colKanallar.StatusBarAciklama = null;
            this.colKanallar.StatusBarKisaYol = null;
            this.colKanallar.StatusBarKisaYolAciklama = null;
            this.colKanallar.Visible = true;
            this.colKanallar.Width = 95;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "Kullanıcı Adı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.StatusBarAciklama = null;
            this.colKullaniciAdi.StatusBarKisaYol = null;
            this.colKullaniciAdi.StatusBarKisaYolAciklama = null;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.Width = 95;
            // 
            // colSosyalMedyaUrl
            // 
            this.colSosyalMedyaUrl.Caption = "URL";
            this.colSosyalMedyaUrl.FieldName = "SosyalMedyaUrl";
            this.colSosyalMedyaUrl.Name = "colSosyalMedyaUrl";
            this.colSosyalMedyaUrl.OptionsColumn.AllowEdit = false;
            this.colSosyalMedyaUrl.StatusBarAciklama = null;
            this.colSosyalMedyaUrl.StatusBarKisaYol = null;
            this.colSosyalMedyaUrl.StatusBarKisaYolAciklama = null;
            this.colSosyalMedyaUrl.Visible = true;
            this.colSosyalMedyaUrl.Width = 95;
            // 
            // colSIPKullaniciAdi
            // 
            this.colSIPKullaniciAdi.Caption = "SİP Kullanıcı Adı";
            this.colSIPKullaniciAdi.FieldName = "SIPKullaniciAdi";
            this.colSIPKullaniciAdi.Name = "colSIPKullaniciAdi";
            this.colSIPKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colSIPKullaniciAdi.StatusBarAciklama = null;
            this.colSIPKullaniciAdi.StatusBarKisaYol = null;
            this.colSIPKullaniciAdi.StatusBarKisaYolAciklama = null;
            this.colSIPKullaniciAdi.Visible = true;
            this.colSIPKullaniciAdi.Width = 95;
            // 
            // colSIPServer
            // 
            this.colSIPServer.Caption = "SİP Server";
            this.colSIPServer.FieldName = "SIPServer";
            this.colSIPServer.Name = "colSIPServer";
            this.colSIPServer.OptionsColumn.AllowEdit = false;
            this.colSIPServer.StatusBarAciklama = null;
            this.colSIPServer.StatusBarKisaYol = null;
            this.colSIPServer.StatusBarKisaYolAciklama = null;
            this.colSIPServer.Visible = true;
            this.colSIPServer.Width = 98;
            // 
            // colWeb
            // 
            this.colWeb.Caption = "Web";
            this.colWeb.FieldName = "Web";
            this.colWeb.Name = "colWeb";
            this.colWeb.OptionsColumn.AllowEdit = false;
            this.colWeb.StatusBarAciklama = null;
            this.colWeb.StatusBarKisaYol = null;
            this.colWeb.StatusBarKisaYolAciklama = null;
            this.colWeb.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Ek Bilgiler";
            this.gridBand5.Columns.Add(this.colOncelik);
            this.gridBand5.Columns.Add(this.colVoipMi);
            this.gridBand5.Columns.Add(this.colVarsayilanMi);
            this.gridBand5.Columns.Add(this.colAramaAktifMi);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 353;
            // 
            // colOncelik
            // 
            this.colOncelik.Caption = "Öncelik";
            this.colOncelik.FieldName = "Oncelik";
            this.colOncelik.Name = "colOncelik";
            this.colOncelik.OptionsColumn.AllowEdit = false;
            this.colOncelik.StatusBarAciklama = null;
            this.colOncelik.StatusBarKisaYol = null;
            this.colOncelik.StatusBarKisaYolAciklama = null;
            this.colOncelik.Visible = true;
            this.colOncelik.Width = 88;
            // 
            // colVoipMi
            // 
            this.colVoipMi.Caption = "Voip";
            this.colVoipMi.FieldName = "VoipMi";
            this.colVoipMi.Name = "colVoipMi";
            this.colVoipMi.OptionsColumn.AllowEdit = false;
            this.colVoipMi.StatusBarAciklama = null;
            this.colVoipMi.StatusBarKisaYol = null;
            this.colVoipMi.StatusBarKisaYolAciklama = null;
            this.colVoipMi.Visible = true;
            this.colVoipMi.Width = 88;
            // 
            // colVarsayilanMi
            // 
            this.colVarsayilanMi.Caption = "Varsayılan";
            this.colVarsayilanMi.FieldName = "VarsayilanMi";
            this.colVarsayilanMi.Name = "colVarsayilanMi";
            this.colVarsayilanMi.OptionsColumn.AllowEdit = false;
            this.colVarsayilanMi.StatusBarAciklama = null;
            this.colVarsayilanMi.StatusBarKisaYol = null;
            this.colVarsayilanMi.StatusBarKisaYolAciklama = null;
            this.colVarsayilanMi.Visible = true;
            this.colVarsayilanMi.Width = 88;
            // 
            // colAramaAktifMi
            // 
            this.colAramaAktifMi.Caption = "Arama Durumu";
            this.colAramaAktifMi.FieldName = "AramaAktifMi";
            this.colAramaAktifMi.Name = "colAramaAktifMi";
            this.colAramaAktifMi.OptionsColumn.AllowEdit = false;
            this.colAramaAktifMi.StatusBarAciklama = null;
            this.colAramaAktifMi.StatusBarKisaYol = null;
            this.colAramaAktifMi.StatusBarKisaYolAciklama = null;
            this.colAramaAktifMi.Visible = true;
            this.colAramaAktifMi.Width = 89;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Çalıştığı Veya Sahibi Olduğu İşyeri Bilgisi";
            this.gridBand6.Columns.Add(this.colSmsAktifMi);
            this.gridBand6.Columns.Add(this.colWhatsAppAktifMi);
            this.gridBand6.Columns.Add(this.colEmailAktifMi);
            this.gridBand6.Columns.Add(this.colAciklama);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 394;
            // 
            // colSmsAktifMi
            // 
            this.colSmsAktifMi.Caption = "SMS Durumu";
            this.colSmsAktifMi.FieldName = "SmsAktifMi";
            this.colSmsAktifMi.Name = "colSmsAktifMi";
            this.colSmsAktifMi.OptionsColumn.AllowEdit = false;
            this.colSmsAktifMi.StatusBarAciklama = null;
            this.colSmsAktifMi.StatusBarKisaYol = null;
            this.colSmsAktifMi.StatusBarKisaYolAciklama = null;
            this.colSmsAktifMi.Visible = true;
            this.colSmsAktifMi.Width = 110;
            // 
            // colWhatsAppAktifMi
            // 
            this.colWhatsAppAktifMi.Caption = "WhatsApp Durumu";
            this.colWhatsAppAktifMi.FieldName = "WhatsAppAktifMi";
            this.colWhatsAppAktifMi.Name = "colWhatsAppAktifMi";
            this.colWhatsAppAktifMi.OptionsColumn.AllowEdit = false;
            this.colWhatsAppAktifMi.StatusBarAciklama = null;
            this.colWhatsAppAktifMi.StatusBarKisaYol = null;
            this.colWhatsAppAktifMi.StatusBarKisaYolAciklama = null;
            this.colWhatsAppAktifMi.Visible = true;
            this.colWhatsAppAktifMi.Width = 110;
            // 
            // colEmailAktifMi
            // 
            this.colEmailAktifMi.Caption = "Email Durumu";
            this.colEmailAktifMi.FieldName = "EmailAktifMi";
            this.colEmailAktifMi.Name = "colEmailAktifMi";
            this.colEmailAktifMi.OptionsColumn.AllowEdit = false;
            this.colEmailAktifMi.StatusBarAciklama = null;
            this.colEmailAktifMi.StatusBarKisaYol = null;
            this.colEmailAktifMi.StatusBarKisaYolAciklama = null;
            this.colEmailAktifMi.Visible = true;
            this.colEmailAktifMi.Width = 99;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Visible = true;
            // 
            // repositoryYakinlik
            // 
            this.repositoryYakinlik.AutoHeight = false;
            this.repositoryYakinlik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryYakinlik.Name = "repositoryYakinlik";
            this.repositoryYakinlik.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ForTestTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "ForTestTable";
            this.Size = new System.Drawing.Size(617, 443);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryVeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryYakinlik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private Grid.MyBandedGridColumn colVeli;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryVeli;
        private Grid.MyBandedGridColumn colIletisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryAdres;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private Grid.MyBandedGridColumn colIletisimTuruAdi;
        private Grid.MyBandedGridColumn colIzinDurumu;
        private Grid.MyBandedGridColumn colIzinTarihi;
        private Grid.MyBandedGridColumn colSosyalMedyaPlatformuAdi;
        private Grid.MyBandedGridColumn colBaslik;
        private Grid.MyBandedGridColumn colIlgili;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private Grid.MyBandedGridColumn colUlkeKodu;
        private Grid.MyBandedGridColumn colNumara;
        private Grid.MyBandedGridColumn colDahiliNo;
        private Grid.MyBandedGridColumn colEPosta;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private Grid.MyBandedGridColumn colKanallar;
        private Grid.MyBandedGridColumn colKullaniciAdi;
        private Grid.MyBandedGridColumn colSosyalMedyaUrl;
        private Grid.MyBandedGridColumn colSIPKullaniciAdi;
        private Grid.MyBandedGridColumn colSIPServer;
        private Grid.MyBandedGridColumn colWeb;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private Grid.MyBandedGridColumn colOncelik;
        private Grid.MyBandedGridColumn colVoipMi;
        private Grid.MyBandedGridColumn colVarsayilanMi;
        private Grid.MyBandedGridColumn colAramaAktifMi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private Grid.MyBandedGridColumn colSmsAktifMi;
        private Grid.MyBandedGridColumn colWhatsAppAktifMi;
        private Grid.MyBandedGridColumn colEmailAktifMi;
        private Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryYakinlik;
    }
}
