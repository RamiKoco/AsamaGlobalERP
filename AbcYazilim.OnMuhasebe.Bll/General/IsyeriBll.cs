using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IsyeriBll:BaseGenelBll<Isyeri>,IBaseGenelBll,IBaseCommonBll
    {
        public IsyeriBll() : base(KartTuru.Isyeri) { }
        public IsyeriBll(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
    }
}
