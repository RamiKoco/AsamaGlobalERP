using System.Windows.Forms;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;


namespace AsamaGlobal.ERP.Bll.General
{
    public class IlceBll : BaseGenelBll<Ilce>,IBaseCommonBll
    {
        public IlceBll():base(KartTuru.Ilce) { }

        public IlceBll(Control ctrl) : base(ctrl,KartTuru.Ilce) { }

    
    }
}
