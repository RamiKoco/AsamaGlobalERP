using System.ComponentModel.DataAnnotations;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Model.Entities
{
    public class AileBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long AileBilgiId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public AileBilgi AileBilgi { get; set; }
    }
}
