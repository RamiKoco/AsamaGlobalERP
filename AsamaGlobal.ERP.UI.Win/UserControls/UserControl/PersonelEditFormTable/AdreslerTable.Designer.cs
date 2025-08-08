﻿namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.PersonelEditFormTable
{
    partial class AdreslerTable
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
            this.colAdresNotu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBaslik = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdres = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colPostaKodu = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIlceAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colIlAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colUlkeAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdresTurleriAdi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colAdresTipi = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colEnlem = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.colBoylam = new AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // insUptNavigator
            // 
            this.insUptNavigator.Location = new System.Drawing.Point(0, 243);
            this.insUptNavigator.Size = new System.Drawing.Size(487, 24);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(487, 243);
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
            this.gridBand3,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colBaslik,
            this.colAdresNotu,
            this.colAdres,
            this.colPostaKodu,
            this.colIlceAdi,
            this.colIlAdi,
            this.colUlkeAdi,
            this.colAdresTurleriAdi,
            this.colAdresTipi,
            this.colEnlem,
            this.colBoylam});
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
            this.tablo.ViewCaption = "Adres Kartları";
            // 
            // colAdresNotu
            // 
            this.colAdresNotu.Caption = "Adres Notu";
            this.colAdresNotu.FieldName = "AdresNotu";
            this.colAdresNotu.Name = "colAdresNotu";
            this.colAdresNotu.OptionsColumn.AllowEdit = false;
            this.colAdresNotu.StatusBarAciklama = null;
            this.colAdresNotu.StatusBarKisaYol = null;
            this.colAdresNotu.StatusBarKisaYolAciklama = null;
            this.colAdresNotu.Visible = true;
            this.colAdresNotu.Width = 146;
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
            this.colBaslik.Width = 163;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisaYol = null;
            this.colAdres.StatusBarKisaYolAciklama = null;
            this.colAdres.Visible = true;
            this.colAdres.Width = 165;
            // 
            // colPostaKodu
            // 
            this.colPostaKodu.Caption = "Posta Kodu";
            this.colPostaKodu.FieldName = "PostaKodu";
            this.colPostaKodu.Name = "colPostaKodu";
            this.colPostaKodu.OptionsColumn.AllowEdit = false;
            this.colPostaKodu.StatusBarAciklama = null;
            this.colPostaKodu.StatusBarKisaYol = null;
            this.colPostaKodu.StatusBarKisaYolAciklama = null;
            this.colPostaKodu.Visible = true;
            this.colPostaKodu.Width = 143;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.Width = 143;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYol = null;
            this.colIlAdi.StatusBarKisaYolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.Width = 143;
            // 
            // colUlkeAdi
            // 
            this.colUlkeAdi.Caption = "Ülke";
            this.colUlkeAdi.FieldName = "UlkeAdi";
            this.colUlkeAdi.Name = "colUlkeAdi";
            this.colUlkeAdi.OptionsColumn.AllowEdit = false;
            this.colUlkeAdi.StatusBarAciklama = null;
            this.colUlkeAdi.StatusBarKisaYol = null;
            this.colUlkeAdi.StatusBarKisaYolAciklama = null;
            this.colUlkeAdi.Visible = true;
            this.colUlkeAdi.Width = 147;
            // 
            // colAdresTurleriAdi
            // 
            this.colAdresTurleriAdi.Caption = "Tür";
            this.colAdresTurleriAdi.FieldName = "AdresTurleriAdi";
            this.colAdresTurleriAdi.Name = "colAdresTurleriAdi";
            this.colAdresTurleriAdi.OptionsColumn.AllowEdit = false;
            this.colAdresTurleriAdi.StatusBarAciklama = null;
            this.colAdresTurleriAdi.StatusBarKisaYol = null;
            this.colAdresTurleriAdi.StatusBarKisaYolAciklama = null;
            this.colAdresTurleriAdi.Visible = true;
            this.colAdresTurleriAdi.Width = 154;
            // 
            // colAdresTipi
            // 
            this.colAdresTipi.Caption = "Tip";
            this.colAdresTipi.FieldName = "AdresTipi";
            this.colAdresTipi.Name = "colAdresTipi";
            this.colAdresTipi.OptionsColumn.AllowEdit = false;
            this.colAdresTipi.StatusBarAciklama = null;
            this.colAdresTipi.StatusBarKisaYol = null;
            this.colAdresTipi.StatusBarKisaYolAciklama = null;
            this.colAdresTipi.Visible = true;
            this.colAdresTipi.Width = 151;
            // 
            // colEnlem
            // 
            this.colEnlem.Caption = "Enlem";
            this.colEnlem.FieldName = "Enlem";
            this.colEnlem.Name = "colEnlem";
            this.colEnlem.OptionsColumn.AllowEdit = false;
            this.colEnlem.StatusBarAciklama = null;
            this.colEnlem.StatusBarKisaYol = null;
            this.colEnlem.StatusBarKisaYolAciklama = null;
            this.colEnlem.Visible = true;
            this.colEnlem.Width = 101;
            // 
            // colBoylam
            // 
            this.colBoylam.Caption = "Boylam";
            this.colBoylam.FieldName = "Boylam";
            this.colBoylam.Name = "colBoylam";
            this.colBoylam.OptionsColumn.AllowEdit = false;
            this.colBoylam.StatusBarAciklama = null;
            this.colBoylam.StatusBarKisaYol = null;
            this.colBoylam.StatusBarKisaYolAciklama = null;
            this.colBoylam.Visible = true;
            this.colBoylam.Width = 103;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Başlıklar";
            this.gridBand1.Columns.Add(this.colBaslik);
            this.gridBand1.Columns.Add(this.colAdresNotu);
            this.gridBand1.Columns.Add(this.colAdres);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 474;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Adres Bilgileri";
            this.gridBand2.Columns.Add(this.colPostaKodu);
            this.gridBand2.Columns.Add(this.colIlceAdi);
            this.gridBand2.Columns.Add(this.colIlAdi);
            this.gridBand2.Columns.Add(this.colUlkeAdi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 576;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Tür Bilgileri";
            this.gridBand3.Columns.Add(this.colAdresTipi);
            this.gridBand3.Columns.Add(this.colAdresTurleriAdi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 305;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Konum Bilgileri";
            this.gridBand4.Columns.Add(this.colEnlem);
            this.gridBand4.Columns.Add(this.colBoylam);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 204;
            // 
            // AdreslerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "AdreslerTable";
            this.Size = new System.Drawing.Size(487, 267);
            this.Controls.SetChildIndex(this.insUptNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.MyBandedGridControl grid;
        private Grid.MyBandedGridView tablo;
        private Grid.MyBandedGridColumn colAdresNotu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private Grid.MyBandedGridColumn colBaslik;
        private Grid.MyBandedGridColumn colAdres;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private Grid.MyBandedGridColumn colPostaKodu;
        private Grid.MyBandedGridColumn colIlceAdi;
        private Grid.MyBandedGridColumn colIlAdi;
        private Grid.MyBandedGridColumn colUlkeAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private Grid.MyBandedGridColumn colAdresTipi;
        private Grid.MyBandedGridColumn colAdresTurleriAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private Grid.MyBandedGridColumn colEnlem;
        private Grid.MyBandedGridColumn colBoylam;
    }
}
