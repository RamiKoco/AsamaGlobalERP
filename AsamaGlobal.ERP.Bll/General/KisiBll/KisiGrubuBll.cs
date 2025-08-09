using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.KisiEntity;
using System.Windows.Forms;

namespace AsamaGlobal.ERP.Bll.General.KisiBll
{
    public class KisiGrubuBll : BaseGenelBll<KisiGrubu>, IBaseGenelBll, IBaseCommonBll
    {
        public KisiGrubuBll() : base(KartTuru.KisiGrubu) { }
        public KisiGrubuBll(Control ctrl) : base(ctrl, KartTuru.KisiGrubu) { }
    }
}
