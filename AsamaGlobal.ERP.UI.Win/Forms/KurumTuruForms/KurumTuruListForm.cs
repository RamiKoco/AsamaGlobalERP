using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.KurumTuruForms
{
    public partial class KurumTuruListForm : BaseListForm
    {
        public KurumTuruListForm()
        {
            InitializeComponent();
            Bll = new KurumTuruBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KurumTuru;
            FormShow = new ShowEditForms<KurumTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KurumTuruBll)Bll).List(FilterFunctions.Filter<KurumTuru>(AktifKartlariGoster));
        }
    }
}