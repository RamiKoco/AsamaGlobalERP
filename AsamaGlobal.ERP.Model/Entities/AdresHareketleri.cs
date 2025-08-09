using AsamaGlobal.ERP.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class AdresHareketleri : BaseHareketEntity
    {
        public long? KisiId { get; set; }
        public long? PersonelId { get; set; }
        public long AdresBilgileriId { get; set; }

        public AdresBilgileri AdresBilgileri { get; set; }
    }
}
