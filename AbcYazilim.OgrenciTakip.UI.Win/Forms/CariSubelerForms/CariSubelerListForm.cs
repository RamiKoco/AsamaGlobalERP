using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

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
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.CariSubeler;
            Navigator = longNavigator.Navigator;
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
    }
}