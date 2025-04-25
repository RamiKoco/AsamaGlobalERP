using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Kurgu : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kurgu Adı", "txtKurguAdi")]
        public string KurguAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        //[InverseProperty("Kurgu")]
        //public ICollection<KitapTuru> KitapTuru { get; set; }
    }
}
