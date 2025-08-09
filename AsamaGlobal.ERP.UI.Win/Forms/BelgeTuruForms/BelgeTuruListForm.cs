using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.BelgeTuruForms
{
    public partial class BelgeTuruListForm : BaseListForm
    {
        public BelgeTuruListForm()
        {
            InitializeComponent();
            Bll = new BelgeTuruBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.BelgeTuru;
            FormShow = new ShowEditForms<BelgeTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BelgeTuruBll)Bll).List(FilterFunctions.Filter<BelgeTuru>(AktifKartlariGoster));
        }
    }
}