using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;
using AsamaGlobal.ERP.UI.Win.Interfaces;

namespace AsamaGlobal.ERP.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyHyperlinkLabelControl : HyperlinkLabelControl , IStatusBarAciklama
    {
        public MyHyperlinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;
        }
        public string StatusBarAciklama { get; set; }

    }
}
