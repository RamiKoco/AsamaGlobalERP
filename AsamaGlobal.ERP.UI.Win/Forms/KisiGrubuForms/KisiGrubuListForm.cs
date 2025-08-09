using AsamaGlobal.ERP.Bll.General.KisiBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.KisiEntity;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.KisiGrubuForms
{
    public partial class KisiGrubuListForm : BaseListForm
    {
        public KisiGrubuListForm()
        {
            InitializeComponent();
            Bll = new KisiGrubuBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KisiGrubu;
            FormShow = new ShowEditForms<KisiGrubuEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiGrubuBll)Bll).List(FilterFunctions.Filter<KisiGrubu>(AktifKartlariGoster));
        }
    }
}