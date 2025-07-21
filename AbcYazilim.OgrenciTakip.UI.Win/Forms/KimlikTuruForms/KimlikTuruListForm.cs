using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KimlikTuruForms
{
    public partial class KimlikTuruListForm : BaseListForm
    {
        public KimlikTuruListForm()
        {
            InitializeComponent();
            Bll = new KimlikTuruBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KimlikTuru;
            FormShow = new ShowEditForms<KimlikTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KimlikTuruBll)Bll).List(FilterFunctions.Filter<KimlikTuru>(AktifKartlariGoster));
        }
    }
}