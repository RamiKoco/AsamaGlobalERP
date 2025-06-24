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
    public class KisiBll : BaseGenelBll<Kisi>, IBaseGenelBll, IBaseCommonBll
    {
        public KisiBll() : base(KartTuru.Kisi) { }
        public KisiBll(Control ctrl) : base(ctrl, KartTuru.Kisi) { }
        public override BaseEntity Single(Expression<Func<Kisi, bool>> filter)
        {
            return BaseSingle(filter, x => new KisiS
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Cinsiyet = x.Cinsiyet,
                DogumTarihi = x.DogumTarihi,
                Aciklama = x.Aciklama,
                KayitKaynakId = x.KayitKaynakId,
                KayitKaynakAdi = x.KayitKaynak.KayitKaynakAdi,
                KisiGrubuId = x.KisiGrubuId,
                KisiGrubuAdi = x.KisiGrubu.GrupAdi,
                MeslekId = x.MeslekId,
                MeslekAdi = x.Meslek.MeslekAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Kisi, bool>> filter)
        {
            return BaseList(filter, x => new KisiL
            {
                Id = x.Id,
                Kod = x.Kod,             
                Ad = x.Ad,
                Soyad = x.Soyad,
                Cinsiyet = x.Cinsiyet,               
                DogumTarihi = x.DogumTarihi,
                Aciklama = x.Aciklama,
                KayitKaynakAdi = x.KayitKaynak.KayitKaynakAdi,
                MeslekAdi = x.Meslek.MeslekAdi,
                KisiGrubuAdi = x.KisiGrubu.GrupAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
              

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
