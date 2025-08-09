using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class KullaniciParametreS : KullaniciParametre
    {
        public string DefaultAvukatHesapAdi { get; set; }
        public string DefaultBankaHesapAdi { get; set; }
        public string DefaultKasaHesapAdi { get; set; }

    }
}
