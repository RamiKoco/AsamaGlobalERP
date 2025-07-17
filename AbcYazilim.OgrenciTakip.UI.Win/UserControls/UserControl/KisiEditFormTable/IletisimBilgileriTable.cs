using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.YakinlikForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;


namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.KisiEditFormTable
{
    public partial class IletisimBilgileriTable : BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();

            Bll = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
            repositoryAdres.Items.AddEnum<IletisimTuru>();
        }
        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((IletisimBilgileriBll)Bll).List(x => x.KisiId == OwnerForm.Id).ToBindingList<IletisimBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IletisimBilgileriL>().Where(x => !x.Delete).Select(x => x.IletisimId).ToList();


            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(KartTuru.Iletisim, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<IletisimL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriL
                {
                    KisiId = OwnerForm.Id,
                    IletisimId = entity.Id,
                    Baslik = entity.Baslik,
                    UlkeKodu = entity.UlkeKodu,
                    Numara = entity.Numara,
                    DahiliNo = entity.DahiliNo,
                    EPosta = entity.EPosta,
                    Kanallar = entity?.Kanallar,
                    KullaniciAdi = entity.KullaniciAdi,
                    SosyalMedyaUrl = entity.SosyalMedyaUrl,
                    SIPKullaniciAdi = entity.SIPKullaniciAdi,
                    SIPServer = entity.SIPServer,
                    Ilgili = entity.Ilgili,
                    Oncelik = entity.Oncelik,
                    VoipMi = entity.VoipMi,
                    VarsayilanMi = entity.VarsayilanMi,
                    AramaAktifMi = entity.AramaAktifMi,
                    SmsAktifMi = entity.SmsAktifMi,
                    WhatsAppAktifMi = entity.WhatsAppAktifMi,
                    EmailAktifMi = entity.EmailAktifMi,
                    Web = entity.Web,
                    Aciklama = entity.Aciklama,
                    SosyalMedyaPlatformuAdi = entity.SosyalMedyaPlatformuAdi,
                    IletisimTuruAdi = entity.IletisimTuru,
                    IzinTarihi = entity.IzinTarihi,                   
                    IzinDurumu = entity.IzinDurumu,  
                    MeslekAdi = entity.MeslekAdi,
                    //IsyeriAdi = entity.IsyeriAdi,
                    //GorevAdi = entity.GorevAdi,
                    Insert = true
                };

                if (source.Count == 0)
                {
                    row.Veli = true;
                    row.IletisimTuru = IletisimTuru.Telefon;
                }

                //var yakinlik = (Yakinlik)ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);
                //if (yakinlik == null) return;

                //row.YakinlikId = yakinlik.Id;
                //row.YakinlikAdi = yakinlik.YakinlikAdi;


                source.Add(row);

            }

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colVeli;

            ButonEnabledDurumu(true);

        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IletisimBilgileriL>(i);
                //if (entity.YakinlikAdi == null)
                //{
                //    tablo.FocusedRowHandle = i;
                //    tablo.FocusedColumn = colYakinlikAdi;
                //    tablo.SetColumnError(colYakinlikAdi, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz");

                //}

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;

        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<IletisimBilgileriL>();
            if (entity == null) return;
            ShowEditForms<IletisimEditForm>.ShowDialogEditForm(KartTuru.Kisi, entity.IletisimId, null);

        }

        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (source[i].IletisimTuru == null) continue;
                source[i].IletisimTuru = null;

                if (!source[i].Insert)
                    source[i].Update = true;
            }
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (!source[i].Veli) continue;
                source[i].Veli = false;

                if (!source[i].Insert)
                    source[i].Update = true;
            }
            insUptNavigator.Navigator.Buttons.DoClick(insUptNavigator.Navigator.Buttons.EndEdit);

        }

        //protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        //{
        //    base.Tablo_FocusedColumnChanged(sender, e);

        //    if (e.FocusedColumn == colBaslik)
        //        e.FocusedColumn.Sec(tablo, insUptNavigator.Navigator, repositoryYakinlik, colBaslik);

        //}
    }
}
