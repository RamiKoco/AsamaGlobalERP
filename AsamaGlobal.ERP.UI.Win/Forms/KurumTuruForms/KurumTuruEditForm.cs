using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;

namespace AsamaGlobal.ERP.UI.Win.Forms.KurumTuruForms
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