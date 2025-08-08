using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class KurumTuruS : KurumTuru
    {
    }
    public class KurumTuruL:BaseEntity
    {
        public override string Kod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
    }
}
