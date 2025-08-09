using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
<<<<<<< HEAD
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Data.Contexts;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Bll.General
{
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, ERPContext>, IBaseHareketSelectBll<IletisimBilgileri>
=======
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IletisimBilgileri>
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriL
            {
                Id = x.Id,
<<<<<<< HEAD
                TahakkukId = x.TahakkukId,
                IletisimId = x.IletisimId,
                TcKimlikNo = x.Iletisim.TcKimlikNo,
                Adi = x.Iletisim.Adi,
                Soyadi = x.Iletisim.Soyadi,
                EvTel = x.Iletisim.EvTel,
                IsTel1 = x.Iletisim.IsTel1,
                IsTel2 = x.Iletisim.IsTel2,
                CepTel1 = x.Iletisim.CepTel1,
                CepTel2 = x.Iletisim.CepTel2,
                EvAdres = x.Iletisim.EvAdres,
                EvAdresIlAdi = x.Iletisim.EvAdresIl.IlAdi,
                EvAdresIlceAdi = x.Iletisim.EvAdresIlce.IlceAdi,
                IsAdres = x.Iletisim.IsAdres,
                IsAdresIlAdi = x.Iletisim.IsAdresIl.IlAdi,
                IsAdresIlceAdi = x.Iletisim.IsAdresIlce.IlceAdi,
                YakinlikId = x.YakinlikId,
                YakinlikAdi = x.Yakinlik.YakinlikAdi,
                MeslekAdi = x.Iletisim.Meslek.MeslekAdi,
                IsyeriAdi = x.Iletisim.Isyeri.IsyeriAdi,
                GorevAdi = x.Iletisim.Gorev.GorevAdi,
                Veli = x.Veli,
                FaturaAdresi = x.FaturaAdresi
=======
                KisiId = (long)x.Iletisim.KisiId,
                PersonelId = (long)x.Iletisim.PersonelId,
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
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec

            }).ToList();
        }

    }
}
