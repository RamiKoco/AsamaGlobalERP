using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Yazar: BaseEntityDurum
    {
        public string YazarAdi { get; set; }
        public string KitapAdi { get; set; }
        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
        //public KitapTurleri KitapTurleri { get; set; } = KitapTurleri.Fiction;
        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Aciklama { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}
