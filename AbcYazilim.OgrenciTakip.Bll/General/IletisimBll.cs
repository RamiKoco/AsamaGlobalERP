using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Bll.General
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
                Baslik = x.Baslik,
                KayitTuru = x.KayitTuru,
                IletisimTuru = x.IletisimTuru,
                IzinDurumu = x.IzinDurumu,
                IletisimKanalTipi =x.IletisimKanalTipi,
                Kanallar=x.Kanallar,
                KisiId = x.KisiId,
                KisiAdi = x.Kisi.Ad,
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
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseList(filter, x => new IletisimL
            {
                Id = x.Id,
                Kod = x.Kod,
                Baslik = x.Baslik,
                IletisimTuru = x.IletisimTuru,
                KayitTuru = x.KayitTuru,
                KisiAdi = x.Kisi.Ad,
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
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }

   
    }
}
