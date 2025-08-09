using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.KayitKaynakForms
{
    public partial class KayitKaynakListForm : BaseListForm
    {
        public KayitKaynakListForm()
        {
            InitializeComponent();
            Bll = new Bll.General.KayitKaynakBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KayitKaynak;
            FormShow = new ShowEditForms<KayitKaynakEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((Bll.General.KayitKaynakBll)Bll).List(FilterFunctions.Filter<KayitKaynak>(AktifKartlariGoster));

        }
    }
}