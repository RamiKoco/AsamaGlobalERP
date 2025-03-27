using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class RolListForm : BaseListForm
    {
        public RolListForm()
        {
            InitializeComponent();
            Bll = new RolBll();

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Rol;
            FormShow = new ShowEditForms<RolEditForm>();
            Navigator = longNavigator.Navigator;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RolBll)Bll).List(FilterFunctions.Filter<Rol>(AktifKartlariGoster));
        }

    }
}