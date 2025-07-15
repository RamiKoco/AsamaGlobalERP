using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum IletisimKanalTipi : byte
    {
        [Description("Arama")]
        Arama = 1,
        [Description("SMS")]
        SMS = 2,
        [Description("E-Posta")]
        EPosta = 3,
        [Description("Whatsapp")]
        Whatsapp = 4
    }
}
