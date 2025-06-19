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
    public class RamiDenemeBll : BaseGenelBll<RamiDeneme>, IBaseGenelBll, IBaseCommonBll
    {
        public RamiDenemeBll() : base(KartTuru.Rami) { }
        public RamiDenemeBll(Control ctrl) : base(ctrl, KartTuru.Rami) { }
        public override BaseEntity Single(Expression<Func<RamiDeneme, bool>> filter)
        {
            return BaseSingle(filter, x => new RamiDenemeS
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                Soyadi = x.Soyadi,
                Cinsiyet = x.Cinsiyet,
                Telefon = x.Telefon,
                DogumTarihi = x.DogumTarihi,
                KimlikIlId = x.KimlikIlId,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceId = x.KimlikIlceId,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                Aciklama =x.Aciklama,
                Resim = x.Resim,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,             
                Durum = x.Durum

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<RamiDeneme, bool>> filter)
        {
            return BaseList(filter, x => new RamiDenemeL
            {
                Id = x.Id,
                Kod = x.Kod,             
                Ad = x.Ad,
                Soyadi = x.Soyadi,
                Cinsiyet = x.Cinsiyet,
                Telefon = x.Telefon,
                DogumTarihi = x.DogumTarihi,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                Aciklama =x.Aciklama,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
