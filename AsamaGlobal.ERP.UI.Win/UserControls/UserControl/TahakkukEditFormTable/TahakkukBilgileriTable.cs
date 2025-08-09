using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.UI.Win.Forms.TahakkukForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.GenelForms;
using AsamaGlobal.ERP.UI.Win.Show;
using AsamaGlobal.ERP.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;

namespace AsamaGlobal.ERP.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class TahakkukBilgileriTable : BaseTablo
    {
        public TahakkukBilgileriTable()
        {
            InitializeComponent();

            Bll = new TahakkukBll();
            Tablo = tablo;
            EventsLoad();

            insUptNavigator.Navigator.Buttons.Append.Visible = false;
            insUptNavigator.Navigator.Buttons.Remove.Visible = false;
            insUptNavigator.Navigator.Buttons.PrevPage.Visible = true;
            insUptNavigator.Navigator.Buttons.NextPage.Visible = true;

            HideItems = new BarItem[] {btnHareketEkle,btnHareketSil };
            ShowItems = new BarItem[] {btnKartDuzenle };


        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((TahakkukBll)Bll).OgrenciTahakkukList(x => x.OgrenciId == OwnerForm.Id);
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<OgrenciTahakkukL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }
    }
}
