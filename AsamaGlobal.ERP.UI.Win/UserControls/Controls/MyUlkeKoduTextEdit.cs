using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;

namespace AsamaGlobal.ERP.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyUlkeKoduTextEdit : MyTextEdit
    {
        public MyUlkeKoduTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;   
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask = @"\+[1-9]\d{1,2}";
            Properties.Mask.PlaceHolder = ' ';
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            StatusBarAciklama = "Ülke Kodu Giriniz. Örn: +90";
            this.Enter += (s, e) =>
            {
                BeginInvoke(new Action(() => this.Select(1, 0)));
            };
        }
    }
}
