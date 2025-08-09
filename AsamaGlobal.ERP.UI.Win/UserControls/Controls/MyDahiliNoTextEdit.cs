using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
<<<<<<< HEAD
using System;
using System.ComponentModel;

namespace AsamaGlobal.ERP.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDahiliNoTextEdit : MyTextEdit
    {
        public MyDahiliNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;    
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"[1-9]\d{0,5}";
            Properties.Mask.PlaceHolder = ' ';
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            StatusBarAciklama = "Dahili No Giriniz.";
            Enter += (s, e) =>
            {
                BeginInvoke(new Action(() => Select(1, 0)));
            };
=======
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDahiliNoTextEdit:MyTextEdit
    {
        public MyDahiliNoTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.PlaceHolder = ' ';
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Dahili No Giriniz.";
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        }
    }
}
