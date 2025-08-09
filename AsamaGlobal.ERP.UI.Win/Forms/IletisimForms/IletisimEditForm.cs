<<<<<<< HEAD
﻿using System;
using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Common.Functions;
using AsamaGlobal.ERP.Model.Dto;
=======
﻿using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto.IletisimlerDto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Common.Functions;
using AsamaGlobal.ERP.Common.Message;
using AsamaGlobal.ERP.Data.Contexts;
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using DevExpress.XtraEditors;
<<<<<<< HEAD

namespace AsamaGlobal.ERP.UI.Win.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
=======
using DevExpress.XtraEditors.Controls;
using System;
using System.Linq;

namespace AsamaGlobal.ERP.UI.Win.Forms.IletisimlerForms
{
    public partial class IletisimlerEditForm : BaseEditForm
    {
        public IletisimlerEditForm()
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
<<<<<<< HEAD
            Bll = new IletisimBll(myDataLayoutControl);
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Iletisim;
=======
            Bll = new IletisimlerBll(myDataLayoutControl);
            txtKayitTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitTuru>());
            txtIletisimTurleri.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimTuru>());
            txtIzinDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimDurumu>());
            txtKanallar.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimKanalTipi>()
                        .Cast<string>()
                        .Select(x => new CheckedListBoxItem(x))
                        .ToArray());

            BaseKartTuru = KartTuru.Iletisimler;
            txtKayitTuru.SelectedIndexChanged += (s, e) =>
            {
                txtKayitHesabi.Id = 0;
                txtKayitHesabi.Text = "";
            };
            txtIletisimTurleri.EditValueChanged += TxtIletisimTurleri_EditValueChanged;
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert
<<<<<<< HEAD
                ? new IletisimS()
                : ((IletisimBll) Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimBll) Bll).YeniKodVer();
            txtTcKimlikNo.Focus();
=======
                ? new IletisimlerS()
                : ((IletisimlerBll)Bll).Single(FilterFunctions.Filter<Iletisimler>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimlerBll)Bll).YeniKodVer();
            txtBaslik.Focus();
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        }

        protected override void NesneyiKontrollereBagla()
        {
<<<<<<< HEAD
            var entity = (IletisimS) OldEntity;
            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAdi.Text = entity.Adi;
            txtSoyAdi.Text = entity.Soyadi;
            txtEvTel.Text = entity.EvTel;
            txtIsTel1.Text = entity.IsTel1;
            txtDahili1.Text = entity.Dahili1;
            txtIsTel2.Text = entity.IsTel2;
            txtDahili2.Text= entity.Dahili2;
            txtCepTel1.Text = entity.CepTel1;
            txtCepTel2.Text = entity.CepTel2;
            txtWeb.Text = entity.Web;
            txtEmail.Text = entity.Email;
            txtIbanNo.Text = entity.IbanNo;
            txtKartNo.Text = entity.KartNo;
            txtEvAdres.Text = entity.EvAdres;
            txtEvAdresIl.Id = entity.EvAdresIlId;
            txtEvAdresIl.Text = entity.EvAdresIlAdi;
            txtEvAdresIlce.Id = entity.EvAdresIlceId;
            txtEvAdresIlce.Text = entity.EvAdresIlceAdi;
            txtIsAdres.Text = entity.IsAdres;
            txtIsAdresIl.Id = entity.IsAdresIlId;
            txtIsAdresIl.Text = entity.IsAdresIlAdi;
            txtIsAdresIlce.Id = entity.IsAdresIlceId;
            txtIsAdresIlce.Text = entity.IsAdresIlceAdi;
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtIsyeri.Id = entity.IsYeriId;
            txtIsyeri.Text = entity.IsyeriAdi;
            txtGorev.Id = entity.GorevId;
            txtGorev.Text = entity.GorevAdi;
            txtBabaAdi.Text = entity.BabaAdi;
            txtAnaAdi.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtKimlikSeri.Text = entity.KimlikSeri;
            txtKimlikSiraNo.Text = entity.KimlikSiraNo;
            txtKimlikIl.Id = entity.KimlikIlId;
            txtKimlikIl.Text = entity.KimlikIlAdi;
            txtKimlikIlce.Id = entity.KimlikIlceId;
            txtKimlikIlce.Text = entity.KimlikIlceAdi;
            txtKimlikMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtKimlikCiltNo.Text = entity.KimlikCiltNo;
            txtKimlikAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtKimlikBireySiraNo.Text = entity.KimlikBireySiraNo;
            txtKimlikVerildigiYer.Text = entity.KimlikVerildigiYer;
            txtKimlikVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKimlikKayitNo.Text = entity.KimlikKayitNo;
            txtKimlikVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
=======
            var entity = (IletisimlerS)OldEntity;
            txtKod.Text = entity.Kod;
            txtBaslik.Text = entity.Baslik;
            txtIlgili.Text = entity.Ilgili;
            txtWeb.Text = entity.Web;
            txtKayitTuru.SelectedItem = entity.KayitTuru.ToName();
            if (entity.KayitTuru == KayitTuru.Kisi)
                txtKayitHesabi.Id = entity.KisiId ?? 0;
            else if (entity.KayitTuru == KayitTuru.Personel)
                txtKayitHesabi.Id = entity.PersonelId ?? 0;
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
            txtSosyalMedyaUrl.Text = entity.SosyalMedyaUrl;
            txtSosyalMedyaPlatformu.Id = entity.SosyalMedyaPlatformuId;
            txtSosyalMedyaPlatformu.Text = entity.SosyalMedyaPlatformuAdi;
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
<<<<<<< HEAD
            tglDurum.IsOn = entity.Durum;
=======
            tglVoip.IsOn = entity.VoipMi;
            txtVarsayilanMi.IsOn = entity.VarsayilanMi;
            tglDurum.IsOn = entity.Durum;
            ButonEnabledDurumu();
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        }

        protected override void GuncelNesneOlustur()
        {
<<<<<<< HEAD
            CurrentEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyAdi.Text,
                EvTel = txtEvTel.Text,
                IsTel1 = txtIsTel1.Text,
                Dahili1 = txtDahili1.Text,
                IsTel2 = txtIsTel2.Text,
                Dahili2 = txtDahili2.Text,
                CepTel1 = txtCepTel1.Text, 
                CepTel2 = txtCepTel2.Text,
                Web    = txtWeb.Text,
                Email = txtEmail.Text,
                IbanNo = txtIbanNo.Text,
                KartNo = txtKartNo.Text,
                EvAdres = txtEvAdres.Text,
                EvAdresIlId = txtEvAdresIl.Id,
                EvAdresIlceId = txtEvAdresIlce.Id,
                IsAdres = txtIsAdres.Text,
                IsAdresIlId = txtIsAdresIl.Id,
                IsAdresIlceId = txtIsAdresIlce.Id,
                MeslekId = txtMeslek.Id,
                IsYeriId = txtIsyeri.Id,
                GorevId = txtGorev.Id,
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                KimlikSeri = txtKimlikSeri.Text,
                KimlikSiraNo = txtKimlikSiraNo.Text,
                KimlikIlId = txtKimlikIl.Id,
                KimlikIlceId = txtKimlikIlce.Id,
                KimlikMahalleKoy = txtKimlikMahalleKoy.Text,
                KimlikCiltNo = txtKimlikCiltNo.Text,
                KimlikAileSiraNo = txtKimlikAileSiraNo.Text,
                KimlikBireySiraNo = txtKimlikBireySiraNo.Text,
                KimlikVerildigiYer = txtKimlikVerildigiYer.Text,
                KimlikVerilisNedeni = txtKimlikVerilisNedeni.Text,
                KimlikKayitNo = txtKimlikKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtKimlikVerilisTarihi.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
=======
            var kayitTuru = txtKayitTuru.SelectedItem?.ToString().GetEnum<KayitTuru>() ?? KayitTuru.Kisi;

            var kisiId = kayitTuru == KayitTuru.Kisi ? txtKayitHesabi.Id : null;
            var meslekId = kayitTuru == KayitTuru.Meslek ? txtKayitHesabi.Id : null;
            var personelId = kayitTuru == KayitTuru.Personel ? txtKayitHesabi.Id : null;
            CurrentEntity = new Iletisimler
            {
                Id = Id,
                Kod = txtKod.Text,
                Baslik = txtBaslik.Text,
                Ilgili = txtIlgili.Text,
                Oncelik = (short)txtOncelik.Value,
                Web = txtWeb.Text,
                KayitTuru = kayitTuru,
                KisiId = kisiId,
                PersonelId = personelId,
                MeslekId = meslekId,
                IletisimTuru = txtIletisimTurleri.Text.GetEnum<IletisimTuru>(),
                IzinDurumu = txtIzinDurumu.Text.GetEnum<IletisimDurumu>(),
                Kanallar = txtKanallar.EditValue?.ToString(),
                IzinTarihi = (DateTime?)txtIzinTarihi.EditValue,
                UlkeKodu = txtUlkeKodu.Text,
                Numara = txtTelefonVeFax.Text,
                DahiliNo = txtDahili.Text,
                EPosta = txtEPosta.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                SIPServer = txtSIPServer.Text,
                SIPKullaniciAdi = txtSIPKullaniciAdi.Text,
                SosyalMedyaUrl = txtSosyalMedyaUrl.Text,
                SosyalMedyaPlatformuId = txtSosyalMedyaPlatformu.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                VarsayilanMi = txtVarsayilanMi.IsOn,
                VoipMi = tglVoip.IsOn,
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
<<<<<<< HEAD

=======
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
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
<<<<<<< HEAD
                if (sender == txtEvAdresIl)
                    sec.Sec(txtEvAdresIl);
                else if (sender == txtEvAdresIlce)
                    sec.Sec(txtEvAdresIlce,txtEvAdresIl);
                else if (sender == txtIsAdresIl)
                    sec.Sec(txtIsAdresIl);
                else if (sender == txtIsAdresIlce)
                    sec.Sec(txtIsAdresIlce, txtIsAdresIl);
                else if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtIsyeri)
                    sec.Sec(txtIsyeri);
                else if (sender == txtGorev)
                    sec.Sec(txtGorev);
                else if (sender == txtKimlikIl)
                    sec.Sec(txtKimlikIl);
                else if (sender == txtKimlikIlce)
                    sec.Sec(txtKimlikIlce, txtKimlikIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);

        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtEvAdresIl && sender != txtIsAdresIl && sender != txtKimlikIl) return;

            if(sender == txtEvAdresIl)
                txtEvAdresIl.ControlEnabledChange(txtEvAdresIlce);
            else if(sender == txtIsAdresIl)
                txtIsAdresIl.ControlEnabledChange(txtIsAdresIlce);
            else if (sender == txtKimlikIl)
                txtKimlikIl.ControlEnabledChange(txtKimlikIlce);

        }
=======
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
                    else if (kayitTuru == KayitTuru.Personel)
                        sec.Sec(txtKayitHesabi, KartTuru.Personel);
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
            var personelId = kayitTuru == KayitTuru.Personel ? txtKayitHesabi.Id : null;

            if (kayitTuru == KayitTuru.Kisi && kisiId.HasValue && kisiId > 0)
            {
                var iletisimEntity = CurrentEntity as Iletisimler;
                if (iletisimEntity == null) return false;

                var entity = new IletisimBilgi
                {
                    KisiId = kisiId.Value,
                    IletisimlerId = iletisimEntity.Id,
                    Veli = true,
                    IletisimTuru = iletisimEntity.IletisimTuru
                };

                using (var context = new ERPContext())
                {
                    // Aynı iletişim kaydına bağlı olan tüm kayıtları bul (yani IletisimId eşleşenler)
                    var mevcutKayitlar = context.IletisimBilgi
                        .Where(x => x.IletisimlerId == iletisimEntity.Id)
                        .ToList();

                    // Eğer varsa hepsini sil
                    if (mevcutKayitlar.Any())
                    {
                        foreach (var kayit in mevcutKayitlar)
                        {
                            context.IletisimBilgi.Remove(kayit);
                        }
                        context.SaveChanges();
                    }

                    // Yeni kaydı ekle
                    var yeniKayit = new IletisimBilgi
                    {
                        KisiId = kisiId.Value,
                        IletisimlerId = iletisimEntity.Id,
                        Veli = true,
                        IletisimTuru = iletisimEntity.IletisimTuru
                    };

                    context.IletisimBilgi.Add(yeniKayit);
                    context.SaveChanges();
                }
            }
            if (kayitTuru == KayitTuru.Personel && personelId.HasValue && personelId > 0)
            {
                var iletisimEntity = CurrentEntity as Iletisimler;
                if (iletisimEntity == null) return false;

                var entity = new IletisimBilgi
                {
                    PersonelId = personelId.Value,
                    IletisimlerId = iletisimEntity.Id,
                    Veli = true,
                    IletisimTuru = iletisimEntity.IletisimTuru
                };

                using (var context = new ERPContext())
                {
                    // Aynı iletişim kaydına bağlı olan tüm kayıtları bul (yani IletisimId eşleşenler)
                    var mevcutKayitlar = context.IletisimBilgi
                        .Where(x => x.IletisimlerId == iletisimEntity.Id)
                        .ToList();

                    // Eğer varsa hepsini sil
                    if (mevcutKayitlar.Any())
                    {
                        foreach (var kayit in mevcutKayitlar)
                        {
                            context.IletisimBilgi.Remove(kayit);
                        }
                        context.SaveChanges();
                    }

                    // Yeni kaydı ekle
                    var yeniKayit = new IletisimBilgi
                    {
                        PersonelId = personelId.Value,
                        IletisimlerId = iletisimEntity.Id,
                        Veli = true,
                        IletisimTuru = iletisimEntity.IletisimTuru
                    };

                    context.IletisimBilgi.Add(yeniKayit);
                    context.SaveChanges();
                }
            }
            return true;
        }

>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
    }
}