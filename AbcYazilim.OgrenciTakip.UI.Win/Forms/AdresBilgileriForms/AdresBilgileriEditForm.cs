using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AdresBilgiForms
{
    public partial class AdresBilgileriEditForm : BaseEditForm
    {
        public AdresBilgileriEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new AdresBilgileriBll(myDataLayoutControl);
            txtKayitTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitTuru>());
            txtAdresTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AdresTipi>());           
            BaseKartTuru = KartTuru.AdresBilgileri;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new AdresBilgileriS() : ((AdresBilgileriBll)Bll).Single(FilterFunctions.Filter<AdresBilgileri>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AdresBilgileriBll)Bll).YeniKodVer();
            txtBaslik.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AdresBilgileriS)OldEntity;
            txtKod.Text = entity.Kod;
            txtBaslik.Text = entity.Baslik;
            txtAdresNotu.Text = entity.AdresNotu;            
            txtKayitTuru.SelectedItem = entity.KayitTuru.ToName();
            txtAdresTipi.SelectedItem = entity.AdresTipi.ToName();
            //txtKayitHesabi.Text = entity.KayitHesabi;
            //txtUlke.Id = entity.UlkeId;
            //txtUlke.Text = entity.UlkeAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAdresTurleri.Id = entity.AdresTurleriId;
            txtAdresTurleri.Text = entity.AdresTurleriAdi;
            txtPostaKodu.Text = entity.PostaKodu;
            txtAdres.Text = entity.Adres;
            txtEnlem.EditValue = entity.Enlem ?? 0m;
            txtBoylam.EditValue = entity.Boylam ?? 0m;
            txtAciklama.Text = entity.Aciklama;   
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            decimal.TryParse(txtEnlem.EditValue?.ToString(), out var enlem);
            decimal.TryParse(txtBoylam.EditValue?.ToString(), out var boylam);

            CurrentEntity = new AdresBilgileri
            {
                Id = Id,
                Kod = txtKod.Text,               
                Baslik= txtBaslik.Text,
                AdresNotu= txtAdresNotu.Text,
                KayitTuru = txtKayitTuru.Text.GetEnum<KayitTuru>(),
                AdresTipi = txtAdresTipi.Text.GetEnum<AdresTipi>(),
                //KayitHesabi= txtKayitHesabi.Text,
                //UlkeId = txtUlke.Id,
                IlId = txtIl.Id,
                IlceId = txtIlce.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                AdresTurleriId = txtAdresTurleri.Id,
                PostaKodu= txtPostaKodu.Text,
                Adres = txtAdres.Text,
                Enlem = enlem,
                Boylam = boylam,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.AdresBilgileri);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.AdresBilgileri);
                else if (sender == txtAdresTurleri)
                    sec.Sec(txtAdresTurleri, KartTuru.AdresTurleri);
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl) return;
            txtIl.ControlEnabledChange(txtIlce);

        }

    }
}