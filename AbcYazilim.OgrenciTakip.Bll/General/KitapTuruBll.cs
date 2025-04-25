using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.KitapTuru;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class KitapTuruBll : BaseGenelBll<KitapTuru>, IBaseCommonBll
    {
        public KitapTuruBll() : base(KartTuru.KitapTuru) { }
        public KitapTuruBll(Control ctrl) : base(ctrl, KartTuru.KitapTuru) { }
    }
}
