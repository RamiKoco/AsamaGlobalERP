using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KurumForms
{
    public partial class KurumlarListForm : BaseListForm
    {
        public KurumlarListForm()
        {
            InitializeComponent();
            Bll = new KurumlarBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kurumlar;
            FormShow = new ShowEditForms<KurumlarEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KurumlarBll)Bll).List(FilterFunctions.Filter<Kurumlar>(AktifKartlariGoster));
        }
    }
}