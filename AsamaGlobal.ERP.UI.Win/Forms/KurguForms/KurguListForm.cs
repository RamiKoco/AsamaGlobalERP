using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlceForms;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.IlForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KurguForms
{
    public partial class KurguListForm : BaseListForm
    {
        public KurguListForm()
        {
            InitializeComponent();
            Bll = new KurguBll();
            btnBagliKartlar.Caption = "Kurgu Kartları";
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Kurgu;
            FormShow = new ShowEditForms<KurguEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
                ShowItems = new BarItem[] { btnBagliKartlar };
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KurguBll)Bll).List(FilterFunctions.Filter<Kurgu>(AktifKartlariGoster));

        }

        //protected override void BagliKartAc()
        //{
        //    var entity = Tablo.GetRow<Kurgu>();
        //    if (entity == null) return;
        //    ShowListForms<KitapTuruListForm>.ShowListForm(KartTuru.Kurgu, entity.Id, entity.KurguAdi);
        //}
    }
}