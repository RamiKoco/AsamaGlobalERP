using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Reports.FormReports.Base;
using System.Windows.Forms;
using System;
using AsamaGlobal.ERP.UI.Win.Functions;

namespace AsamaGlobal.ERP.UI.Win.Show
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
