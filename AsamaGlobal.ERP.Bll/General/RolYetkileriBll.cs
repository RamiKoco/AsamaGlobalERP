using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Data.Contexts;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities.Base;
using AsamaGlobal.ERP.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AsamaGlobal.ERP.Common.Functions;

namespace AsamaGlobal.ERP.Bll.General
{
    public class RolYetkileriBll : BaseHareketBll<RolYetkileri, ERPContext>, IBaseHareketSelectBll<RolYetkileri>
    {
        public BaseHareketEntity Single(Expression<Func<RolYetkileri, bool>> filter)
        {
            return Single(filter, x => x);
          
        }
        public IEnumerable<BaseHareketEntity> List(Expression<Func<RolYetkileri, bool>> filter)
        {
            return List(filter, x => new RolYetkileriL
            {
                Id = x.Id,
                RolId = x.RolId,
                KartTuru = x.KartTuru,
                Gorebilir = x.Gorebilir,
                Ekleyebilir = x.Ekleyebilir,
                Degistirebilir = x.Degistirebilir,
                Silebilir = x.Silebilir

            }).AsEnumerable().OrderBy(x=> x.KartTuru.ToName()).ToList();
        }
    }
}

