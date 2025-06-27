using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Yazar : BaseEntityDurum
    {
        public string YazarAdi { get; set; }
        public string KitapAdi { get; set; }
        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
        //public KitapTurleri KitapTurleri { get; set; } = KitapTurleri.Fiction;
        public long? KurguId { get; set; }
        public long? KitapTuruId { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public string Aciklama { get; set; }

        public Kurgu Kurgu { get; set; }
        public KitapTuru.KitapTuru KitapTuru { get; set; } // Fully qualify the KitapTuru type cccd
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
    }
}
