using AbcYazilim.OgrenciTakip.Bll.General.CarilerBll.CariSubeBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto.CariDto.CariSubeDto;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms.CariSubelerForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.CariSubelerForms
{
    public partial class CariSubelerListForm : BaseListForm
    {
        #region Variables
        private readonly long _carilerId;
        private readonly string _carilerAdi;
        #endregion
        public CariSubelerListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new CariSubelerBll();

            _carilerId = (long)prm[0];
            _carilerAdi = prm[1].ToString();

            btnAdresKartlari.Caption = "Şube Adres Kartı";
            btnIletisimKartlari.Caption = "Şube İletişim Kartı";
            btnAdresKartlari.ItemClick += BarItem_ItemClick;
            btnIletisimKartlari.ItemClick += BarItem_ItemClick;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.CariSubeler;
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnAdresKartlari, btnIletisimKartlari };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariSubelerBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.CarilerId == _carilerId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<CariSubelerEditForm>.ShowDialogEditForm(KartTuru.CariSubeler, id, _carilerId, _carilerAdi);
            ShowEditFormDefault(result);

        }
        private void BarItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BagliKartAc(e.Item);
        }
        protected override void BagliKartAc(BarItem barItem)
        {
            var entity = Tablo.GetRow<CariSubelerL>();
            if (entity == null) return;

            if (barItem == btnAdresKartlari)
            {
                ShowListForms<CariSubeAdresListForm>.ShowListForm(KartTuru.CariSubeAdres, entity.Id, entity.CariSubeAdi);
            }
            else if (barItem == btnIletisimKartlari)
            {
                ShowListForms<CariSubeIletisimListForm>.ShowListForm(KartTuru.CariSubeIletisim, entity.Id, entity.CariSubeAdi);
            }
        }
    }
}