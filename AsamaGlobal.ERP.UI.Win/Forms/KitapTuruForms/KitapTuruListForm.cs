using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KitapTuruForms
{
    public partial class KitapTuruListForm : BaseListForm
    {
        #region Variables
        private readonly long _kurguId;
        private readonly string _kurguAdi;
        #endregion
        public KitapTuruListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new KitapTuruBll();

            _kurguId = (long)prm[0];
            _kurguAdi = prm[1].ToString();
            btnBagliKartlar.Caption = "Kitap Türü Kartları";
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KitapTuru;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_kurguAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KitapTuruBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.KurguId == _kurguId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<KitapTuruEditForm>.ShowDialogEditForm(KartTuru.KitapTuru, id, _kurguId, _kurguAdi);
            ShowEditFormDefault(result);

        }
    }
}