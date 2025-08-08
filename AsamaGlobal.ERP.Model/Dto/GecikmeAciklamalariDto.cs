﻿using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class GecikmeAciklamalariS : GecikmeAciklamalari
    {
        public string KullaniciAdi { get; set; }
    }

    public class GecikmeAciklamalariL : BaseEntity
    {
        public int PortfoyNo { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime TarihSaat { get; set; }
        public string Aciklama { get; set; }
    }
}