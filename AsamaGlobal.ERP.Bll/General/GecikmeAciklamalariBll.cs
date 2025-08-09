using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Windows.Forms;

namespace AsamaGlobal.ERP.Bll.General
{
    public class GecikmeAciklamalariBll : BaseGenelBll<GecikmeAciklamalari>, IBaseCommonBll
    {
        public GecikmeAciklamalariBll() : base(KartTuru.Aciklama) { }
        public GecikmeAciklamalariBll(Control ctrl) : base(ctrl, KartTuru.Aciklama) { }

        public override BaseEntity Single(Expression<Func<GecikmeAciklamalari, bool>> filter)
        {
            return BaseSingle(filter, x => new GecikmeAciklamalariS
            {
                Id = x.Id,
                Kod = x.Kod,
                OdemeBilgileriId = x.OdemeBilgileriId,
                KullaniciAdi = x.Kullanici.Kod,
                TarihSaat = x.TarihSaat,
                Aciklama = x.Aciklama,

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<GecikmeAciklamalari, bool>> filter)
        {
            return BaseList(filter, x => new GecikmeAciklamalariL
            {
                Id = x.Id,
                Kod = x.Kod,
                KullaniciAdi = x.Kullanici.Kod,
                TarihSaat = x.TarihSaat,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
