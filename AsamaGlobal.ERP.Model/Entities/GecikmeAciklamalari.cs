﻿using System;
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class GecikmeAciklamalari : BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public int OdemeBilgileriId { get; set; }
        public long KullaniciId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime TarihSaat { get; set; }

        [Required, StringLength(1000), ZorunluAlan("Açıklama", "txtAciklama")]
        public string Aciklama { get; set; }

        public OdemeBilgileri OdemeBilgileri { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
