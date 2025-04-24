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
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
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
                IlId = Convert.ToInt64(txtIl.Id),
                IlceId = Convert.ToInt64(txtIlce.Id),
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
                if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
            }

        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl) return;
            txtIl.ControlEnabledChange(txtIlce);
        }
    }
}