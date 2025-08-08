using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.UlkeForms
{
    public partial class UlkeEditForm : BaseEditForm
    {
        public UlkeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UlkeBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Ulke;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Ulke() : ((UlkeBll)Bll).Single(FilterFunctions.Filter<Ulke>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((UlkeBll)Bll).YeniKodVer();
            txtUlkeAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ulke)OldEntity;

            txtKod.Text = entity.Kod;
            txtUlkeAdi.Text = entity.UlkeAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Ulke
            {
                Id = Id,
                Kod = txtKod.Text,
                UlkeAdi = txtUlkeAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();

        }

    }
}