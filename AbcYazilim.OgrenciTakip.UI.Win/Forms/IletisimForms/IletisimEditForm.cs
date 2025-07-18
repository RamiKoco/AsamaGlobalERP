using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Linq;


namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IletisimBll(myDataLayoutControl);
            txtKayitTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitTuru>());
            txtIletisimTurleri.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimTuru>());
            txtIzinDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimDurumu>());
            txtKanallar.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimKanalTipi>()
                        .Cast<string>()                          
                        .Select(x => new CheckedListBoxItem(x))
                        .ToArray());

            BaseKartTuru = KartTuru.Iletisim;
            txtKayitTuru.SelectedIndexChanged += (s, e) =>
            {
                txtKayitHesabi.Id = 0;
                txtKayitHesabi.Text = "";
            };
            txtIletisimTurleri.EditValueChanged += TxtIletisimTurleri_EditValueChanged;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert
                ? new IletisimS()
                : ((IletisimBll) Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimBll) Bll).YeniKodVer();
            txtBaslik.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IletisimS)OldEntity;
            txtKod.Text = entity.Kod;
            txtBaslik.Text = entity.Baslik;
            txtIlgili.Text = entity.Ilgili;          
            txtWeb.Text = entity.Web;          
            txtKayitTuru.SelectedItem = entity.KayitTuru.ToName();
            if (entity.KayitTuru == KayitTuru.Kisi)
                txtKayitHesabi.Id = entity.KisiId ?? 0;
            else if (entity.KayitTuru == KayitTuru.Meslek)
                txtKayitHesabi.Id = entity.MeslekId ?? 0;
            else
                txtKayitHesabi.Id = 0;
            txtKayitHesabi.Text = entity.KayitHesabiAdi;
            txtIletisimTurleri.EditValue = entity.IletisimTuru.ToName();
            txtKanallar.SetEditValue(entity.Kanallar);
            txtIzinDurumu.SelectedItem = entity.IzinDurumu.ToName();
            txtIzinTarihi.EditValue = entity.IzinTarihi;
            txtOncelik.Value = entity.Oncelik;            
            txtWeb.Text = entity.Web;
            txtUlkeKodu.Text = entity.UlkeKodu;
            txtTelefonVeFax.Text = entity.Numara;
            txtDahili.Text = entity.DahiliNo;
            txtEPosta.Text = entity.EPosta;
            txtKullaniciAdi.Text = entity.KullaniciAdi;
            txtSIPKullaniciAdi.Text = entity.SIPKullaniciAdi;
            txtSIPServer.Text = entity.SIPServer;
            txtSosyalMedyaUrl.Text=entity.SosyalMedyaUrl;
            txtSosyalMedyaPlatformu.Id = entity.SosyalMedyaPlatformuId;
            txtSosyalMedyaPlatformu.Text = entity.SosyalMedyaPlatformuAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglVoip.IsOn = entity.VoipMi;
            txtVarsayilanMi.IsOn = entity.VarsayilanMi;
            tglDurum.IsOn = entity.Durum;
            ButonEnabledDurumu();
        }

        protected override void GuncelNesneOlustur()
        {
            var kayitTuru = txtKayitTuru.SelectedItem?.ToString().GetEnum<KayitTuru>() ?? KayitTuru.Kisi;

            var kisiId = kayitTuru == KayitTuru.Kisi ? txtKayitHesabi.Id : null;
            var meslekId = kayitTuru == KayitTuru.Meslek ? txtKayitHesabi.Id : null;
            CurrentEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                Baslik = txtBaslik.Text,
                Ilgili = txtIlgili.Text,
                Oncelik =(short) txtOncelik.Value,               
                Web = txtWeb.Text,
                KayitTuru = kayitTuru,
                KisiId = kisiId,
                MeslekId = meslekId,
                IletisimTuru = txtIletisimTurleri.Text.GetEnum<IletisimTuru>(),
                IzinDurumu = txtIzinDurumu.Text.GetEnum<IletisimDurumu>(),
                Kanallar = txtKanallar.EditValue?.ToString(),
                IzinTarihi = (DateTime?)txtIzinTarihi.EditValue,
                UlkeKodu = txtUlkeKodu.Text,
                Numara= txtTelefonVeFax.Text,
                DahiliNo = txtDahili.Text,                
                EPosta= txtEPosta.Text,
                KullaniciAdi= txtKullaniciAdi.Text,
                SIPServer= txtSIPServer.Text,
                SIPKullaniciAdi = txtSIPKullaniciAdi.Text,
                SosyalMedyaUrl =txtSosyalMedyaUrl.Text,
                SosyalMedyaPlatformuId = txtSosyalMedyaPlatformu.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                VarsayilanMi = txtVarsayilanMi.IsOn,
                VoipMi =tglVoip.IsOn,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            base.ButonEnabledDurumu();

            if (txtIletisimTurleri.EditValue == null) return;

            IletisimTuru iletisimTuru;

            try
            {
                iletisimTuru = EnumFunctions.GetValueFromDescription<IletisimTuru>(txtIletisimTurleri.EditValue.ToString());
            }
            catch
            {
                return;
            }

            txtUlkeKodu.Enabled = true;
            txtTelefonVeFax.Enabled = true;
            txtDahili.Enabled = true;
            txtEPosta.Enabled = true;
            txtWeb.Enabled = true;
            txtSosyalMedyaPlatformu.Enabled = true;
            txtSosyalMedyaUrl.Enabled = true;
            txtKullaniciAdi.Enabled = true;
            txtSIPKullaniciAdi.Enabled = true;
            txtSIPServer.Enabled = true;
            tglVoip.Enabled = true;

            switch (iletisimTuru)
            {
                case IletisimTuru.Telefon:
                    txtEPosta.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    break;

                case IletisimTuru.EPosta:
                    txtUlkeKodu.Enabled = false;
                    txtTelefonVeFax.Enabled = false;
                    txtDahili.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;

                case IletisimTuru.Web:
                    txtUlkeKodu.Enabled = false;
                    txtTelefonVeFax.Enabled = false;
                    txtDahili.Enabled = false;
                    txtEPosta.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;

                case IletisimTuru.SosyalMedya:
                    txtUlkeKodu.Enabled = false;
                    txtTelefonVeFax.Enabled = false;
                    txtDahili.Enabled = false;
                    txtEPosta.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;

                case IletisimTuru.Fax:
                    txtEPosta.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;
            }
        }
        private void TxtIletisimTurleri_EditValueChanged(object sender, EventArgs e)
        {
            ButonEnabledDurumu();
        }

        private void txtKayitTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKayitHesabi.Id = 0;
            txtKayitHesabi.Text = string.Empty;
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())                
               if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);
                else if (sender == txtSosyalMedyaPlatformu)
                    sec.Sec(txtSosyalMedyaPlatformu, KartTuru.SosyalMedyaPlatformu);
                else if (sender == txtKayitHesabi)
                {
                    var kayitTuru = txtKayitTuru.Text.GetEnum<KayitTuru>();
                    if (kayitTuru == KayitTuru.Kisi)
                        sec.Sec(txtKayitHesabi, KartTuru.Kisi);
                    else if (kayitTuru == KayitTuru.Meslek)
                        sec.Sec(txtKayitHesabi, KartTuru.Meslek);
                    else
                        sec.Sec(txtKayitHesabi);
                }

        }
        public override bool Kaydet(bool kapanis)
        {           
            if (!kapanis)
            {
                if (string.IsNullOrWhiteSpace(txtKayitHesabi.Text))
                {
                    Messages.HataliVeriMesaji("Lütfen Kayıt Hesabı giriniz.");
                    txtKayitHesabi.Focus();
                    return false;
                }
            }
          
            var sonuc = base.Kaydet(kapanis);

            if (!sonuc) return false;

            var kayitTuru = txtKayitTuru.Text.GetEnum<KayitTuru>();

            var kisiId = kayitTuru == KayitTuru.Kisi ? txtKayitHesabi.Id : null;

            if (kayitTuru == KayitTuru.Kisi && kisiId.HasValue && kisiId > 0)
            {
                var iletisimEntity = CurrentEntity as Iletisim;
                if (iletisimEntity == null) return false;

                var entity = new IletisimBilgileri
                {
                    KisiId = kisiId.Value,
                    IletisimId = iletisimEntity.Id,
                    Veli = true,
                    IletisimTuru = iletisimEntity.IletisimTuru                   
                };

                using (var context = new OgrenciTakipContext())
                {
                    // Aynı iletişim kaydına bağlı olan tüm kayıtları bul (yani IletisimId eşleşenler)
                    var mevcutKayitlar = context.IletisimBilgileri
                        .Where(x => x.IletisimId == iletisimEntity.Id)
                        .ToList();

                    // Eğer varsa hepsini sil
                    if (mevcutKayitlar.Any())
                    {
                        foreach (var kayit in mevcutKayitlar)
                        {
                            context.IletisimBilgileri.Remove(kayit);
                        }
                        context.SaveChanges();
                    }

                    // Yeni kaydı ekle
                    var yeniKayit = new IletisimBilgileri
                    {
                        KisiId = kisiId.Value,
                        IletisimId = iletisimEntity.Id,
                        Veli = true,
                        IletisimTuru = iletisimEntity.IletisimTuru
                    };

                    context.IletisimBilgileri.Add(yeniKayit);
                    context.SaveChanges();
                }
            }

            return true;
        }
       
    }
}