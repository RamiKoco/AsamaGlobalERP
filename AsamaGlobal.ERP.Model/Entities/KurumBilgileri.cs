using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AsamaGlobal.ERP.Model.Entities
{
    public class KurumBilgileri : BaseEntity
    {

        [Required, StringLength(50), ZorunluAlan("Kurum Adı", "txtKurumAdi")]
        public string KurumAdi { get; set; }

        [StringLength(20)]
        public string VergiNo { get; set; }
      
        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [ZorunluAlan("İl Adı", "txtIl")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe Adı", "txtIlce")]
        public long IlceId { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
    }
}
