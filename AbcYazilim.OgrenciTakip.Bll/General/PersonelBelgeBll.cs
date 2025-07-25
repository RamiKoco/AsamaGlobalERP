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

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class PersonelBelgeBll : BaseHareketBll<PersonelBelge, OgrenciTakipContext>, IBaseHareketSelectBll<PersonelBelge>
    {

        public IEnumerable<BaseHareketEntity> List(Expression<Func<PersonelBelge, bool>> filter)
        {
            return List(filter, x => new PersonelBelgeL
            {
                Id = x.Id,
                PersonelId = x.PersonelId,
                Tarih = x.Tarih,        
                BelgeTuruId = x.BelgeTuruId,
                BelgeAdi= x.BelgeTuru.Ad,
                KurumlarId = x.KurumlarId,
                KurumAdi = x.Kurumlar.Ad,                
                Aciklama = x.Aciklama,
                
            }).ToList();

        }
    }
}
