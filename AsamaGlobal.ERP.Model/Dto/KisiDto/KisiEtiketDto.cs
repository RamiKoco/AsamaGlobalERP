using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities.Kisi;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto.KisiDto
{
    [NotMapped]
    public class KisiEtiketL : KisiEtiket, IBaseHareketEntity
    {
        public string EtiketAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
