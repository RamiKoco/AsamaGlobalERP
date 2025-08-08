﻿using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;


namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class IlceBll : BaseGenelBll<Ilce>,IBaseCommonBll
    {
        public IlceBll():base(KartTuru.Ilce) { }

        public IlceBll(Control ctrl) : base(ctrl,KartTuru.Ilce) { }
    
    }
}
