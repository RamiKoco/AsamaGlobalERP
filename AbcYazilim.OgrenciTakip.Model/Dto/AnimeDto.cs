using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class AnimeS:Anime
    {

        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }
        public string YabanciDilAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
    public class AnimeL:BaseEntity
    {
        public long OgrenciId { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string OkulNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public string SinifAdi { get; set; }
        public string GeldigiOkulAdi { get; set; }    
        public string YabanciDilAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string SubeAdi { get; set; }
        public bool Durum { get; set; }
    }
}
