using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class IletisimBilgileri : BaseHareketEntity
    {
      
        public long? KisiId { get; set; }
        public long? PersonelId { get; set; }
        public long IletisimId { get; set; }
        public bool Veli { get; set; }
        public IletisimTuru? IletisimTuru { get; set; }
        public Iletisim Iletisim { get; set; }
    }
}
