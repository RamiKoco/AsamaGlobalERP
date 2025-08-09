﻿using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AsamaGlobal.ERP.Bll.General
{
    public class BelgeTuruBll : BaseGenelBll<BelgeTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public BelgeTuruBll() : base(KartTuru.BelgeTuru) { }
        public BelgeTuruBll(Control ctrl) : base(ctrl, KartTuru.BelgeTuru) { }

        public override BaseEntity Single(Expression<Func<BelgeTuru, bool>> filter)
        {
            return BaseSingle(filter, x => new BelgeTuruS
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                KayitTuru = x.KayitTuru,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<BelgeTuru, bool>> filter)
        {
            return BaseList(filter, x => new BelgeTuruL
            {
                Id = x.Id,
                Kod = x.Kod,
                BelgeAdi = x.Ad,
                KayitTuru = x.KayitTuru,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
