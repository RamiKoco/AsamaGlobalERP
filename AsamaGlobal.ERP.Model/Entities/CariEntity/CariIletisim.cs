using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsamaGlobal.ERP.Model.Entities.CariEntity
{
    public class CariIletisim : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [Required, StringLength(30), ZorunluAlan("Baslik", "txtBaslik")]
        public string Baslik { get; set; }
        public IletisimTuru IletisimTuru { get; set; } = IletisimTuru.Telefon;
        public IletisimDurumu IzinDurumu { get; set; } = IletisimDurumu.Belirtilmedi;
        public IletisimKanalTipi IletisimKanalTipi { get; set; } = IletisimKanalTipi.Arama;

        [StringLength(6)]
        public string UlkeKodu { get; set; }

        [StringLength(17)]
        public string Numara { get; set; }

        [StringLength(10)]
        public string DahiliNo { get; set; }
        [StringLength(30)]
        public string EPosta { get; set; }
        public string Kanallar { get; set; }
        public bool Arama { get; set; }
        public bool Sms { get; set; }
        public bool Whatsapp { get; set; }
        public bool EPBool { get; set; }
        public string KullaniciAdi { get; set; }
        public string SosyalMedyaUrl { get; set; }
        public string SIPKullaniciAdi { get; set; }
        public string SIPServer { get; set; }
        public string Ilgili { get; set; }
        public short Oncelik { get; set; }
        public bool VoipMi { get; set; } = false;
        [Column(TypeName = "date")]
        public DateTime? IzinTarihi { get; set; }

        [StringLength(50)]
        public string Web { get; set; }
        public long CarilerId { get; set; }
        public long? SosyalMedyaPlatformuId { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public Cariler Cariler { get; set; }
        public SosyalMedyaPlatformu SosyalMedyaPlatformu { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
    }
}
