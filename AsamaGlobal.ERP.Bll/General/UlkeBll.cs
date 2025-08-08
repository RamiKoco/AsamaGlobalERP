using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class UlkeBll : BaseGenelBll<Ulke>, IBaseGenelBll, IBaseCommonBll
    {
        public UlkeBll() : base(KartTuru.Ulke) { }
        public UlkeBll(Control ctrl) : base(ctrl, KartTuru.Ulke) { }
    }
}
