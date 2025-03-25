using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Drawing;
using AbcYazilim.OgrenciTakip.UI.Win.Interfaces;


namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit : TextEdit, IStatusBarAciklama
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
