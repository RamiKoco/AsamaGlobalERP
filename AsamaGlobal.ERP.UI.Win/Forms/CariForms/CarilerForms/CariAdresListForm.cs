using AsamaGlobal.ERP.Bll.General.CarilerBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.CariForms
{
    public partial class CariAdresListForm :BaseListForm
    {
        #region Variables
        private readonly long _cariId;
        private readonly string _cariAdi;
        #endregion
        public CariAdresListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new CariAdresBll();

            _cariId = (long)prm[0];
            _cariAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.CariAdres;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_cariAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariAdresBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.CarilerId == _cariId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<CariAdresEditForm>.ShowDialogEditForm(KartTuru.CariAdres, id, _cariId, _cariAdi);
            ShowEditFormDefault(result);

        }
    }
}