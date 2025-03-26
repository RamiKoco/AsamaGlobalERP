using System.Collections.Generic;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    
   public class Il:BaseEntityDurum
    {
        public override string Kod { get; set; }
        public string IlAdi { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Ilce> Ilce { get; set; }
        
    }
}
