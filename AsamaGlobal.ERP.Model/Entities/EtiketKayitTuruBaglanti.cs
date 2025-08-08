
using AbcYazilim.OgrenciTakip.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class EtiketKayitTuruBaglanti 
    {
        [Key] 
        public long Id { get; set; }
        public long EtiketId { get; set; }
        public long KayitId { get; set; }
        public KayitTuru KayitTuru { get; set; }

        public virtual Etiket Etiket { get; set; }

     
    }
}
