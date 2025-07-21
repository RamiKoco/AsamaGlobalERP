using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class DepartmanBll : BaseGenelBll<Departman>, IBaseGenelBll, IBaseCommonBll
    {
        public DepartmanBll() : base(KartTuru.Departman) { }       
        public DepartmanBll(Control ctrl) : base(ctrl, KartTuru.Departman) { }
    }
}
