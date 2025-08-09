using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class HizmetTuruBll:BaseGenelBll<HizmetTuru>,IBaseGenelBll,IBaseCommonBll
    {
        public HizmetTuruBll() : base(KartTuru.HizmetTuru) { }
        public HizmetTuruBll(Control ctrl) : base(ctrl, KartTuru.HizmetTuru) { }
    }
}
