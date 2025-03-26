using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
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
