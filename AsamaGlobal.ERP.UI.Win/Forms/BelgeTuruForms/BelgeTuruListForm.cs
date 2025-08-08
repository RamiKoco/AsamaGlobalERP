using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.BelgeTuruForms
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