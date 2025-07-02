using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Etiket : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Etiket Adı", "txtEtiketAdi")]
        public string EtiketAdi { get; set; }
        public KayitTuru KayitTuru { get; set; } = KayitTuru.Kisi;
        [StringLength(500)]
        public string Aciklama { get; set; }
        public long? RenkId { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long SubeId { get; set; }
        public long DonemId { get; set; }

        public Renk Renk { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }      
       

    }
}
