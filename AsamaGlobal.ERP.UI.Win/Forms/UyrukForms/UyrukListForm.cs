using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.UyrukForms
{
    public partial class UyrukListForm : BaseListForm
    {
        public UyrukListForm()
        {
            InitializeComponent();
            Bll = new Bll.General.UyrukBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Uyruk;
            FormShow = new ShowEditForms<UyrukEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((Bll.General.UyrukBll)Bll).List(FilterFunctions.Filter<Uyruk>(AktifKartlariGoster));
        }
    }
}