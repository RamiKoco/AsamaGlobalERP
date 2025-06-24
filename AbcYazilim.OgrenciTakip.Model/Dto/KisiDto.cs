using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KisiS : Kisi
    {
        public string KayitKaynakAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
    public class KisiL : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Aciklama { get; set; }
        public string KayitKaynakAdi { get; set; }
        public string MeslekAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
}
