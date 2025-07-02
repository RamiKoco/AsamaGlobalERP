
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class KisiEtiket : BaseHareketEntity
    {
        public long KisiId { get; set; }
        public long EtiketId { get; set; }

        [ForeignKey("KisiId")]
        public virtual Kisi Kisi { get; set; }
        public virtual Etiket Etiket { get; set; }
   


    }
}
