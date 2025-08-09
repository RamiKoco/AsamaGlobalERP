using System.Windows.Forms;
<<<<<<< HEAD
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;

namespace AsamaGlobal.ERP.Bll.General
=======
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
{
  public class IlBll : BaseGenelBll<Il>, IBaseGenelBll,IBaseCommonBll
    {
        public IlBll():base(KartTuru.Il) { }
<<<<<<< HEAD
        public IlBll(Control ctrl):base(ctrl,KartTuru.Il) { }

       
=======
        public IlBll(Control ctrl):base(ctrl,KartTuru.Il) { }       
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec

    }
}
