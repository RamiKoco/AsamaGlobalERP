using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KurumTuruForms
{
    public partial class KurumTuruEditForm : BaseEditForm
    {
        public KurumTuruEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KurumTuruBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.KurumTuru;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KurumTuruS() : ((KurumTuruBll)Bll).Single(FilterFunctions.Filter<KurumTuru>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KurumTuruBll)Bll).YeniKodVer();
            txtKurumTuruAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KurumTuruS)OldEntity;

            txtKod.Text = entity.Kod;
            txtKurumTuruAdi.Text = entity.Ad;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KurumTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                Ad = txtKurumTuruAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();

        }
    }
}