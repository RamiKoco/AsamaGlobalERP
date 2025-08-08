using System;
using System.ComponentModel.DataAnnotations;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class BilgiNotlari:BaseHareketEntity
    {
        
        public long TahakkukId { get; set; }
        public long KisiId { get; set; }
        public long PersonelId { get; set; }
        public long CarilerId { get; set; }
        public long CariSubelerId { get; set; }
        public DateTime Tarih { get; set; }

        [Required,StringLength(1000)]
        public string BilgiNotu { get; set; }
       
    }
}
