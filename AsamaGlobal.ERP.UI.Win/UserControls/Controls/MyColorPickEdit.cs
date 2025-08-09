﻿using System.ComponentModel;
using System.Drawing;
using AsamaGlobal.ERP.UI.Win.Interfaces;
using DevExpress.XtraEditors;

namespace AsamaGlobal.ERP.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyColorPickEdit : ColorPickEdit, IStatusBarKisaYol
    {
        public MyColorPickEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; }
        public string StatusBarKisaYolAciklama { get; set; }
    }
}
