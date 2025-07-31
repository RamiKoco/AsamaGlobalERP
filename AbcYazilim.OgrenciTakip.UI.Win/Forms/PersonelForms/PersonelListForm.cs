using AbcYazilim.OgrenciTakip.Bll.General.PersonelBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Personel;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.PersonelForms
{
    public partial class PersonelListForm : BaseListForm
    {
        public PersonelListForm()
        {
            InitializeComponent();
            Bll = new PersonelBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Personel;
            FormShow = new ShowEditForms<PersonelEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PersonelBll)Bll).List(FilterFunctions.Filter<Personel>(AktifKartlariGoster));
        }
    }
}