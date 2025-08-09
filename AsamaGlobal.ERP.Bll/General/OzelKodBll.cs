using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class OzelKodBll:BaseGenelBll<OzelKod>,IBaseCommonBll
    {
        public OzelKodBll() : base(KartTuru.OzelKod) { }

        public OzelKodBll(Control ctrl) : base(ctrl, KartTuru.OzelKod) { }
    }
}
