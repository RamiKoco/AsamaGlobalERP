using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IletisimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriL
            {
                Id = x.Id,
                KisiId = (long)x.Iletisim.KisiId,
                IletisimId = x.IletisimId,
                Baslik = x.Iletisim.Baslik,
                UlkeKodu = x.Iletisim.UlkeKodu,
                Numara = x.Iletisim.Numara,
                DahiliNo = x.Iletisim.DahiliNo,
                EPosta = x.Iletisim.EPosta,
                Kanallar = x.Iletisim.Kanallar,
                KullaniciAdi = x.Iletisim.KullaniciAdi,
                SosyalMedyaUrl = x.Iletisim.SosyalMedyaUrl,
                SIPKullaniciAdi = x.Iletisim.SIPKullaniciAdi,
                SIPServer = x.Iletisim.SIPServer,
                Ilgili = x.Iletisim.Ilgili,
                Oncelik = x.Iletisim.Oncelik,
                VoipMi = x.Iletisim.VoipMi,
                VarsayilanMi = x.Iletisim.VarsayilanMi,
                AramaAktifMi = x.Iletisim.AramaAktifMi,
                SmsAktifMi = x.Iletisim.SmsAktifMi,
                WhatsAppAktifMi = x.Iletisim.WhatsAppAktifMi,
                EmailAktifMi = x.Iletisim.EmailAktifMi,
                Web = x.Iletisim.Web,
                Aciklama = x.Iletisim.Aciklama,
                IletisimTuruAdi=x.Iletisim.IletisimTuru,
                SosyalMedyaPlatformuAdi = x.Iletisim.SosyalMedyaPlatformu.Ad,
                IzinTarihi = x.Iletisim.IzinTarihi,
                IzinDurumu = x.Iletisim.IzinDurumu,               
                //MeslekAdi = x.Iletisim.Meslek.MeslekAdi,
                //IsyeriAdi = x.Iletisim.Isyeri.IsyeriAdi,
                //GorevAdi = x.Iletisim.Gorev.GorevAdi,
                Veli = x.Veli,
                IletisimTuru = x.IletisimTuru

            }).ToList();
        }

    }
}
