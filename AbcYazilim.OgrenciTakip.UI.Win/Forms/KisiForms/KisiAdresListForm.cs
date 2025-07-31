using AbcYazilim.OgrenciTakip.Bll.General.KisiBll;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiAdresListForm : BaseListForm
    {
        #region Variables
        private readonly long _kisiId;
        private readonly string _kisiAdi;
        #endregion
        public KisiAdresListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new KisiAdresBll();

            _kisiId = (long)prm[0];
            _kisiAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KisiAdres;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_kisiAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiAdresBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.KisiId == _kisiId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<KisiAdresEditForm>.ShowDialogEditForm(KartTuru.KisiAdres, id, _kisiId, _kisiAdi);
            ShowEditFormDefault(result);

        }
    }
}