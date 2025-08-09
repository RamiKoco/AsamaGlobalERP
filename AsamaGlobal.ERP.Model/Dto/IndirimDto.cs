using System;
using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class IndirimS:Indirim
    {
        public string IndirimTuruAdi { get; set; }

    }
    public class IndirimL : BaseEntity
    {
        public string IndirimAdi { get; set; }
        public long IndirimTuruId { get; set; }
        public string IndirimTuruAdi { get; set; }
        public string Aciklama { get; set; }
    }

}
