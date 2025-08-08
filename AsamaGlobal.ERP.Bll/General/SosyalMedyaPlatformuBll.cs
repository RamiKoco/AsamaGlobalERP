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
    public class SosyalMedyaPlatformuBll : BaseGenelBll<SosyalMedyaPlatformu>, IBaseGenelBll, IBaseCommonBll
    {
        public SosyalMedyaPlatformuBll() : base(KartTuru.SosyalMedyaPlatformu) { }
        public SosyalMedyaPlatformuBll(Control ctrl) : base(ctrl, KartTuru.SosyalMedyaPlatformu) { }

        public override BaseEntity Single(Expression<Func<SosyalMedyaPlatformu, bool>> filter)
        {
            return BaseSingle(filter, x => new SosyalMedyaPlatformuS
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

        public override IEnumerable<BaseEntity> List(Expression<Func<SosyalMedyaPlatformu, bool>> filter)
        {
            return BaseList(filter, x => new SosyalMedyaPlatformuL
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
