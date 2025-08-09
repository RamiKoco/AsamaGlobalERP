using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class KurumBilgileriS : KurumBilgileri
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }

    }
}
