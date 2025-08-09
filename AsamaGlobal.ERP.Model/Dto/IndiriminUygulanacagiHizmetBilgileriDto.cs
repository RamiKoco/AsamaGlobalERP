using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base.Interfaces;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class IndiriminUygulanacagiHizmetBilgileriL:IndiriminUygulanacagiHizmetBilgileri,IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
