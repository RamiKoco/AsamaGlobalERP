using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class KontenjanBll:BaseGenelBll<Kontenjan>,IBaseGenelBll,IBaseCommonBll
    {
        public KontenjanBll() : base(KartTuru.Kontenjan) { }

        public KontenjanBll(Control ctrl) : base(ctrl, KartTuru.Kontenjan) { }
    }
}
