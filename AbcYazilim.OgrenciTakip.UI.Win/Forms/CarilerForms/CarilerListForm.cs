using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
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

            btnBagliKartlar.Caption = "Cari Şube Kartları";

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Cariler;
            FormShow = new ShowEditForms<CarilerEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CarilerBll)Bll).List(FilterFunctions.Filter<Cariler>(AktifKartlariGoster));
        }
        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<CarilerL>();
            if (entity == null) return;
            ShowListForms<CariSubelerListForm>.ShowListForm(KartTuru.CariSubeler, entity.Id, entity.CariAdi);
        }
    }
}