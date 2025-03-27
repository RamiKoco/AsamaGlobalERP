using AbcYazilim.OgrenciTakip.Model.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class MailParametre : BaseEntity
    {

        [Required, StringLength(50), ZorunluAlan("Email", "txtEmail")]
        public string Email { get; set; }

        [Required, StringLength(50), ZorunluAlan("Email Şifre", "txtSifre")]
        public string Sifre { get; set; }

        [ZorunluAlan("Port No", "txtPortNo")]
        public int PortNo { get; set; }

        [Required, StringLength(50), ZorunluAlan("Host", "txtHost")]
        public string Host { get; set; }

        public EvetHayir SslKullan { get; set; } = EvetHayir.Evet;
    }
}
