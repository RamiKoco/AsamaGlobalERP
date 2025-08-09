using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Data.Contexts;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Bll.General
{
    public class EvrakBilgileriBll : BaseHareketBll<EvrakBilgileri, ERPContext>, IBaseHareketSelectBll<EvrakBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
        {
            return List(filter, x => new EvrakBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                EvrakId = x.EvrakId,
                Kod = x.Evrak.Kod,
                EvrakAdi = x.Evrak.EvrakAdi

            }).ToList();
        }

    }
}
