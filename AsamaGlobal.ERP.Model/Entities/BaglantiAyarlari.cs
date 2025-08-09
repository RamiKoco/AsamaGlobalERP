using System.Security;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Model.Entities
{
    public class BaglantiAyarlari : BaseEntity
    {
        public string Server { get; set; }
        public YetkilendirmeTuru YetkilendirmeTuru { get; set; }
        public SecureString KullaniciAdi { get; set; }
        public SecureString Sifre { get; set; }

    }
}
