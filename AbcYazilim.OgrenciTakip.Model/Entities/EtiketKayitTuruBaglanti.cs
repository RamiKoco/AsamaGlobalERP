
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class EtiketKayitTuruBaglanti : BaseHareketEntity
    {
        public long EtiketId { get; set; }
        public KayitTuru KayitTuru { get; set; }

        public virtual Etiket Etiket { get; set; }
    }
}
