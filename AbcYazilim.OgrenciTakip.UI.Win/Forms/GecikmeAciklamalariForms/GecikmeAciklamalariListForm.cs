using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.GecikmeAciklamalariForms
{
    public partial class GecikmeAciklamalariListForm : BaseListForm
    {
        #region Variables
        private readonly int _portfoyNo;
        #endregion

        public GecikmeAciklamalariListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new GecikmeAciklamalariBll();
            HideItems = new BarItem[] { btnSec };

            _portfoyNo = (int)prm[0];
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Aciklama;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((GecikmeAciklamalariBll)Bll).List(x =>  x.OdemeBilgileriId == _portfoyNo);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<GecikmeAciklamalariEditForm>.ShowDialogEditForm(KartTuru.Aciklama, id, _portfoyNo);
            ShowEditFormDefault(result);

        }

    }
}