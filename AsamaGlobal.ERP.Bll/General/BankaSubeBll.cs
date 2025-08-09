using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
    public class BankaSubeBll:BaseGenelBll<BankaSube>,IBaseCommonBll
    {
        public BankaSubeBll() : base(KartTuru.BankaSube) { }
        public BankaSubeBll(Control ctrl) : base(ctrl, KartTuru.BankaSube) { }
    }
}
