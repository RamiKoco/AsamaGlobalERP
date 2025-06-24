using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Kisi : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdi")]
        public string Ad { get; set; }

        [Required, StringLength(30), ZorunluAlan("SoyAdı", "txtSoyAdi")]
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyet { get; set; } = Cinsiyet.Erkek;
        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        //public long? SorumluPersonelId { get; set; }        
        //public long? EtiketId { get; set; }
        //public long? GrupId { get; set; }
        public long? KayitKaynakId { get; set; }
        public long? MeslekId { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        public KayitKaynak KayitKaynak { get; set; }
        public Meslek Meslek { get; set; }       
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
    }
}
