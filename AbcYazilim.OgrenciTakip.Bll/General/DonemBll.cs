using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class DonemBll : BaseGenelBll<Donem>, IBaseGenelBll, IBaseCommonBll
    {
        public DonemBll() : base(KartTuru.Donem) { }
        public DonemBll(Control ctrl) : base(ctrl, KartTuru.Donem) { }
    }
}