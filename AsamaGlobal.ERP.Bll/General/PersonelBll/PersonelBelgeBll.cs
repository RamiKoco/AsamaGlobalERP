using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto.PersonelDto;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcYazilim.OgrenciTakip.Bll.General.PersonelBll
{
    public class PersonelBelgeBll : BaseHareketBll<PersonelBelge, OgrenciTakipContext>, IBaseHareketSelectBll<PersonelBelge>
    {

        public IEnumerable<BaseHareketEntity> List(Expression<Func<PersonelBelge, bool>> filter)
        {
            return List(filter, x => new PersonelBelgeL
            {
                Id = x.Id,
                PersonelId = x.PersonelId,
                BelgeNo = x.BelgeNo,
                VerilisTarihi = x.VerilisTarihi,
                GecerlilikTarihi = x.GecerlilikTarihi,        
                BelgeTuruId = x.BelgeTuruId,
                BelgeAdi= x.BelgeTuru.Ad,
                KurumlarId = x.KurumlarId,
                KurumAdi = x.Kurumlar.Ad,                
                Aciklama = x.Aciklama,
                
            }).ToList();

        }
    }
}