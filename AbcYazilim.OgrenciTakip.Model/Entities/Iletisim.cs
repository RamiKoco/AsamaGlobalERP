using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Iletisim:BaseEntityDurum
    {
        [Index("IX_Kod",IsUnique = true)]
        public override string Kod { get; set; }     

        [Required,StringLength(30), ZorunluAlan("Baslik", "txtBaslik")]
        public string Baslik { get; set; }
        public IletisimTuru IletisimTuru { get; set; } = IletisimTuru.Telefon;

        [StringLength(6)]
        public string UlkeKodu { get; set; }

        [StringLength(17)]
        public string Numara { get; set; }      

        [StringLength(10)]
        public string DahiliNo { get; set; }
        [StringLength(30)]
        public string EPosta { get; set; }


        [StringLength(50)]
        public string Web { get; set; }

       

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }

    }
}
