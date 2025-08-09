using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class YabancıDilBll:BaseGenelBll<YabanciDil>,IBaseGenelBll,IBaseCommonBll
    {
        public YabancıDilBll() : base(KartTuru.YabanciDil) { }

        public YabancıDilBll(Control ctrl) : base(ctrl, KartTuru.YabanciDil) { }
    }
}
