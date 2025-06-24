using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiListForm : BaseListForm
    {
        public KisiListForm()
        {
            InitializeComponent();
            Bll = new KisiBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kisi;
            FormShow = new ShowEditForms<KisiEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiBll)Bll).List(FilterFunctions.Filter<Kisi>(AktifKartlariGoster));
        }

    }
}