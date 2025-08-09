﻿using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class EtiketS : Etiket
    {
        public string RenkAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
    public class EtiketL : BaseEntity
    {
        public string EtiketAdi { get; set; }
        public KayitTuru KayitTuru { get; set; }
        public string Aciklama { get; set; }
        public string RenkAdi { get; set; }
        public int YaziRgbKodu { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
}
