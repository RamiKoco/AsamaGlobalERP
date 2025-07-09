using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.AdresBilgiForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AdresBilgileriForms
{
    public partial class AdresBilgileriListForm : BaseListForm
    {
        public AdresBilgileriListForm()
        {
            InitializeComponent();
            Bll = new AdresBilgileriBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AdresBilgileri;
            FormShow = new ShowEditForms<AdresBilgileriEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AdresBilgileriBll)Bll).List(FilterFunctions.Filter<AdresBilgileri>(AktifKartlariGoster));
        }
    }
}