using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.KitapTuru;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KitapTuruForms
{
    public partial class KitapTuruEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _kurguId;
        private readonly string _kurguAdi;

        #endregion
        public KitapTuruEditForm(params object[] prm)
        {
            InitializeComponent();
            _kurguId = (long)prm[0];
            _kurguAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KitapTuruBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.KitapTuru;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KitapTuru() : ((KitapTuruBll)Bll).Single(FilterFunctions.Filter<KitapTuru>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_kurguAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KitapTuruBll)Bll).YeniKodVer(x => x.KurguId == _kurguId);
            txtKitapTuruAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KitapTuru)OldEntity;

            txtKod.Text = entity.Kod;
            txtKitapTuruAdi.Text = entity.KitapTuruAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KitapTuru
            {
                Id = Id,
                Kod = txtKod.Text,
                KitapTuruAdi = txtKitapTuruAdi.Text,
                KurguId = _kurguId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((KitapTuruBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KurguId == _kurguId);
        }

        protected override bool EntityUpdate()
        {
            return ((KitapTuruBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KurguId == _kurguId);
        }

    }
}