using System.ComponentModel;

namespace AsamaGlobal.ERP.Common.Enums
{
    public enum KdvSekli : byte
    {
        [Description("Dahil")]
        Dahil = 1,
        
        [Description("Hariç")]
        Haric = 2,
    }
}
