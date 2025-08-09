using AbcYazilim.OgrenciTakip.Bll.General.CarilerBll.CariSubeBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.CariForms.CariSubelerForms
{
    public partial class CariSubeAdresListForm : BaseListForm
    {
        #region Variables
        private readonly long _cariSubeId;
        private readonly string _cariSubeAdi;
        #endregion
        public CariSubeAdresListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new CariSubeAdresBll();

            _cariSubeId = (long)prm[0];
            _cariSubeAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.CariSubeAdres;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_cariSubeAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariSubeAdresBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.CariSubelerId == _cariSubeId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<CariSubeAdresEditForm>.ShowDialogEditForm(KartTuru.CariSubeAdres, id, _cariSubeId, _cariSubeAdi);
            ShowEditFormDefault(result);

        }
    }
}