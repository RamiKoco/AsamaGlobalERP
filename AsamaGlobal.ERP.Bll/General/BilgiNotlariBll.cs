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
    public class BilgiNotlariBll : BaseHareketBll<BilgiNotlari, ERPContext>, IBaseHareketSelectBll<BilgiNotlari>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<BilgiNotlari, bool>> filter)
        {
            return List(filter, x => new BilgiNotlariL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                KisiId = x.KisiId,
                PersonelId=x.PersonelId,
                CarilerId = x.CarilerId,
                CariSubelerId = x.CariSubelerId,
                Tarih = x.Tarih,
                BilgiNotu = x.BilgiNotu             

            }).ToList();
        }

    }
}
