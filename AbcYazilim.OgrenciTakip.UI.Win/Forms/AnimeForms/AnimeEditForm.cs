using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GenelForms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AnimeForms
{
    public partial class AnimeEditForm : BaseEditForm
    {
        private readonly Ogrenci _ogrenci;
        private readonly Yazar _yazar;
        public AnimeEditForm()
        {
            InitializeComponent();
            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            Bll = new AnimeBll(DataLayoutGenelBilgiler);//Herhangi bir hata olduğunda bunun içerisindeki controllere odaklan demiş olacaz
            BaseKartTuru = KartTuru.Anime;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };//btn yeni'yi gizle
            ShowItems = new BarItem[] { btnYazdir };//btn yazdır'ı göster.

            txtKayitSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitSekli>()); //combobox Kayıt şekili dolu olarak gelecek.
            txtKayitDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitDurumu>());

            txtKayitTarihi.Properties.MinValue = AnaForm.DonemParametreleri.DonemBaslamaTarihi;
            txtKayitTarihi.Properties.MaxValue = AnaForm.DonemParametreleri.DonemBitisTarihi;

            btnYazdir.Caption = "Kayıt Evrakları";
        }
        public AnimeEditForm(params object[] prm) : this()
        {
            if (prm[0] is Ogrenci yzr)
                _ogrenci = yzr;

            else if (prm[0] is bool yesNo)
                FarkliSubeIslemi = yesNo;
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AnimeS() : ((AnimeBll)Bll).Single(FilterFunctions.Filter<Anime>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AnimeBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AnimeS)OldEntity;
            txtTcKimlikNo.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.TcKimlikNo : entity.TcKimlikNo;
            txtAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Adi : entity.Adi;
            txtSoyadi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Soyadi : entity.SoyAdi;
            txtBabaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.BabaAdi : entity.BabaAdi;
            txtAnaAdi.Text = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.AnaAdi : entity.AnaAdi;
            txtDurum.Text = entity.Durum ? IptalDurumu.DevamEdiyor.ToName() : IptalDurumu.IptalEdildi.ToName();
            txtKod.Text = entity.Kod;
            txtOkulNo.Text = entity.OkulNo;
            txtKayitTarihi.DateTime = entity.KayitTarihi;
            txtKayitSekli.SelectedItem = entity.KayitSekli.ToName();
            txtKayitDurumu.SelectedItem = entity.KayitDurumu.ToName();
            txtSinif.Id = entity.SinifId;
            txtSinif.Text = entity.SinifAdi;
            txtYabanciDil.Id = entity.YabanciDilId;
            txtYabanciDil.Text = entity.YabanciDilAdi;
            txtGeldigiOkul.Id = entity.GeldigiOkulId;
            txtGeldigiOkul.Text = entity.GeldigiOkulAdi;            
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
           
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Anime
            {
                Id = Id,
                Kod = txtKod.Text,
                OgrenciId = BaseIslemTuru == IslemTuru.EntityInsert ? _ogrenci.Id : ((AnimeS)OldEntity).OgrenciId,
                OkulNo = txtOkulNo.Text,
                KayitTarihi = txtKayitTarihi.DateTime.Date,
                KayitSekli = txtKayitSekli.Text.GetEnum<KayitSekli>(),
                KayitDurumu = txtKayitDurumu.Text.GetEnum<KayitDurumu>(),
                SinifId = Convert.ToInt64(txtSinif.Id),
                YabanciDilId = txtYabanciDil.Id,
                GeldigiOkulId = txtGeldigiOkul.Id,                
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,               
                Durum = txtDurum.Text.GetEnum<IptalDurumu>() == IptalDurumu.DevamEdiyor,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,

            };
            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
         
            if (BagliTabloHataliGirisKontrol()) return false;
            var result = ((AnimeBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
          
            if (BagliTabloHataliGirisKontrol()) return false;
            var result = ((AnimeBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtSinif)
                    sec.Sec(txtSinif);
                else if (sender == txtYabanciDil)
                    sec.Sec(txtYabanciDil);
                else if (sender == txtGeldigiOkul)
                    sec.Sec(txtGeldigiOkul);             
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Anime);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Anime);               

        }

    }
}