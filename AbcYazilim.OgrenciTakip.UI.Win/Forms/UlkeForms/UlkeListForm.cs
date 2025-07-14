using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.UlkeForms
{
    public partial class UlkeListForm : BaseListForm
    {
        public UlkeListForm()
        {
            InitializeComponent();
            Bll = new UlkeBll();
            //btnBagliKartlar.Caption = "İl Kartları";
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ulke;
            FormShow = new ShowEditForms<UlkeEditForm>();
            Navigator = longNavigator.Navigator;

            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKartlar };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UlkeBll)Bll).List(FilterFunctions.Filter<Ulke>(AktifKartlariGoster));

        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Ulke>();
            //if (entity == null) return;
            //ShowListForms<IlListForm>.ShowListForm(KartTuru.Il, entity.Id, entity.UlkeAdi);
        }
    }
}