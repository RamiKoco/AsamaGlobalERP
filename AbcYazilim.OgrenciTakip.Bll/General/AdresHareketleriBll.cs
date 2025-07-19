using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class AdresHareketleriBll : BaseHareketBll<AdresHareketleri, OgrenciTakipContext>, IBaseHareketSelectBll<AdresHareketleri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<AdresHareketleri, bool>> filter)
        {
            return List(filter, x => new AdresHareketleriL
            {
                Id = x.Id,
                KisiId = (long)x.AdresBilgileri.KisiId,
                AdresBilgileriId = x.AdresBilgileriId,
                Baslik = x.AdresBilgileri.Baslik,
                KayitTuru = x.AdresBilgileri.KayitTuru,
                AdresTipi = x.AdresBilgileri.AdresTipi,
                AdresNotu = x.AdresBilgileri.AdresNotu,
                Adres = x.AdresBilgileri.Adres,
                Aciklama = x.AdresBilgileri.Aciklama,
                PostaKodu = x.AdresBilgileri.PostaKodu,
                Enlem = x.AdresBilgileri.Enlem ?? 0,
                Boylam = x.AdresBilgileri.Boylam ?? 0,
                VarsayilanMi = x.AdresBilgileri.VarsayilanMi,
                VarsayilanFaturaMi = x.AdresBilgileri.VarsayilanFaturaMi,
                VarsayilanSevkiyatMi = x.AdresBilgileri.VarsayilanSevkiyatMi,     
                UlkeAdi = x.AdresBilgileri.Ulke.UlkeAdi,              
                IlAdi = x.AdresBilgileri.Il.IlAdi,              
                IlceAdi = x.AdresBilgileri.Ilce.IlceAdi,               
                OzelKod1Adi = x.AdresBilgileri.OzelKod1.OzelKodAdi,              
                OzelKod2Adi = x.AdresBilgileri.OzelKod2.OzelKodAdi,               
                AdresTurleriAdi = x.AdresBilgileri.AdresTurleri.Ad               

            }).ToList();
        }
    }
}
