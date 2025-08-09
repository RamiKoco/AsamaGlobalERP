using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class OdemeTuruBll:BaseGenelBll<OdemeTuru>,IBaseGenelBll,IBaseCommonBll
    {
        public OdemeTuruBll() : base(KartTuru.OdemeTuru) { }

        public OdemeTuruBll(Control ctrl) : base(ctrl, KartTuru.OdemeTuru) { }
    }
}
