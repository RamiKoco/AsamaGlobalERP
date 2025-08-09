using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class KurguBll : BaseGenelBll<Kurgu>, IBaseGenelBll, IBaseCommonBll
    {
        public KurguBll() : base(KartTuru.Kurgu) { }
        public KurguBll(Control ctrl) : base(ctrl, KartTuru.Kurgu) { }
    }
}
