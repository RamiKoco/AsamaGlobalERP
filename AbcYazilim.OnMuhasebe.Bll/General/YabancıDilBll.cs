using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class YabancıDilBll:BaseGenelBll<YabanciDil>,IBaseGenelBll,IBaseCommonBll
    {
        public YabancıDilBll() : base(KartTuru.YabanciDil) { }

        public YabancıDilBll(Control ctrl) : base(ctrl, KartTuru.YabanciDil) { }
    }
}
