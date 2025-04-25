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
        public string Aciklama { get; set; }

        public Kurgu Kurgu { get; set; }
        public AbcYazilim.OgrenciTakip.Model.Entities.KitapTuru.KitapTuru 
            KitapTuru { get; set; } // Fully qualify the KitapTuru type
    }
}
