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
    public class CariSubelerBll : BaseGenelBll<CariSubeler>, IBaseGenelBll, IBaseCommonBll
    {
        public CariSubelerBll() : base(KartTuru.CariSubeler) { }

        public CariSubelerBll(Control ctrl) : base(ctrl, KartTuru.CariSubeler) { }

        public override BaseEntity Single(Expression<Func<CariSubeler, bool>> filter)
        {
            return BaseSingle(filter, x => new CariSubelerS
            {
                Id = x.Id,
                Kod = x.Kod,
                CariSubeAdi = x.CariSubeAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<CariSubeler, bool>> filter)
        {
            return BaseList(filter, x => new CariSubelerL
            {
                Id = x.Id,
                Kod = x.Kod,
                CariSubeAdi = x.CariSubeAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,                
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
