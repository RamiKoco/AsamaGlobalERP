using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class MeslekBll:BaseGenelBll<Meslek>,IBaseGenelBll,IBaseCommonBll
    {
        public MeslekBll() : base(KartTuru.Meslek) { }
        public MeslekBll(Control ctrl) : base(ctrl, KartTuru.Meslek) { }
    }
}
