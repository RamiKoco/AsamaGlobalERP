﻿using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class TesvikBll:BaseGenelBll<Tesvik>,IBaseGenelBll,IBaseCommonBll
    {
        public TesvikBll() : base(KartTuru.Tesvik) { }
        public TesvikBll(Control ctrl) : base(ctrl, KartTuru.Tesvik) { }


    }
}
