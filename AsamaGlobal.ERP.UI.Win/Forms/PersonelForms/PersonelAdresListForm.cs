using AsamaGlobal.ERP.Bll.General.PersonelBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.PersonelForms
{
    public partial class PersonelAdresListForm : BaseListForm
    {
        #region Variables
        private readonly long _personelId;
        private readonly string _personelAdi;
        #endregion
        public PersonelAdresListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new PersonelAdresBll();

            _personelId = (long)prm[0];
            _personelAdi = prm[1].ToString();
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.PersonelAdres;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_personelAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PersonelAdresBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.PersonelId == _personelId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<PersonelAdresEditForm>.ShowDialogEditForm(KartTuru.PersonelAdres, id, _personelId, _personelAdi);
            ShowEditFormDefault(result);

        }
    }
}