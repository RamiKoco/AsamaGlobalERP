using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class PromosyonBll:BaseGenelBll<Promosyon>,IBaseCommonBll
    {
        public PromosyonBll() : base(KartTuru.Promosyon) { }
        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon) { }
    }
}
