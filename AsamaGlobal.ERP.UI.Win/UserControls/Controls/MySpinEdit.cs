﻿using System.ComponentModel;
using System.Drawing;
using AsamaGlobal.ERP.UI.Win.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace AsamaGlobal.ERP.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
   public class MySpinEdit:SpinEdit,IStatusBarAciklama
    {

        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";

        }


        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
