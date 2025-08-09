using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Data.Contexts;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities.Base;
using AsamaGlobal.ERP.Model.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Linq;
using AsamaGlobal.ERP.Common.Enums;

namespace AsamaGlobal.ERP.Bll.General
{
    public class KullaniciBirimYetkileriBll : BaseHareketBll<KullaniciBirimYetkileri, ERPContext>, IBaseHareketSelectBll<KullaniciBirimYetkileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KullaniciBirimYetkileri, bool>> filter)
        {
            return List(filter, x => new KullaniciBirimYetkileriL
            {
                Id = x.Id,
                Kod = x.KartTuru == KartTuru.Sube ? x.Sube.Kod : x.Donem.Kod,
                KartTuru = x.KartTuru,
                SubeId = x.SubeId,
                SubeAdi = x.Sube.SubeAdi,
                DonemId = x.DonemId,
                DonemAdi = x.Donem.DonemAdi
            }).ToList();
        }

    }
}

