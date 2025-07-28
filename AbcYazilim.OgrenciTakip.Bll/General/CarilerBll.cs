using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Data.Contexts;
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
    public class CarilerBll : BaseGenelBll<Cariler>, IBaseGenelBll, IBaseCommonBll
    {
        public CarilerBll() : base(KartTuru.Cariler) { }
        public CarilerBll(Control ctrl) : base(ctrl, KartTuru.Cariler) { }

        public override BaseEntity Single(Expression<Func<Cariler, bool>> filter)
        {
            return BaseSingle(filter, x => new CarilerS
            {

                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                KimlikNo = x.KimlikNo,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Sahis = x.Sahis,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                VergiKodu = x.VergiKodu,
                KimlikTuruId = x.KimlikTuruId,
                KimlikTuruAdi = x.KimlikTuru.KimlikAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Id = x.OzelKod3Id,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Id = x.OzelKod4Id,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Id = x.OzelKod5Id,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Cariler, bool>> filter)
        {
            return BaseList(filter, x => new CarilerL
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                KimlikNo = x.KimlikNo,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Sahis = x.Sahis,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                VergiKodu = x.VergiKodu,
                KimlikTuruAdi = x.KimlikTuru.KimlikAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                OzelKod3Adi = x.OzelKod3.OzelKodAdi,
                OzelKod4Adi = x.OzelKod4.OzelKodAdi,
                OzelKod5Adi = x.OzelKod5.OzelKodAdi,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }

        public KimlikTuru KimlikTuruGetir(long? kimlikTuruId)
        {
            if (kimlikTuruId == null) return null;

            using (var db = new OgrenciTakipContext())
            {
                return db.KimlikTuru.SingleOrDefault(x => x.Id == kimlikTuruId);
            }
        }
    }
}
