﻿using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Pozisyon : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Pozisyon Adı", "txtPozisyonAdi")]
        public string Ad { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }
        public long? RenkId { get; set; }

        public Renk Renk { get; set; }
    }
}
