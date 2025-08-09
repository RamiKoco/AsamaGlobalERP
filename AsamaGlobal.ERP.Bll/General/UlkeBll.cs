﻿using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Bll.Base;
using AsamaGlobal.ERP.Bll.Interfaces;
using AsamaGlobal.ERP.Common.Enums;
using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim;
using AbcYazilim.OgrenciTakip;
using AbcYazilim.OgrenciTakip.Bll;

namespace AsamaGlobal.ERP.Bll.General
{
    public class UlkeBll : BaseGenelBll<Ulke>, IBaseGenelBll, IBaseCommonBll
    {
        public UlkeBll() : base(KartTuru.Ulke) { }
        public UlkeBll(Control ctrl) : base(ctrl, KartTuru.Ulke) { }
    }
}
