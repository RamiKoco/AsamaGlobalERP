using System.ComponentModel;

namespace AsamaGlobal.ERP.Common.Enums
{
    public enum SonrakiDonemKayitDurumu : byte
    {
        [Description("Kayıt Yenilenecek")]
        KayitYenileyecek = 1,
        [Description("Şartlı Kayıt Yenilenecek")]
        SartliKayitYenileyecek = 2,
        [Description("Kayıt Yenilemeyecek")]
        KayitYenilemeyecek = 3,
        [Description("Kurum Tarafından Kaydı Yenilenmeyecek")]
        KurumTarafindanKaydiYenilenmeyecek = 4

    }
}
