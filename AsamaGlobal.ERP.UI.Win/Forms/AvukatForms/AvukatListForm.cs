using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.AvukatForms
{
    public partial class AvukatListForm : BaseListForm
    {
        public AvukatListForm()
        {
            InitializeComponent();
            Bll = new AvukatBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Avukat;
            FormShow = new ShowEditForms<AvukatEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AvukatBll)Bll).List(FilterFunctions.Filter<Avukat>(AktifKartlariGoster));
        }
    }
}