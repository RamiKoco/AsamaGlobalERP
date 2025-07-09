using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KayitTuru : byte
    {
        [Description("Kişi Kartı")]
        Kisi = 1,
        [Description("Meslek Kartı")]
        Meslek = 2,
        [Description("Adres Kartı")]
        Adres = 3,
        [Description("Test Kartı")]
        Test = 4,      
        
    }
}
