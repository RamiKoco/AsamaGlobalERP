using AbcYazilim.OgrenciTakip.Model.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class Kurum : BaseEntity
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Kurum Adı", "txtKurumAdi")]
        public string KurumAdi { get; set; }

        [Required, StringLength(100), ZorunluAlan("Server", "txtServer")]
        public string Server { get; set; }

        public YetkilendirmeTuru YetkilendirmeTuru { get; set; } = YetkilendirmeTuru.SqlServer;

        [Required, StringLength(50), ZorunluAlan("Kullanıcı Adı", "txtKullaniciAdi")]
        public string KullaniciAdi { get; set; }

        [Required, StringLength(50), ZorunluAlan("Sifre", "txtSifre")]
        public string Sifre { get; set; }


    }
}
