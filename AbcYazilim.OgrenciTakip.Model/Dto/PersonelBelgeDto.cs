using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class PersonelBelgeL: PersonelBelge, IBaseHareketEntity
    {       
        public string KurumAdi { get; set; }
        public string BelgeAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class PersonelBelgeR
    {
        public DateTime Tarih { get; set; }      
        public string KurumAdi { get; set; }
        public string BelgeAdi { get; set; }
        public string Aciklama { get; set; }

    }
}
