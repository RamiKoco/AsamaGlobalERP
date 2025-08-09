using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.AdresTurleriForms
{
    public partial class AdresTurleriListForm : BaseListForm
    {
        public AdresTurleriListForm()
        {
            InitializeComponent();
            Bll = new Bll.General.AdresTurleriBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.AdresTurleri;
            FormShow = new ShowEditForms<AdresTurleriEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((Bll.General.AdresTurleriBll)Bll).List(FilterFunctions.Filter<AdresTurleri>(AktifKartlariGoster));
        }
    }
}