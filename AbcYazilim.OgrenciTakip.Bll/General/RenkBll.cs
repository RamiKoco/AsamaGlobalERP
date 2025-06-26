using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class RenkBll : BaseGenelBll<Renk>, IBaseGenelBll, IBaseCommonBll
    {
        public RenkBll() : base(KartTuru.Renk) { }
        public RenkBll(Control ctrl) : base(ctrl, KartTuru.Renk) { }
    }
}
