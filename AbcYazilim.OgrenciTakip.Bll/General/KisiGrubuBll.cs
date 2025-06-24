using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class KisiGrubuBll : BaseGenelBll<KisiGrubu>, IBaseGenelBll, IBaseCommonBll
    {
        public KisiGrubuBll() : base(KartTuru.KisiGrubu) { }
        public KisiGrubuBll(Control ctrl) : base(ctrl, KartTuru.KisiGrubu) { }
    }
}
