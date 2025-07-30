using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
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
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kisi;
            FormShow = new ShowEditForms<KisiEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnIletisimKartlari };
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiBll)Bll).List(FilterFunctions.Filter<Kisi>(AktifKartlariGoster));
        }
        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<KisiL>();
            if (entity == null) return;
            ShowListForms<KisiIletisimListForm>.ShowListForm(KartTuru.KisiIletisim, entity.Id, entity.Ad);
        }
    }
}