using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AbcYazilim.OgrenciTakip.Common.Functions;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class RolYetkileriBll : BaseHareketBll<RolYetkileri, OgrenciTakipContext>, IBaseHareketSelectBll<RolYetkileri>
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

