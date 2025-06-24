using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class KayitKaynakBll : BaseGenelBll<KayitKaynak>, IBaseGenelBll, IBaseCommonBll
    {
        public KayitKaynakBll() : base(KartTuru.KayitKaynak) { }
        public KayitKaynakBll(Control ctrl) : base(ctrl, KartTuru.KayitKaynak) { }
    }
}
