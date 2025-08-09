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
    public class SinavBilgileriBll : BaseHareketBll<SinavBilgileri, ERPContext>, IBaseHareketSelectBll<SinavBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<SinavBilgileri, bool>> filter)
        {
            return List(filter, x => new SinavBilgileriL
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                SinavAdi = x.SinavAdi,
                PuanTuru = x.PuanTuru,
                Puan = x.Puan,
                Sira = x.Sira,
                Yuzde = x.Yuzde
            }).ToList();

        }
    }
}
