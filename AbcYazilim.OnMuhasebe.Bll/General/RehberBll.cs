﻿using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class RehberBll:BaseGenelBll<Rehber>,IBaseGenelBll,IBaseCommonBll
    {
        public RehberBll() : base(KartTuru.Rehber) { }
        public RehberBll(Control ctrl) : base(ctrl, KartTuru.Rehber) { }
    }
}
