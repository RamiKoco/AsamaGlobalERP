using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.UyrukForms
{
    public partial class UyrukListForm : BaseListForm
    {
        public UyrukListForm()
        {
            InitializeComponent();
            Bll = new UyrukBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Uyruk;
            FormShow = new ShowEditForms<UyrukEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UyrukBll)Bll).List(FilterFunctions.Filter<Uyruk>(AktifKartlariGoster));
        }
    }
}