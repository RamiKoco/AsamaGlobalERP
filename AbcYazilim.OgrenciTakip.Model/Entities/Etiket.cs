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
        public string Ad { get; set; }
        public KayitTuru KayitTuru { get; set; } = KayitTuru.Kisi;
        public long? RenkId { get; set; }

        public Renk Renk { get; set; }

    }
}
