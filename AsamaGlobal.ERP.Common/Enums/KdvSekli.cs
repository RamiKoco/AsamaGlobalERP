using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KdvSekli : byte
    {
        [Description("Dahil")]
        Dahil = 1,
        
        [Description("Hariç")]
        Haric = 2,
    }
}
