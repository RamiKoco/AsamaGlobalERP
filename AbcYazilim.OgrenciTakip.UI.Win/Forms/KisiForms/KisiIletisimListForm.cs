using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiIletisimListForm : BaseListForm
    {
        #region Variables
        private readonly long _kisiId;
        private readonly string _kisiAdi;
        #endregion
        public KisiIletisimListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new KisiIletisimBll();

            _kisiId = (long)prm[0];
            _kisiAdi = prm[1].ToString();

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;            
            BaseKartTuru = KartTuru.KisiIletisim;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_kisiAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiIletisimBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.KisiId == _kisiId);            
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<KisiIletisimEditForm>.ShowDialogEditForm(KartTuru.KisiIletisim, id, _kisiId, _kisiAdi);
            ShowEditFormDefault(result);

        }
    }
}