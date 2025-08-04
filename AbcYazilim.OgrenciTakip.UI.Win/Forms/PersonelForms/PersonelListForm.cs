using AbcYazilim.OgrenciTakip.Bll.General.PersonelBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto.PersonelDto;
using AbcYazilim.OgrenciTakip.Model.Entities.PersonelEntity;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.PersonelForms
{
    public partial class PersonelListForm : BaseListForm
    {
        public PersonelListForm()
        {
            InitializeComponent();
            Bll = new PersonelBll();

            btnIletisimKartlari.Caption = "İletişim Kartları";
            btnAdresKartlari.Caption = "Adres Kartları";

            btnIletisimKartlari.ItemClick += BarItem_ItemClick;
            btnAdresKartlari.ItemClick += BarItem_ItemClick;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Personel;
            FormShow = new ShowEditForms<PersonelEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnIletisimKartlari, btnAdresKartlari };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PersonelBll)Bll).List(FilterFunctions.Filter<Personel>(AktifKartlariGoster));
        }
        private void BarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BagliKartAc(e.Item);
        }

        protected override void BagliKartAc(BarItem barItem)
        {
            var entity = Tablo.GetRow<PersonelL>();
            if (entity == null) return;

            else if (barItem == btnIletisimKartlari)
            {
                ShowListForms<PersonelIletisimListForm>.ShowListForm(KartTuru.PersonelIletisim, entity.Id, entity.Ad);
            }
            else if (barItem == btnAdresKartlari)
            {
                ShowListForms<PersonelAdresListForm>.ShowListForm(KartTuru.PersonelAdres, entity.Id, entity.Ad);
            }
        }
    }
}