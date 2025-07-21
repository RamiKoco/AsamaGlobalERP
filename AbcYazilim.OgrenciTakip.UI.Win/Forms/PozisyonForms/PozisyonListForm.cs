using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.PozisyonForms
{
    public partial class PozisyonListForm : BaseListForm
    {
        public PozisyonListForm()
        {
            InitializeComponent();
            Bll = new PozisyonBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Pozisyon;
            FormShow = new ShowEditForms<PozisyonEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PozisyonBll)Bll).List(FilterFunctions.Filter<Pozisyon>(AktifKartlariGoster));
        }
    }
}