using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.GenelForms;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.IndirimForms
{
    public partial class IndirimListForm : BaseListForm
    {
        public IndirimListForm()
        {
            InitializeComponent();
            Bll = new IndirimBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Indirim;
            FormShow = new ShowEditForms<IndirimEditForm>();
            Navigator = longNavigator.Navigator;
            
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IndirimBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

      

    }
}