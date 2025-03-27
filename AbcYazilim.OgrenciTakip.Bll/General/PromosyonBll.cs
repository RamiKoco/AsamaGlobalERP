using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class PromosyonBll:BaseGenelBll<Promosyon>,IBaseCommonBll
    {
        public PromosyonBll() : base(KartTuru.Promosyon) { }
        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon) { }
    }
}
