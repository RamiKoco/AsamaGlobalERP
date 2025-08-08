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
    public class AdresTurleriBll : BaseGenelBll<AdresTurleri>, IBaseGenelBll, IBaseCommonBll
    {
        public AdresTurleriBll() : base(KartTuru.AdresTurleri) { }
        public AdresTurleriBll(Control ctrl) : base(ctrl, KartTuru.AdresTurleri) { }

        public override BaseEntity Single(Expression<Func<AdresTurleri, bool>> filter)
        {
            return BaseSingle(filter, x => new AdresTurleriS
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,               
                Aciklama = x.Aciklama,               
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<AdresTurleri, bool>> filter)
        {
            return BaseList(filter, x => new AdresTurleriL
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,              
                Aciklama = x.Aciklama,               
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
