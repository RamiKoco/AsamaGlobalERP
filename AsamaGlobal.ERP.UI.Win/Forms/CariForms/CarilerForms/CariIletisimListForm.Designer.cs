﻿namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms.CarilerForms
{
    partial class CariIletisimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariIletisimListForm));
            this.longNavigator = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridControl();
            this.tablo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridView();
            this.colIletisimTuru = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBaslik = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIzinDurumu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colUlkeKodu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colNumara = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colDahiliNo = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colArama = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colSms = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colWhatsapp = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEPBool = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEPosta = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod1Adi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colOzelKod2Adi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colWeb = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAciklama = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOncelik = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(1058, 135);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnYeniMakbuz
            // 
            this.btnYeniMakbuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.Image")));
            this.btnYeniMakbuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniMakbuz.ImageOptions.LargeImage")));
            // 
            // btnYeniRapor
            // 
            this.btnYeniRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.Image")));
            this.btnYeniRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniRapor.ImageOptions.LargeImage")));
            // 
            // barSubItem8
            // 
            this.barSubItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem8.ImageOptions.Image")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 434);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1058, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 135);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1058, 299);
            this.grid.TabIndex = 5;
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
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand5,
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colOncelik,
            this.colBaslik,
            this.colIletisimTuru,
            this.colIzinDurumu,
            this.colUlkeKodu,
            this.colNumara,
            this.colDahiliNo,
            this.colWeb,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
            this.colAciklama,
            this.colArama,
            this.colSms,
            this.colWhatsapp,
            this.colEPBool,
            this.colEPosta});
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
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = null;
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Cari İletişm Kartları";
            // 
            // colIletisimTuru
            // 
            this.colIletisimTuru.Caption = "İletişim Türü";
            this.colIletisimTuru.FieldName = "IletisimTuru";
            this.colIletisimTuru.Name = "colIletisimTuru";
            this.colIletisimTuru.OptionsColumn.AllowEdit = false;
            this.colIletisimTuru.StatusBarAciklama = null;
            this.colIletisimTuru.StatusBarKisaYol = null;
            this.colIletisimTuru.StatusBarKisaYolAciklama = null;
            this.colIletisimTuru.Visible = true;
            this.colIletisimTuru.Width = 99;
            // 
            // colBaslik
            // 
            this.colBaslik.Caption = "Başlık";
            this.colBaslik.FieldName = "Baslik";
            this.colBaslik.Name = "colBaslik";
            this.colBaslik.OptionsColumn.AllowEdit = false;
            this.colBaslik.StatusBarAciklama = null;
            this.colBaslik.StatusBarKisaYol = null;
            this.colBaslik.StatusBarKisaYolAciklama = null;
            this.colBaslik.Visible = true;
            this.colBaslik.Width = 97;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 97;
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
            this.colIzinDurumu.Width = 100;
            // 
            // colUlkeKodu
            // 
            this.colUlkeKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colUlkeKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUlkeKodu.Caption = "Ülke Kodu";
            this.colUlkeKodu.FieldName = "UlkeKodu";
            this.colUlkeKodu.Name = "colUlkeKodu";
            this.colUlkeKodu.OptionsColumn.AllowEdit = false;
            this.colUlkeKodu.StatusBarAciklama = null;
            this.colUlkeKodu.StatusBarKisaYol = null;
            this.colUlkeKodu.StatusBarKisaYolAciklama = null;
            this.colUlkeKodu.Visible = true;
            this.colUlkeKodu.Width = 89;
            // 
            // colNumara
            // 
            this.colNumara.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNumara.AppearanceCell.Options.UseFont = true;
            this.colNumara.AppearanceCell.Options.UseTextOptions = true;
            this.colNumara.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumara.Caption = "Numara";
            this.colNumara.FieldName = "Numara";
            this.colNumara.Name = "colNumara";
            this.colNumara.OptionsColumn.AllowEdit = false;
            this.colNumara.StatusBarAciklama = null;
            this.colNumara.StatusBarKisaYol = null;
            this.colNumara.StatusBarKisaYolAciklama = null;
            this.colNumara.Visible = true;
            this.colNumara.Width = 106;
            // 
            // colDahiliNo
            // 
            this.colDahiliNo.AppearanceCell.Options.UseTextOptions = true;
            this.colDahiliNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDahiliNo.Caption = "Dahili No";
            this.colDahiliNo.FieldName = "DahiliNo";
            this.colDahiliNo.Name = "colDahiliNo";
            this.colDahiliNo.OptionsColumn.AllowEdit = false;
            this.colDahiliNo.StatusBarAciklama = null;
            this.colDahiliNo.StatusBarKisaYol = null;
            this.colDahiliNo.StatusBarKisaYolAciklama = null;
            this.colDahiliNo.Visible = true;
            // 
            // colArama
            // 
            this.colArama.Caption = "Arama";
            this.colArama.FieldName = "Arama";
            this.colArama.Name = "colArama";
            this.colArama.OptionsColumn.AllowEdit = false;
            this.colArama.OptionsColumn.AllowMove = false;
            this.colArama.StatusBarAciklama = null;
            this.colArama.StatusBarKisaYol = null;
            this.colArama.StatusBarKisaYolAciklama = null;
            this.colArama.Visible = true;
            this.colArama.Width = 88;
            // 
            // colSms
            // 
            this.colSms.Caption = "SMS";
            this.colSms.FieldName = "Sms";
            this.colSms.Name = "colSms";
            this.colSms.OptionsColumn.AllowEdit = false;
            this.colSms.OptionsColumn.AllowMove = false;
            this.colSms.StatusBarAciklama = null;
            this.colSms.StatusBarKisaYol = null;
            this.colSms.StatusBarKisaYolAciklama = null;
            this.colSms.Visible = true;
            this.colSms.Width = 88;
            // 
            // colWhatsapp
            // 
            this.colWhatsapp.Caption = "Whatsapp";
            this.colWhatsapp.FieldName = "Whatsapp";
            this.colWhatsapp.Name = "colWhatsapp";
            this.colWhatsapp.OptionsColumn.AllowEdit = false;
            this.colWhatsapp.OptionsColumn.AllowMove = false;
            this.colWhatsapp.StatusBarAciklama = null;
            this.colWhatsapp.StatusBarKisaYol = null;
            this.colWhatsapp.StatusBarKisaYolAciklama = null;
            this.colWhatsapp.Visible = true;
            this.colWhatsapp.Width = 95;
            // 
            // colEPBool
            // 
            this.colEPBool.Caption = "Mail";
            this.colEPBool.FieldName = "EPBool";
            this.colEPBool.Name = "colEPBool";
            this.colEPBool.OptionsColumn.AllowEdit = false;
            this.colEPBool.StatusBarAciklama = null;
            this.colEPBool.StatusBarKisaYol = null;
            this.colEPBool.StatusBarKisaYolAciklama = null;
            this.colEPBool.Visible = true;
            this.colEPBool.Width = 66;
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
            this.colEPosta.Width = 114;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = null;
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.Width = 100;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = null;
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.Width = 100;
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
            this.colWeb.Width = 100;
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
            this.colAciklama.Width = 200;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOncelik
            // 
            this.colOncelik.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.colOncelik.AppearanceCell.Options.UseFont = true;
            this.colOncelik.AppearanceCell.Options.UseTextOptions = true;
            this.colOncelik.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOncelik.Caption = "Öncelik";
            this.colOncelik.FieldName = "Oncelik";
            this.colOncelik.Name = "colOncelik";
            this.colOncelik.OptionsColumn.AllowEdit = false;
            this.colOncelik.StatusBarAciklama = null;
            this.colOncelik.StatusBarKisaYol = null;
            this.colOncelik.StatusBarKisaYolAciklama = null;
            this.colOncelik.Visible = true;
            this.colOncelik.Width = 50;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Genel Bilgiler";
            this.gridBand1.Columns.Add(this.colOncelik);
            this.gridBand1.Columns.Add(this.colIletisimTuru);
            this.gridBand1.Columns.Add(this.colBaslik);
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colIzinDurumu);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 443;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Numara ve Kanal Bilgileri";
            this.gridBand2.Columns.Add(this.colUlkeKodu);
            this.gridBand2.Columns.Add(this.colNumara);
            this.gridBand2.Columns.Add(this.colDahiliNo);
            this.gridBand2.Columns.Add(this.colArama);
            this.gridBand2.Columns.Add(this.colSms);
            this.gridBand2.Columns.Add(this.colWhatsapp);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 541;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "E-Posta ve Kanal Bilgileri";
            this.gridBand5.Columns.Add(this.colEPBool);
            this.gridBand5.Columns.Add(this.colEPosta);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 2;
            this.gridBand5.Width = 180;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Özel Kod";
            this.gridBand3.Columns.Add(this.colOzelKod1Adi);
            this.gridBand3.Columns.Add(this.colOzelKod2Adi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 200;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Ek Bilgiler";
            this.gridBand4.Columns.Add(this.colWeb);
            this.gridBand4.Columns.Add(this.colAciklama);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 4;
            this.gridBand4.Width = 300;
            // 
            // CariIletisimListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 482);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CariIletisimListForm";
            this.Text = "Cari İletişim Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grid.MyBandedGridControl grid;
        private UserControls.Grid.MyBandedGridView tablo;
        private UserControls.Grid.MyBandedGridColumn colIletisimTuru;
        private UserControls.Grid.MyBandedGridColumn colBaslik;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grid.MyBandedGridColumn colIzinDurumu;
        private UserControls.Grid.MyBandedGridColumn colUlkeKodu;
        private UserControls.Grid.MyBandedGridColumn colNumara;
        private UserControls.Grid.MyBandedGridColumn colDahiliNo;
        private UserControls.Grid.MyBandedGridColumn colArama;
        private UserControls.Grid.MyBandedGridColumn colSms;
        private UserControls.Grid.MyBandedGridColumn colWhatsapp;
        private UserControls.Grid.MyBandedGridColumn colOzelKod1Adi;
        private UserControls.Grid.MyBandedGridColumn colOzelKod2Adi;
        private UserControls.Grid.MyBandedGridColumn colWeb;
        private UserControls.Grid.MyBandedGridColumn colAciklama;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private UserControls.Grid.MyBandedGridColumn colEPBool;
        private UserControls.Grid.MyBandedGridColumn colEPosta;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private UserControls.Grid.MyBandedGridColumn colOncelik;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}