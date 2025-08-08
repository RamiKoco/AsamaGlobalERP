using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.Scheduler
{
    [ToolboxItem(true)]
    public class MyScheduler:SchedulerControl
    {
        public MyScheduler()
        {
            ActiveViewType = SchedulerViewType.WorkWeek;         
            
        }
    }
}
