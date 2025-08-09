using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.YazarForms
{
    public partial class YazarEditForm : BaseEditForm
    {
        public YazarEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new YazarBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Yazar;
            EventsLoad();
        }


        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new YazarS() : ((YazarBll)Bll).Single(FilterFunctions.Filter<Yazar>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((YazarBll)Bll).YeniKodVer();
            txtYazarAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (YazarS)OldEntity;

            txtKod.Text = entity.Kod;
            txtYazarAdi.Text = entity.YazarAdi;
            txtKitapAdi.Text = entity.KitapAdi;
            txtTarih.DateTime = entity.Tarih.Date;
            txtKurgu.Id = entity.KurguId;
            txtKurgu.Text = entity.KurguAdi;
            txtKitapTuru.Id = entity.KitapTuruId;
            txtKitapTuru.Text = entity.KitapTuruAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Yazar
            {
                Id = Id,
                Kod = txtKod.Text,
                YazarAdi = txtYazarAdi.Text,
                KitapAdi= txtKitapAdi.Text,
                Tarih = txtTarih.DateTime.Date,
                KurguId = Convert.ToInt64(txtKurgu.Id),
                KitapTuruId = Convert.ToInt64(txtKitapTuru.Id),
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
            {
                if (sender == txtKurgu)
                    sec.Sec(txtKurgu);

                else if (sender == txtKitapTuru)
                    sec.Sec(txtKitapTuru, txtKurgu);

                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Yazar);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Yazar);
            }

        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtKurgu) return;
            txtKurgu.ControlEnabledChange(txtKitapTuru);
        }
    }
}