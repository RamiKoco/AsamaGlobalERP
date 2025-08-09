<<<<<<< HEAD
﻿using System;
=======
﻿using AbcYazilim.OgrenciTakip.Model.Dto.IletisimlerDto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.Base;
using System;
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
<<<<<<< HEAD
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Bll.General
{
    public class IletisimBll : BaseGenelBll<Iletisim>, IBaseGenelBll, IBaseCommonBll
    {
        public IletisimBll() : base(KartTuru.Iletisim)
        {
        }

        public IletisimBll(Control ctrl) : base(ctrl, KartTuru.Iletisim)
        {
        }

        public override BaseEntity Single(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseSingle(filter, x => new IletisimS
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumYeri = x.DogumYeri,
                DogumTarihi = x.DogumTarihi,
                KanGrubu = x.KanGrubu,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikIlId = x.KimlikIlId,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceId = x.KimlikIlceId,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                EvTel= x.EvTel,
                IsTel1 = x.IsTel1,
                IsTel2 = x.IsTel2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                CepTel1 = x.CepTel1,
                CepTel2 = x.CepTel2,
                Web = x.Web,
                Email = x.Email,
                EvAdres = x.EvAdres,
                EvAdresIlId = x.EvAdresIlId,
                EvAdresIlAdi = x.EvAdresIl.IlAdi,
                EvAdresIlceId = x.EvAdresIlceId,
                EvAdresIlceAdi = x.EvAdresIlce.IlceAdi,
                IsAdres = x.IsAdres,
                IsAdresIlId = x.IsAdresIlId,
                IsAdresIlAdi = x.IsAdresIl.IlAdi,
                IsAdresIlceId  = x.IsAdresIlceId,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                MeslekId = x.MeslekId,
                MeslekAdi = x.Meslek.MeslekAdi,
                IsYeriId = x.IsYeriId,
                IsyeriAdi = x.Isyeri.IsyeriAdi,
                GorevId = x.GorevId,
                GorevAdi = x.Gorev.GorevAdi,
                IbanNo = x.IbanNo,
                KartNo = x.KartNo,
=======

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IletisimlerBll : BaseGenelBll<Iletisimler>, IBaseGenelBll, IBaseCommonBll
    {
        public IletisimlerBll() : base(KartTuru.Iletisimler) { }
        public IletisimlerBll(Control ctrl) : base(ctrl, KartTuru.Iletisimler) { }

        public override BaseEntity Single(Expression<Func<Iletisimler, bool>> filter)
        {
            return BaseSingle(filter, x => new IletisimlerS
            {
                Id = x.Id,
                Kod = x.Kod,
                Baslik = x.Baslik,
                KayitTuru = x.KayitTuru,
                IletisimTuru = x.IletisimTuru,
                IzinDurumu = x.IzinDurumu,
                IletisimKanalTipi = x.IletisimKanalTipi,
                Kanallar = x.Kanallar,
                KisiId = x.KisiId,
                KisiAdi = x.Kisi.Ad,
                PersonelId = x.PersonelId,
                PersonelAdi = x.Personel.Ad,
                MeslekId = x.MeslekId,
                MeslekAdi = x.Meslek.MeslekAdi,
                UlkeKodu = x.UlkeKodu,
                Numara = x.Numara,
                DahiliNo = x.DahiliNo,
                EPosta = x.EPosta,
                KullaniciAdi = x.KullaniciAdi,
                SosyalMedyaUrl = x.SosyalMedyaUrl,
                SIPKullaniciAdi = x.SIPKullaniciAdi,
                SIPServer = x.SIPServer,
                Ilgili = x.Ilgili,
                Oncelik = x.Oncelik,
                VoipMi = x.VoipMi,
                VarsayilanMi = x.VarsayilanMi,
                AramaAktifMi = x.AramaAktifMi,
                SmsAktifMi = x.SmsAktifMi,
                WhatsAppAktifMi = x.WhatsAppAktifMi,
                EmailAktifMi = x.EmailAktifMi,
                SosyalMedyaPlatformuId = x.SosyalMedyaPlatformuId,
                SosyalMedyaPlatformuAdi = x.SosyalMedyaPlatformu.Ad,
                IzinTarihi = x.IzinTarihi,
                Web = x.Web,
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

<<<<<<< HEAD
        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseList(filter, x => new IletisimL
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumYeri = x.DogumYeri,
                DogumTarihi = x.DogumTarihi,
                KanGrubu = x.KanGrubu,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                EvTel = x.EvTel,
                IsTel1 = x.IsTel1,
                IsTel2 = x.IsTel2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                CepTel1 = x.CepTel1,
                CepTel2 = x.CepTel2,
                Web = x.Web,
                Email = x.Email,
                EvAdres = x.EvAdres,
                EvAdresIlAdi = x.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.EvAdresIlce.IlceAdi,
                IsAdres = x.IsAdres,
                IsAdresIlAdi = x.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.IsAdresIlce.IlceAdi,
                MeslekAdi = x.Meslek.MeslekAdi,
                IsyeriAdi = x.Isyeri.IsyeriAdi,
                GorevAdi = x.Gorev.GorevAdi,
                IbanNo = x.IbanNo,
                KartNo = x.KartNo,
=======
        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisimler, bool>> filter)
        {
            return BaseList(filter, x => new IletisimlerL
            {
                Id = x.Id,
                Kod = x.Kod,
                Baslik = x.Baslik,
                IletisimTuru = x.IletisimTuru,
                KayitTuru = x.KayitTuru,
                KisiAdi = x.Kisi.Ad,
                PersonelAdi = x.Personel.Ad,
                MeslekAdi = x.Meslek.MeslekAdi,
                UlkeKodu = x.UlkeKodu,
                Numara = x.Numara,
                DahiliNo = x.DahiliNo,
                EPosta = x.EPosta,
                KullaniciAdi = x.KullaniciAdi,
                SosyalMedyaUrl = x.SosyalMedyaUrl,
                SIPKullaniciAdi = x.SIPKullaniciAdi,
                SIPServer = x.SIPServer,
                Ilgili = x.Ilgili,
                Oncelik = x.Oncelik,
                VoipMi = x.VoipMi,
                VarsayilanMi = x.VarsayilanMi,
                IzinDurumu = x.IzinDurumu,
                IletisimKanalTipi = x.IletisimKanalTipi,
                Kanallar = x.Kanallar,
                AramaAktifMi = x.AramaAktifMi,
                SmsAktifMi = x.SmsAktifMi,
                WhatsAppAktifMi = x.WhatsAppAktifMi,
                EmailAktifMi = x.EmailAktifMi,
                SosyalMedyaPlatformuAdi = x.SosyalMedyaPlatformu.Ad,
                IzinTarihi = x.IzinTarihi,
                Web = x.Web,
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
