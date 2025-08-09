using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Bll.General
{
    public class HizmetBll:BaseGenelBll<Hizmet>,IBaseCommonBll
    {
        public HizmetBll() : base(KartTuru.Hizmet) { }
        public HizmetBll(Control ctrl) : base(ctrl, KartTuru.Hizmet) { }

        public override BaseEntity Single(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseSingle(filter, x => new HizmetS
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi = x.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTuruAdi = x.HizmetTuru.HizmetTuruAdi,
                BaslamaTarihi = x.BaslamaTarihi,
                BitisTarihi = x.BaslamaTarihi,
                Ucret = x.Ucret,
                SubeId = x.SubeId,
                DonemId = x.DonemId,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Hizmet, bool>> filter)
        {
            return BaseList(filter, x => new HizmetL
            {
                Id = x.Id,
                Kod = x.Kod,
                HizmetAdi = x.HizmetAdi,
                HizmetTuruId = x.HizmetTuruId,
                HizmetTuruAdi = x.HizmetTuru.HizmetTuruAdi,
                HizmetTipi = x.HizmetTuru.HizmetTipi,
                BaslamaTarihi = x.BaslamaTarihi,
                BitisTarihi = x.BitisTarihi,
                Ucret = x.Ucret,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
