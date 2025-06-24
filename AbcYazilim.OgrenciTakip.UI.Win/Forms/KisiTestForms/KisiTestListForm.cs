using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiTestListForm : BaseListForm
    {
        public KisiTestListForm()
        {
            InitializeComponent();
            Bll = new KisiTestBll();
            ShowItems = new BarItem[] { btnTahakkukYap, btnAnimeEkle };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KisiTest;
            FormShow = new ShowEditForms<KisiTestEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiTestBll)Bll).List(FilterFunctions.Filter<KisiTest>(AktifKartlariGoster));
        }


        //protected override void AnimeEkle()
        //{
        //    var entity = tablo.GetRow<KisiL>().EntityConvert<Kisi>();

        //    using (var bll = new AnimeBll())
        //    {
        //        var anime = bll.SingleSummary(x => x.OgrenciId == entity.Id && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        //        if (anime != null)
        //            ShowEditForms<AnimeEditForm>.ShowDialogEditForm(KartTuru.Anime, anime.Id, null);
        //        else
        //            ShowEditForms<AnimeEditForm>.ShowDialogEditForm(KartTuru.Anime, -1, entity);

        //    }
        //}
    }
}