using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Common.Enums;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class RolBll : BaseGenelBll<Rol>, IBaseGenelBll, IBaseCommonBll
    {
        public RolBll() : base(KartTuru.Rol) { }
        public RolBll(Control ctrl) : base(ctrl,KartTuru.Rol) { }
    }
}
