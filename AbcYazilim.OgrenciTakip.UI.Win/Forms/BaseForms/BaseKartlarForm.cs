using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
//using AbcYazilim.OgrenciTakip.UI.Win.Forms.FiltreForms;
using DevExpress.XtraBars;
//using AbcYazilim.OgrenciTakip.UI.Win.Show.Interfaces;
using DevExpress.XtraGrid.Views.Grid;
//using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GenelForms;
//using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Grid;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseKartlarForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseKartlarForm()
        {
            InitializeComponent();
        }
        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();

            }
            //else if (e.Item == btnStandartExcelDosyasi)
            //    Tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);

            //else if (e.Item == btnFormatliExcelDosyasi)
            //    Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);

            //else if (e.Item == btnFormatsizExcelDosyasi)
            //    Tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption, Text);

            //else if (e.Item == btnWordDosyasi)
            //    Tablo.TabloDisariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);

            //else if (e.Item == btnPdfDosyasi)
            //    Tablo.TabloDisariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);

            //else if (e.Item == btnTxtDosyasi)
            //    Tablo.TabloDisariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);

            //else if (e.Item == btnYeni)
            //{
            //    if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
            //    ShowEditForm(-1);
            //}
            //else if (e.Item == btnDuzelt)
            //    ShowEditForm(Tablo.GetRowId());

            //else if (e.Item == btnSil)
            //{
            //    if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Silebilir)) return;
            //    EntityDelete();
            //}

            //else if (e.Item == btnSec)
            //    SelectEntity();

            //else if (e.Item == btnYenile)
            //    Listele();

            //else if (e.Item == btnFiltrele)
            //    FiltreSec();

            //else if (e.Item == btnTahakkukYap)
            //    TahakkukYap();

            //else if (e.Item == btnKolonlar)
            //{
            //    if (Tablo.CustomizationForm == null)
            //        Tablo.ShowCustomization();
            //    else
            //        Tablo.HideCustomization();
            //}

            //else if (e.Item == btnBelgeHareketleri)
            //    BelgeHareketleri();

            //else if (e.Item == btnBagliKartlar)
            //    BagliKartAc();

            //else if (e.Item == btnParametreler)
            //    BagliKartAc();

            //else if (e.Item == btnYazdir)
            //    Yazdir();

            //else if (e.Item == btnTabloYazdir)
            //    TablePrintingFunctions.Yazdir(Tablo, Tablo.ViewCaption, AnaForm.SubeAdi);


            //else if (e.Item == btnBaskiOnizleme)
            //    BaskiOnizleme();


            //else if (e.Item == btnTasarimDegistir)
            //    Duzelt();

            //else if (e.Item == btnCikis)
            //    Close();

            //else if (e.Item == btnAktifPasifKartlar)
            //{
            //    AktifKartlariGoster = !AktifKartlariGoster;
            //    FormCaptionAyarla();
            //}

            Cursor.Current = DefaultCursor;
        }
    
    }
}