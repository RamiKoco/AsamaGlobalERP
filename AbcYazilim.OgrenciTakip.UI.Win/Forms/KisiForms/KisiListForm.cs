using AbcYazilim.OgrenciTakip.Bll.General.KisiBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto.KisiDto;
using AbcYazilim.OgrenciTakip.Model.Entities.Kisi;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;


namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiListForm : BaseListForm
    {
        public KisiListForm()
        {
            InitializeComponent();
            Bll = new KisiBll();

            btnIletisimKartlari.Caption = "İletişim Kartları";
            btnAdresKartlari.Caption = "Adres Kartları";

            btnIletisimKartlari.ItemClick += BarItem_ItemClick;
            btnAdresKartlari.ItemClick += BarItem_ItemClick;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kisi;
            FormShow = new ShowEditForms<KisiEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnIletisimKartlari, btnAdresKartlari };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiBll)Bll).List(FilterFunctions.Filter<Kisi>(AktifKartlariGoster));
        }
        private void BarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BagliKartAc(e.Item);
        }
        protected override void BagliKartAc(BarItem barItem)
        {
            var entity = Tablo.GetRow<KisiL>();
            if (entity == null) return;

            if (barItem == btnIletisimKartlari)
            {
                ShowListForms<KisiIletisimListForm>.ShowListForm(KartTuru.KisiIletisim, entity.Id, entity.Ad);
            }
            else if (barItem == btnAdresKartlari)
            {
                ShowListForms<KisiAdresListForm>.ShowListForm(KartTuru.KisiAdres, entity.Id, entity.Ad);
            }
        }
    }
}