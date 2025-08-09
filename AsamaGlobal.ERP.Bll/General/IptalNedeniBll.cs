using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class IptalNedeniBll:BaseGenelBll<IptalNedeni>,IBaseGenelBll,IBaseCommonBll
    {
        public IptalNedeniBll() : base(KartTuru.IptalNedeni) { }
        public IptalNedeniBll(Control ctrl) : base(ctrl, KartTuru.IptalNedeni) { }
    }
}
