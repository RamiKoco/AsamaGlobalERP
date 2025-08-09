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
    public class KurumlarBll : BaseGenelBll<Kurumlar>, IBaseGenelBll, IBaseCommonBll
    {
        public KurumlarBll() : base(KartTuru.Kurumlar) { }
        public KurumlarBll(Control ctrl) : base(ctrl, KartTuru.Kurumlar) { }
        public override BaseEntity Single(Expression<Func<Kurumlar, bool>> filter)
        {
            return BaseSingle(filter, x => new KurumlarS
            {

                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                KurumTuruId = x.KurumTuruId,
                KurumTuruAdi = x.KurumTuru.Ad,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Kurumlar, bool>> filter)
        {
            return BaseList(filter, x => new KurumlarL
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                KurumTuruAdi = x.KurumTuru.Ad,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
