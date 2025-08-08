using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto.CariDto.CariSubeDto;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities.CariEntity.CariSube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
namespace AbcYazilim.OgrenciTakip.Bll.General.CarilerBll.CariSubeBll
{
    public class CariSubeIletisimBll : BaseGenelBll<CariSubeIletisim>, IBaseGenelBll, IBaseCommonBll
    {
        public CariSubeIletisimBll() : base(KartTuru.CariSubeIletisim) { }

        public CariSubeIletisimBll(Control ctrl) : base(ctrl, KartTuru.CariSubeIletisim) { }
        public override BaseEntity Single(Expression<Func<CariSubeIletisim, bool>> filter)
        {
            return BaseSingle(filter, x => new CariSubeIletisimS
            {

                Id = x.Id,
                Kod = x.Kod,
                IletisimTuru = x.IletisimTuru,
                IzinDurumu = x.IzinDurumu,
                IletisimKanalTipi = x.IletisimKanalTipi,
                Kanallar = x.Kanallar,
                Arama = x.Arama,
                Sms = x.Sms,
                Whatsapp = x.Whatsapp,
                EPBool = x.EPBool,
                Baslik = x.Baslik,
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
        public override IEnumerable<BaseEntity> List(Expression<Func<CariSubeIletisim, bool>> filter)
        {
            return BaseList(filter, x => new CariSubeIletisimL
            {
                Id = x.Id,
                Kod = x.Kod,
                Baslik = x.Baslik,
                IletisimTuru = x.IletisimTuru,
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
                IzinDurumu = x.IzinDurumu,
                IletisimKanalTipi = x.IletisimKanalTipi,
                Kanallar = x.Kanallar,
                Arama = x.Arama,
                Sms = x.Sms,
                Whatsapp = x.Whatsapp,
                EPBool = x.EPBool,
                SosyalMedyaPlatformuAdi = x.SosyalMedyaPlatformu.Ad,
                IzinTarihi = x.IzinTarihi,
                Web = x.Web,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
