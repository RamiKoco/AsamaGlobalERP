
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;

namespace AbcYazilim.OgrenciTakip.Model.Entities.Base
{
   public class BaseEntity:IBaseEntity
    {
        public long Id { get; set; }
        public virtual string Kod { get; set; }

    }
}
