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
                IzinTarihi = x.Iletisim.IzinTarihi,
                KullaniciAdi = x.Iletisim.KullaniciAdi,
                SosyalMedyaUrl = x.Iletisim.SosyalMedyaUrl,
                SIPKullaniciAdi = x.Iletisim.SIPKullaniciAdi,
                SIPServer = x.Iletisim.SIPServer,
                Ilgili = x.Iletisim.Ilgili,
                Web = x.Iletisim.Web,
                              
                //IsAdresIlAdi = x.Iletisim.IsAdresIl.IlAdi,
                //IsAdresIlceAdi = x.Iletisim.IsAdresIlce.IlceAdi,
                //YakinlikId = x.YakinlikId,
                //YakinlikAdi = x.Yakinlik.YakinlikAdi,
                //MeslekAdi = x.Iletisim.Meslek.MeslekAdi,
                //IsyeriAdi = x.Iletisim.Isyeri.IsyeriAdi,
                //GorevAdi = x.Iletisim.Gorev.GorevAdi,
                Veli = x.Veli,
                IletisimTuru = x.IletisimTuru

            }).ToList();
        }

    }
}
