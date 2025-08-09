using System.ComponentModel;

namespace AsamaGlobal.ERP.Common.Enums
{
    public enum GruplamaTuru : byte
    {
        [Description("Giriş Tarihine Göre")]
        GirisTarihineGore = 1,

        [Description("Vadeye Göre")]
        VadeyeGore = 2,

        [Description("Hesaba Geciş Tarihine Göre")]
        HesabaGecisTarihineGore = 3

    }
}
