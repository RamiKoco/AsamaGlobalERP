using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KayitKaynakForms
{
    public partial class KayitKaynakListForm : BaseListForm
    {
        public KayitKaynakListForm()
        {
            InitializeComponent();
            Bll = new KayitKaynakBll();
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
            Tablo.GridControl.DataSource = ((KayitKaynakBll)Bll).List(FilterFunctions.Filter<KayitKaynak>(AktifKartlariGoster));

        }
    }
}