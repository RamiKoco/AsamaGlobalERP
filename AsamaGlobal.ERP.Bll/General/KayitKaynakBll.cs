using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim;
using AbcYazilim.OgrenciTakip;
using AbcYazilim.OgrenciTakip.Bll;

namespace AsamaGlobal.ERP.Bll.General
{
    public class KayitKaynakBll : BaseGenelBll<KayitKaynak>, IBaseGenelBll, IBaseCommonBll
    {
        public KayitKaynakBll() : base(KartTuru.KayitKaynak) { }
        public KayitKaynakBll(Control ctrl) : base(ctrl, KartTuru.KayitKaynak) { }
    }
}
