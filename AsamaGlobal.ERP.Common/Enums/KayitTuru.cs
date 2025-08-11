using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KayitTuru : byte
    {
        [Description("Kişi Kartı")]
        Kisi = 1,
        [Description("Cari Kartı")]
        Cari = 2,
        [Description("Personel Kartı")]
        Personel = 3,
        [Description("Cari Şube Kartı")]
        CariSube = 4,

    }
}
