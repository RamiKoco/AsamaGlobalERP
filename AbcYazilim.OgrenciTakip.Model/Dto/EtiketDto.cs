using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;


namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class EtiketS : Etiket
    {     
        public string RenkAdi { get; set; }     
    }
    public class EtiketL : BaseEntity
    {
        public string Ad { get; set; }    
        public KayitTuru KayitTuru { get; set; }   
        public string RenkAdi { get; set; }
    }
}
