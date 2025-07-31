using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto.KisiDto;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities.Kisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.OgrenciTakip.Bll.General.KisiBll
{
    public class KisiEtiketBll : BaseHareketBll<KisiEtiket, OgrenciTakipContext>, IBaseHareketSelectBll<KisiEtiket>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KisiEtiket, bool>> filter)
        {
            return List(filter, x => new KisiEtiketL
            {
                Id = x.Id,
                KisiId = x.KisiId,              
                EtiketId=x.EtiketId,
                EtiketAdi=x.Etiket.EtiketAdi,               

            }).ToList();
        }
    }
}
