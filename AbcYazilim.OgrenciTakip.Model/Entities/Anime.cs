using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Anime : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false), ZorunluAlan("Öğrenci No", "txtKod")]
        public override string Kod { get; set; }

        public long OgrenciId { get; set; }
   

        [StringLength(20)]
        public string OkulNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;

        public KayitSekli KayitSekli { get; set; } = KayitSekli.YeniKayit;
        public KayitDurumu KayitDurumu { get; set; } = KayitDurumu.KesinKayit;


        [ZorunluAlan("Sınıf Adı", "txtSinif")]
        public long SinifId { get; set; }
        public long? GeldigiOkulId { get; set; }      
        public long? YabanciDilId { get; set; }       
     
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
 
        public long SubeId { get; set; }
        public long DonemId { get; set; }

        public Ogrenci Ogrenci { get; set; }
        public Sinif Sinif { get; set; }
        public Okul GeldigiOkul { get; set; }
        public YabanciDil YabanciDil { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public Sube Sube { get; set; }
        public Donem Donem { get; set; }
    
    }
}
