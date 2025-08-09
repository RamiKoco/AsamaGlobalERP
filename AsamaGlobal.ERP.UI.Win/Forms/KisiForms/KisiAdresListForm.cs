using AsamaGlobal.ERP.Bll.General.KisiBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.KisiForms
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