using AbcYazilim.OgrenciTakip.Common.Enums;
<<<<<<< HEAD
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsamaGlobal.ERP.Model.Entities.CariEntity.CariSube
=======
using AbcYazilim.OgrenciTakip.Model.Attributes;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities.CariEntity.CariSube
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
{
    public class CariSubeAdres : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Başlık", "txtBaslik")]
        public string Baslik { get; set; }

        [StringLength(50)]
        public string AdresNotu { get; set; }
        public string PostaKodu { get; set; }

        [StringLength(255)]
        public string Adres { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public AdresTipi AdresTipi { get; set; } = AdresTipi.Genel;

        public long CariSubelerId { get; set; }

        public long? UlkeId { get; set; }
        public long? IlId { get; set; }
        public long? IlceId { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? AdresTurleriId { get; set; }
        public decimal? Enlem { get; set; }
        public decimal? Boylam { get; set; }
        public bool VarsayilanMi { get; set; } = true;
        public bool VarsayilanFaturaMi { get; set; } = false;
        public bool VarsayilanSevkiyatMi { get; set; } = false;

        public CariSubeler CariSubeler { get; set; }
        public Ulke Ulke { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public AdresTurleri AdresTurleri { get; set; }
    }
}
