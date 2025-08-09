using System.Linq;
using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Common.Functions;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.UI.Win.Forms.TahakkukForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.GenelForms;
using AsamaGlobal.ERP.UI.Win.Reports.FormReports.Base;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Reports.FormReports
{
    public partial class HizmetAlimRaporu : BaseRapor
    {
        public HizmetAlimRaporu()
        {
            InitializeComponent();
        }
        protected override void DegiskenleriDoldur()
        {


            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Hizmetler = txtHizmetler;
            HizmetAlimTuru = txtHizmetAlimTuru;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            HizmetKartlariYukle();
            txtHizmetAlimTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HizmetAlimDurumu>());
            txtHizmetAlimTuru.SelectedItem = HizmetAlimDurumu.HizmetiAlanlar.ToName();
            RaporTuru = KartTuru.HizmetAlimRaporu;
        }
        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var hizmetler = txtHizmetler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();


            using (var bll = new HizmetAlimRaporBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.SubeId) &&
                    kayitSekli.Contains(x.KayitSekli) &&
                    kayitDurumu.Contains(x.KayitDurumu) &&
                    x.DonemId == AnaForm.DonemId,hizmetler,txtHizmetAlimTuru.Text.GetEnum<HizmetAlimDurumu>());

                base.Listele();

            }

        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<HizmetAlimRaporuL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }



    }
}