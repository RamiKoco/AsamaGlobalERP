using AsamaGlobal.ERP.Bll.General.CarilerBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Show;
using AsamaGlobal.ERP.UI.Win.Forms.CariForms;
using AsamaGlobal;
using AsamaGlobal.ERP;
using AsamaGlobal.ERP.UI;
using AsamaGlobal.ERP.UI.Win;
using AsamaGlobal.ERP.UI.Win.Forms;

namespace AsamaGlobal.ERP.UI.Win.Forms.CariForms.CarilerForms
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
            var result = ShowEditForms<CarilerForms.CariAdresEditForm>.ShowDialogEditForm(KartTuru.CariAdres, id, _cariId, _cariAdi);
            ShowEditFormDefault(result);

        }
    }
}