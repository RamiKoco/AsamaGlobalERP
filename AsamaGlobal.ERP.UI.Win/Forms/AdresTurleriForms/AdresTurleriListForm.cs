using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AdresTurleriForms
{
    public partial class AdresTurleriListForm : BaseListForm
    {
        public AdresTurleriListForm()
        {
            InitializeComponent();
            Bll = new AdresTurleriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AdresTurleri;
            FormShow = new ShowEditForms<AdresTurleriEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AdresTurleriBll)Bll).List(FilterFunctions.Filter<AdresTurleri>(AktifKartlariGoster));
        }
    }
}