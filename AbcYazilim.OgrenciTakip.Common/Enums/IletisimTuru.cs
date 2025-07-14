using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum IletisimTuru : byte
    {
        [Description("Telefon")]
        Telefon = 1,
        [Description("EPosta")]
        EPosta = 2,
        [Description("Web")]
        Web = 3,
        [Description("SosyalMedya")]
        SosyalMedya = 4,
        [Description("Fax")]
        Fax = 5
    }
}
