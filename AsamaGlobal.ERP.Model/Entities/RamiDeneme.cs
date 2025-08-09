using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class RamiDeneme : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(30), ZorunluAlan("Ad", "txtAd")]
        public string Ad { get; set; }
        [Required, StringLength(30), ZorunluAlan("SoyAdı", "txtSoyAdi")]
        public string Soyadi { get; set; }

        public Cinsiyet Cinsiyet { get; set; } = Cinsiyet.Erkek;
        [StringLength(17)]
        public string Telefon { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }
        public long? KimlikIlId { get; set; }
        public long? KimlikIlceId { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
        [Column(TypeName = "image")]
        public byte[] Resim { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }


        public Il KimlikIl { get; set; }
        public Ilce KimlikIlce { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
    }
}
