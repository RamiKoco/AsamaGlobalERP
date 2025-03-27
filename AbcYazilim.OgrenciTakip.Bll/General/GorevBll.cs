using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class GorevBll:BaseGenelBll<Gorev>,IBaseGenelBll,IBaseCommonBll
    {
        public GorevBll() : base(KartTuru.Gorev) { }
        public GorevBll(Control ctrl) : base(ctrl, KartTuru.Gorev) { }
    }
}
