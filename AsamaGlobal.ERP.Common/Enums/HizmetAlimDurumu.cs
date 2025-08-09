using System.ComponentModel;

namespace AsamaGlobal.ERP.Common.Enums
{
    public enum HizmetAlimDurumu : byte
    {
        [Description("Hizmeti Alanlar")]
        HizmetiAlanlar = 1,

        [Description("Hizmeti Almayanlar")]
        HizmetiAlmayanlar = 2,
    }
}
