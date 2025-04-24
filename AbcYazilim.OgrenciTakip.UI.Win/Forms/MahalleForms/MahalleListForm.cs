using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.MahalleForms
{
    public partial class MahalleListForm : BaseListForm
    {
        #region Variables
        private readonly long _ilceId;
        private readonly string _ilceAdi;
        #endregion
        public MahalleListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new MahalleBll();

            _ilceId = (long)prm[0];
            _ilceAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Mahalle;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_ilceAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MahalleBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IlceId == _ilceId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<MahalleEditForm>.ShowDialogEditForm(KartTuru.Mahalle, id, _ilceId, _ilceAdi);
            ShowEditFormDefault(result);

        }
    }
}