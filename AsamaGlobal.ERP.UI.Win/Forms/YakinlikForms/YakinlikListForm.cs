using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.YakinlikForms
{
    public partial class YakinlikListForm : BaseListForm
    {
        public YakinlikListForm()
        {
            InitializeComponent();
            Bll = new YakinlikBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Yakinlik;
            FormShow = new ShowEditForms<YakinlikEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((YakinlikBll)Bll).List(FilterFunctions.Filter<Yakinlik>(AktifKartlariGoster));

        }

    }
}