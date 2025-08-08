using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class YazarBll : BaseGenelBll<Yazar>, IBaseGenelBll, IBaseCommonBll
    {
        public YazarBll() : base(KartTuru.Yazar) { }
        public YazarBll(Control ctrl) : base(ctrl, KartTuru.Yazar) { }


        public override BaseEntity Single(Expression<Func<Yazar, bool>> filter)
        {
            return BaseSingle(filter, x => new YazarS
            {
                Id = x.Id,
                Kod = x.Kod,
                YazarAdi = x.YazarAdi,
                KitapAdi = x.KitapAdi,
                Tarih = x.Tarih,
                KurguId = x.KurguId,
                KurguAdi = x.Kurgu.KurguAdi,
                KitapTuruId = x.KitapTuruId,
                KitapTuruAdi = x.KitapTuru.KitapTuruAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Yazar, bool>> filter)
        {
            return BaseList(filter, x => new YazarL
            {
                Id = x.Id,
                Kod = x.Kod,
                YazarAdi = x.YazarAdi,
                KitapAdi = x.KitapAdi,
                Tarih = x.Tarih,
                KurguAdi = x.Kurgu.KurguAdi,
                KitapTuruAdi = x.KitapTuru.KitapTuruAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
