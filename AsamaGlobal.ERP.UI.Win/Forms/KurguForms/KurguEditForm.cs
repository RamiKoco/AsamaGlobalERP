using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KurguForms
{
    public partial class KurguEditForm : BaseEditForm
    {
        public KurguEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KurguBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kurgu;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kurgu() : ((KurguBll)Bll).Single(FilterFunctions.Filter<Kurgu>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KurguBll)Bll).YeniKodVer();
            txtKurguAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kurgu)OldEntity;

            txtKod.Text = entity.Kod;
            txtKurguAdi.Text = entity.KurguAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kurgu
            {
                Id = Id,
                Kod = txtKod.Text,
                KurguAdi = txtKurguAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();

        }
    }
}