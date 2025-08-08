
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum MedeniDurum:byte
    {
        [Description("Bekar")]
        Bekar = 1,
        [Description("Evli")]
        Evli = 2,
        [Description("Boşanmış")]
        Bosanmis = 3,
        [Description("Nışanlı")]
        Nisanli = 4,
        [Description("Dul")]
        Dul = 5
    }
}
