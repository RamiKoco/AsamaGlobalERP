using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class IsyeriBll:BaseGenelBll<Isyeri>,IBaseGenelBll,IBaseCommonBll
    {
        public IsyeriBll() : base(KartTuru.Isyeri) { }
        public IsyeriBll(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
    }
}
