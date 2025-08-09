using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
{
  public class IlBll : BaseGenelBll<Il>, IBaseGenelBll,IBaseCommonBll
    {
        public IlBll():base(KartTuru.Il) { }
        public IlBll(Control ctrl):base(ctrl,KartTuru.Il) { }

       

    }
}
