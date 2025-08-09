using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Uyruk : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Uyruk Adı", "txtUyrukAdi")]
        public string Ad { get; set; }
        public long? UlkeId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public Ulke Ulke { get; set; }
    }
}
