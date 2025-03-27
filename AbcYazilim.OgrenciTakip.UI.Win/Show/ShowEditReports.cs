using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Reports.FormReports.Base;
using System.Windows.Forms;
using System;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Show
{
    public class ShowEditReports <TForm>  where TForm : BaseRapor
    {
        public static void ShowEditReport(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }

    }
}
