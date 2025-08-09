using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto.CariDto.CariSubeDto;
using AsamaGlobal.ERP.Model.Entities.Base;
using AsamaGlobal.ERP.Model.Entities.CariEntity.CariSube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.General.CarilerBll;
using AsamaGlobal;
using AsamaGlobal.ERP;
using AsamaGlobal.ERP.Bll;
using AsamaGlobal.ERP.Bll.General;

namespace AsamaGlobal.ERP.Bll.General.CarilerBll.CariSubeBll
{
    public class CariSubelerBll : BaseGenelBll<CariSubeler>, IBaseCommonBll
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
                Ilgili = x.Ilgili,
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
                Ilgili = x.Ilgili,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
