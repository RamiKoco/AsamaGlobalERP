using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KurumTuruForms
{
    public partial class KurumTuruListForm :BaseListForm
    {
        public KurumTuruListForm()
        {
            InitializeComponent();
            Bll = new KurumTuruBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KurumTuru;
            FormShow = new ShowEditForms<KurumTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KurumTuruBll)Bll).List(FilterFunctions.Filter<KurumTuru>(AktifKartlariGoster));
        }
    }
}