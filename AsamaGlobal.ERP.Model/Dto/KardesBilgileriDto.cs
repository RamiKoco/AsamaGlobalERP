using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base.Interfaces;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class KardesBilgileriL:KardesBilgileri,IBaseHareketEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SinifAdi { get; set; }
        public KayitSekli KayitSekli { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
        public IptalDurumu IptalDurumu { get; set; }
        public long SubeId { get; set; }
        public string SubeAdi { get; set; }
        public long DonemId { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
