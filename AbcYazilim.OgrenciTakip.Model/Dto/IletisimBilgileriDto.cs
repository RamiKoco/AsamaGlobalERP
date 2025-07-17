using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class IletisimBilgileriL : IletisimBilgileri, IBaseHareketEntity
    {      
        public string Baslik { get; set; }
        public string UlkeKodu { get; set; }
        public string Numara { get; set; }
        public string DahiliNo { get; set; }
        public string EPosta { get; set; }
        public DateTime? IzinTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string SosyalMedyaUrl { get; set; }
        public string SIPKullaniciAdi { get; set; }
        public string SIPServer { get; set; }
        public string Ilgili { get; set; }
        public string Web { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class IletisimBilgileriR
    {
        public string Baslik { get; set; }
        public string UlkeKodu { get; set; }
        public string Numara { get; set; }
        public string DahiliNo { get; set; }
        public string EPosta { get; set; }
        public DateTime? IzinTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string SosyalMedyaUrl { get; set; }
        public string SIPKullaniciAdi { get; set; }
        public string SIPServer { get; set; }
        public string Ilgili { get; set; }
        public string Web { get; set; }
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }

    }

}
