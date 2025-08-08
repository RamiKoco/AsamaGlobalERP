using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.SosyalMedyaForms
{
    public partial class SosyalMedyaPlatformuListForm : BaseListForm
    {
        public SosyalMedyaPlatformuListForm()
        {
            InitializeComponent();
            Bll = new SosyalMedyaPlatformuBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SosyalMedyaPlatformu;
            FormShow = new ShowEditForms<SosyalMedyaPlatformuEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SosyalMedyaPlatformuBll)Bll).List(FilterFunctions.Filter<SosyalMedyaPlatformu>(AktifKartlariGoster));
        }
    }
}