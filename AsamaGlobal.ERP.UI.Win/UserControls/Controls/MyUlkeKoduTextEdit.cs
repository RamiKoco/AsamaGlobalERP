using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
<<<<<<< HEAD
using System;
using System.ComponentModel;

namespace AsamaGlobal.ERP.UI.Win.UserControls.Controls
=======
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
{
    [ToolboxItem(true)]
    public class MyUlkeKoduTextEdit : MyTextEdit
    {
        public MyUlkeKoduTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
<<<<<<< HEAD
            //Properties.Mask.MaskType = MaskType.Regular;            
            //Properties.Mask.EditMask = @"\+\d?\d?\d?";
            //Properties.Mask.AutoComplete = AutoCompleteType.None;         

            //Properties.Mask.MaskType = MaskType.Simple;
            //Properties.Mask.EditMask = "+000";
            //Properties.Mask.AutoComplete = AutoCompleteType.Strong;
            //Properties.Mask.PlaceHolder = ' ';
            //StatusBarAciklama = "Ülke Kodu Giriniz.";

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
=======
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.PlaceHolder = ' ';
            Properties.Mask.EditMask = @"\+\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "Ülke Kodu Giriniz.";
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        }
    }
}
