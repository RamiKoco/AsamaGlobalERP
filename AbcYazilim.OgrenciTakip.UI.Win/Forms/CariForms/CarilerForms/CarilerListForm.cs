using AbcYazilim.OgrenciTakip.Bll.General.CarilerBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto.CariDto;
using AbcYazilim.OgrenciTakip.Model.Entities.CariEntity;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms.CarilerForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.CariSubelerForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;
namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.CarilerForms
{
    public partial class CarilerListForm : BaseListForm
    {
        public CarilerListForm()
        {
            InitializeComponent();
            Bll = new CarilerBll();

            btnBagliKartlar.Caption = "Cari Şube Kartı";
            btnIletisimKartlari.Caption = "Cari İletişim Kartı";
            btnAdresKartlari.Caption = "Cari Adres Kartı";

            btnBagliKartlar.ItemClick += BarItem_ItemClick;
            btnIletisimKartlari.ItemClick += BarItem_ItemClick;
            btnAdresKartlari.ItemClick += BarItem_ItemClick;

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Cariler;
            FormShow = new ShowEditForms<CarilerEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar, btnIletisimKartlari, btnAdresKartlari };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CarilerBll)Bll).List(FilterFunctions.Filter<Cariler>(AktifKartlariGoster));
        }
        private void BarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BagliKartAc(e.Item);
        }
        protected override void BagliKartAc(BarItem barItem)
        {
            var entity = Tablo.GetRow<CarilerL>();
            if (entity == null) return;

            if (barItem == btnBagliKartlar)
            {
                ShowListForms<CariSubelerListForm>.ShowListForm(KartTuru.CariSubeler, entity.Id, entity.CariAdi);
            }

            else if (barItem == btnIletisimKartlari)
            {
                ShowListForms<CariIletisimListForm>.ShowListForm(KartTuru.CariIletisim, entity.Id, entity.CariAdi);
            }
            //else if (barItem == btnAdresKartlari)
            //{
            //    ShowListForms<CariAdresListForm>.ShowListForm(KartTuru.CariAdres, entity.Id, entity.CariAdi);
            //}
        }
    }
}