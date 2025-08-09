using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class IndirimTuruBll : BaseGenelBll<IndirimTuru>,IBaseGenelBll,IBaseCommonBll
    {
        public IndirimTuruBll() : base(KartTuru.IndirimTuru) { }
        public IndirimTuruBll(Control ctrl) : base(ctrl, KartTuru.IndirimTuru) { }
    }
}
