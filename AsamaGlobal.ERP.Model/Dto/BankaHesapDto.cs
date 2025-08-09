using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class BankaHesapS:BankaHesap
    {
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class BankaHesapL : BaseEntity
    {
        public string HesapAdi { get; set; }

        public BankaHesapTuru HesapTuru { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }
        public string HesapNo { get; set; }
        public string IbanNo { get; set; }
        public byte BlokeGunSayisi { get; set; }
        public string IsyeriNo { get; set; }
        public string TerminalNo { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string Aciklama { get; set; }

    }
}
