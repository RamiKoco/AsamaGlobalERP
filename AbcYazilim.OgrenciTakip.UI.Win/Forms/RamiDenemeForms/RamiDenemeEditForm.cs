using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.RamiDenemeForms
{
    public partial class RamiDenemeEditForm : BaseEditForm
    {
        public RamiDenemeEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new RamiDenemeBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Rami;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new RamiDeneme() : ((RamiDenemeBll)Bll).Single(FilterFunctions.Filter<RamiDeneme>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RamiDenemeBll)Bll).YeniKodVer();
            txtAd.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (RamiDeneme)OldEntity;

            txtKod.Text = entity.Kod;
            txtAd.Text = entity.Ad;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new RamiDeneme
            {
                Id = Id,
                Kod = txtKod.Text,
                Ad = txtAd.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();

        }
    }
}