using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class UyrukS : Uyruk
    {
        public string UlkeAdi { get; set; }

    }
    public class UyrukL : BaseEntity
    {
        public string Ad { get; set; }
        public string UlkeAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
