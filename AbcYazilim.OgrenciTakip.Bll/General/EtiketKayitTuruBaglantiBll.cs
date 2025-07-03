using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class EtiketKayitTuruBaglantiBll : BaseHareketBll<EtiketKayitTuruBaglanti, OgrenciTakipContext>, IBaseHareketSelectBll<EtiketKayitTuruBaglanti>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EtiketKayitTuruBaglanti, bool>> filter)
        {
            return List(filter, x => new EtiketKayitTuruBaglantiL
            {
                Id = x.Id,
                EtiketId = x.EtiketId,
                EtiketAdi = x.Etiket.EtiketAdi,
                KayitTuru=x.KayitTuru

            }).ToList();
        }
    }
}
