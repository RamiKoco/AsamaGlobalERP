
namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class KisiEtiket
    {
        public long KisiId { get; set; }
        public long EtiketId { get; set; }

        public virtual Kisi Kisi { get; set; }
        public virtual Etiket Etiket { get; set; }
    }
}
