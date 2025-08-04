using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
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
        }
    }
}
