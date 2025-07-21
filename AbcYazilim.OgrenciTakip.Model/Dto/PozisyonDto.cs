using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class PozisyonS : Pozisyon
    {
        public string RenkAdi { get; set; }
        public string DepartmanAdi { get; set; }

    }

    public class PozisyonL : BaseEntity
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string RenkAdi { get; set; }
        public string DepartmanAdi { get; set; }
       
    }
}
