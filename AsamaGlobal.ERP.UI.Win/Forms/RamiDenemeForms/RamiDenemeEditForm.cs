using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraEditors;
using System;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.RamiDenemeForms
{
    public partial class RamiDenemeEditForm : BaseEditForm
    {
        public RamiDenemeEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new RamiDenemeBll(myDataLayoutControl);
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());
            BaseKartTuru = KartTuru.Rami;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new RamiDenemeS() : ((RamiDenemeBll)Bll).Single(FilterFunctions.Filter<RamiDeneme>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RamiDenemeBll)Bll).YeniKodVer();
            txtAd.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (RamiDenemeS)OldEntity;

            txtKod.Text = entity.Kod;
            txtAd.Text = entity.Ad;
            txtSoyad.Text = entity.Soyadi;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();
            txtTelefon.Text = entity.Telefon;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKimlikIl.Id = entity.KimlikIlId;
            txtKimlikIl.Text = entity.KimlikIlAdi;
            txtKimlikIlce.Id = entity.KimlikIlceId;
            txtKimlikIlce.Text = entity.KimlikIlceAdi;
            txtAciklama.Text = entity.Aciklama;
            imgResim.EditValue = entity.Resim;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new RamiDeneme
            {
                Id = Id,
                Kod = txtKod.Text,
                Ad = txtAd.Text,
                Soyadi=txtSoyad.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                Telefon = txtTelefon.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KimlikIlId = txtKimlikIl.Id,
                KimlikIlceId = txtKimlikIlce.Id,
                Aciklama = txtAciklama.Text,
                Resim = (byte[])imgResim.EditValue,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())

                if (sender == txtKimlikIl)
                    sec.Sec(txtKimlikIl);
                else if (sender == txtKimlikIlce)
                    sec.Sec(txtKimlikIlce, txtKimlikIl);
                else if (sender == txtOzelKod1)
                        sec.Sec(txtOzelKod1, KartTuru.Rami);
                    else if (sender == txtOzelKod2)
                        sec.Sec(txtOzelKod2, KartTuru.Rami);              
        }

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtKimlikIl) return;
            txtKimlikIl.ControlEnabledChange(txtKimlikIlce);

        }
        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);

        }
    }
}