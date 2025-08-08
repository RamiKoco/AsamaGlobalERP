using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.DepartmanForms
{
    public partial class DepartmanListForm : BaseListForm
    {
        public DepartmanListForm()
        {
            InitializeComponent();
            Bll = new DepartmanBll();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Departman;
            FormShow = new ShowEditForms<DepartmanEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((DepartmanBll)Bll).List(FilterFunctions.Filter<Departman>(AktifKartlariGoster));
        }
    }
}