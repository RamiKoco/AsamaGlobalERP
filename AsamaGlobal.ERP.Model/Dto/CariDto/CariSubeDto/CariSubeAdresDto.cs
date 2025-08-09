using AbcYazilim.OgrenciTakip.Common.Enums;
<<<<<<< HEAD
using AsamaGlobal.ERP.Model.Entities.Base;
using AsamaGlobal.ERP.Model.Entities.CariEntity.CariSube;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsamaGlobal.ERP.Model.Dto.CariDto.CariSubeDto
{
    [NotMapped]
    public class CariSubeAdresS: CariSubeAdres
=======
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.Model.Entities.CariEntity.CariSube;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto.CariDto.CariSubeDto
{

    [NotMapped]
    public class CariSubeAdresS : CariSubeAdres
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
    {
        public string AdresTurleriAdi { get; set; }
        public string UlkeAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
<<<<<<< HEAD
    public class CariSubeAdresL: BaseEntity
=======
    public class CariSubeAdresL : BaseEntity
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
    {
        public string UlkeAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string AdresTurleriAdi { get; set; }
        public string Aciklama { get; set; }
        public string Baslik { get; set; }
        public string AdresNotu { get; set; }
        public string PostaKodu { get; set; }
        public string Adres { get; set; }
        public AdresTipi AdresTipi { get; set; }
        public decimal Enlem { get; set; }
        public decimal Boylam { get; set; }
        public bool VarsayilanMi { get; set; }
        public bool VarsayilanFaturaMi { get; set; }
        public bool VarsayilanSevkiyatMi { get; set; }
    }
}
