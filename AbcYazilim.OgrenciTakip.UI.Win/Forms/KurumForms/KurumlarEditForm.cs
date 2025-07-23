using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KurumForms
{
    public partial class KurumlarEditForm : BaseEditForm
    {
        public KurumlarEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KurumlarBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kurumlar;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KurumlarS() : ((KurumlarBll)Bll).Single(FilterFunctions.Filter<Kurumlar>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KurumlarBll)Bll).YeniKodVer();
            txtKurumAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KurumlarS)OldEntity;
            txtKod.Text = entity.Kod;
            txtKurumAdi.Text = entity.Ad;
            txtKurumTuru.Id = entity.KurumTuruId;
            txtKurumTuru.Text = entity.KurumTuruAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kurumlar
            {
                Id = Id,
                Kod = txtKod.Text,
                Ad = txtKurumAdi.Text,
                KurumTuruId = txtKurumTuru.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Kurumlar);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Kurumlar);
                else if (sender == txtKurumTuru)
                    sec.Sec(txtKurumTuru, KartTuru.Kurumlar);


        }
    }
}