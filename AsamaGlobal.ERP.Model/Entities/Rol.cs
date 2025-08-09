using AsamaGlobal.ERP.Model.Attributes;
using AsamaGlobal.ERP.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AsamaGlobal.ERP.Model.Entities
{
    public class Rol : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Rol Adı", "txtRolAdi")]
        public string RolAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
