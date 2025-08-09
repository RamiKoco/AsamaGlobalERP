using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Model.Entities;
using System.Windows.Forms;
using AsamaGlobal.ERP.Common.Enums;

namespace AsamaGlobal.ERP.Bll.General
{
    public class RolBll : BaseGenelBll<Rol>, IBaseGenelBll, IBaseCommonBll
    {
        public RolBll() : base(KartTuru.Rol) { }
        public RolBll(Control ctrl) : base(ctrl,KartTuru.Rol) { }
    }
}
