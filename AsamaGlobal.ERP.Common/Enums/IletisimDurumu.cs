using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum IletisimDurumu : byte
    {
        [Description("Belirtilmedi")]
        Belirtilmedi = 1,
        [Description("Verildi")]
        Verildi = 2,
        [Description("Rededildi")]
        Rededildi = 3
    }
}
