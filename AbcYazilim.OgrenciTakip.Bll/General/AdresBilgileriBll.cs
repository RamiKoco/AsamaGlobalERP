using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class AdresBilgileriBll : BaseGenelBll<AdresBilgileri>, IBaseGenelBll, IBaseCommonBll
    {
        public AdresBilgileriBll() : base(KartTuru.AdresBilgileri) { }
        public AdresBilgileriBll(Control ctrl) : base(ctrl, KartTuru.AdresBilgileri) { }

        public override BaseEntity Single(Expression<Func<AdresBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new AdresBilgileriS
            {
                Id = x.Id,
                Kod = x.Kod,
                Baslik=x.Baslik,
                KayitTuru=x.KayitTuru,
                AdresTipi = x.AdresTipi,
                AdresNotu=x.AdresNotu,
                Adres=x.Adres,
                Aciklama=x.Aciklama,                
                PostaKodu=x.PostaKodu,               
                Enlem = x.Enlem ?? 0,
                Boylam = x.Boylam ?? 0,
                VarsayilanMi =x.VarsayilanMi,
                VarsayilanFaturaMi=x.VarsayilanFaturaMi,
                VarsayilanSevkiyatMi=x.VarsayilanSevkiyatMi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                AdresTurleriId = x.AdresTurleriId,
                AdresTurleriAdi = x.AdresTurleri.Ad,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<AdresBilgileri, bool>> filter)
        {
            return BaseList(filter, x => new AdresBilgileriL
            {
                Id = x.Id,
                Kod = x.Kod,
                Baslik = x.Baslik,
                KayitTuru = x.KayitTuru,
                AdresTipi = x.AdresTipi,
                AdresNotu = x.AdresNotu,
                Adres = x.Adres,
                Aciklama = x.Aciklama,
                PostaKodu = x.PostaKodu,            
                Enlem = x.Enlem ?? 0,
                Boylam = x.Boylam ?? 0,
                VarsayilanMi = x.VarsayilanMi,
                VarsayilanFaturaMi = x.VarsayilanFaturaMi,
                VarsayilanSevkiyatMi = x.VarsayilanSevkiyatMi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,              
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                AdresTurleriAdi = x.AdresTurleri.Ad,

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
