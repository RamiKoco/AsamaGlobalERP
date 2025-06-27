using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiGrubuForms
{
    public partial class KisiGrubuListForm : BaseListForm
    {
        public KisiGrubuListForm()
        {
            InitializeComponent();
            Bll = new KisiGrubuBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KisiGrubu;
            FormShow = new ShowEditForms<KisiGrubuEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiGrubuBll)Bll).List(FilterFunctions.Filter<KisiGrubu>(AktifKartlariGoster));
        }
    }
}