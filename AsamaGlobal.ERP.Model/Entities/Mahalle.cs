using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Mahalle : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Mahalle Adı", "txtMahalleAdi")]
        public string MahalleAdi { get; set; }
        public long IlceId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
        public Ilce Ilce { get; set; }
    }
}
