using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
   
    
    [NotMapped]
    public class YazarS : Yazar
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }

    }

    public class YazarL : BaseEntity
    {
        public string YazarAdi { get; set; }
        public string KitapAdi { get; set; }
        public DateTime Tarih { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }

    }
}
