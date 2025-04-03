using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class RamiDenemeBll : BaseGenelBll<RamiDeneme>, IBaseGenelBll, IBaseCommonBll
    {
        public RamiDenemeBll() : base(KartTuru.Rami) { }
        public RamiDenemeBll(Control ctrl) : base(ctrl, KartTuru.Rami) { }
    }
}
