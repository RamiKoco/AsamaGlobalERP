using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class MahalleBll : BaseGenelBll<Mahalle>, IBaseCommonBll
    {
        public MahalleBll() : base(KartTuru.Mahalle) { }
        public MahalleBll(Control ctrl) : base(ctrl, KartTuru.Mahalle) { }
    }
}
