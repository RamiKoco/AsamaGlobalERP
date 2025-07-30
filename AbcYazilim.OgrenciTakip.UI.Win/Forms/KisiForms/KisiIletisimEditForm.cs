using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiIletisimEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _kisiId;
        private readonly string _kisiAdi;
        #endregion
        public KisiIletisimEditForm(params object[] prm)
        {
            InitializeComponent();

            _kisiId = (long)prm[0];
            _kisiAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KisiIletisimBll(myDataLayoutControl);
            txtIletisimTurleri.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimTuru>());
            txtIzinDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimDurumu>());
            txtKanallar.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<IletisimKanalTipi>()
                        .Cast<string>()
                        .Select(x => new CheckedListBoxItem(x))
                        .ToArray());
            BaseKartTuru = KartTuru.KisiIletisim;
            txtIletisimTurleri.EditValueChanged += TxtIletisimTurleri_EditValueChanged;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KisiIletisimS() : ((KisiIletisimBll)Bll).Single(FilterFunctions.Filter<KisiIletisim>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_kisiAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KisiIletisimBll)Bll).YeniKodVer(x => x.KisiId == _kisiId);
            txtBaslik.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KisiIletisimS)OldEntity;
            txtKod.Text = entity.Kod;
            txtBaslik.Text = entity.Baslik;
            txtIlgili.Text = entity.Ilgili;
            txtIletisimTurleri.EditValue = entity.IletisimTuru.ToName();
            txtKanallar.SetEditValue(entity.Kanallar);
            txtIzinDurumu.SelectedItem = entity.IzinDurumu.ToName();
            txtIzinTarihi.EditValue = entity.IzinTarihi;
            txtOncelik.Value = entity.Oncelik;
            txtWeb.Text = entity.Web;
            txtUlkeKodu.Text = entity.UlkeKodu;
            txtTelefonVeFax.Text = entity.Numara;
            txtDahili.Text = entity.DahiliNo;
            txtEPosta.Text = entity.EPosta;
            txtKullaniciAdi.Text = entity.KullaniciAdi;
            txtSIPKullaniciAdi.Text = entity.SIPKullaniciAdi;
            txtSIPServer.Text = entity.SIPServer;
            txtSosyalMedyaUrl.Text = entity.SosyalMedyaUrl;
            txtSosyalMedyaPlatformu.Id = entity.SosyalMedyaPlatformuId;
            txtSosyalMedyaPlatformu.Text = entity.SosyalMedyaPlatformuAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglVoip.IsOn = entity.VoipMi;
            tglDurum.IsOn = entity.Durum;
            ButonEnabledDurumu();
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new KisiIletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                Baslik = txtBaslik.Text,
                Ilgili = txtIlgili.Text,
                Oncelik = (short)txtOncelik.Value,
                Web = txtWeb.Text,
                IletisimTuru = txtIletisimTurleri.Text.GetEnum<IletisimTuru>(),
                IzinDurumu = txtIzinDurumu.Text.GetEnum<IletisimDurumu>(),
                Kanallar = txtKanallar.EditValue?.ToString(),
                IzinTarihi = (DateTime?)txtIzinTarihi.EditValue,
                UlkeKodu = txtUlkeKodu.Text,
                Numara = txtTelefonVeFax.Text,
                DahiliNo = txtDahili.Text,
                EPosta = txtEPosta.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                SIPServer = txtSIPServer.Text,
                SIPKullaniciAdi = txtSIPKullaniciAdi.Text,
                SosyalMedyaUrl = txtSosyalMedyaUrl.Text,
                SosyalMedyaPlatformuId = txtSosyalMedyaPlatformu.Id,
                KisiId = _kisiId,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                VoipMi = tglVoip.IsOn,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            base.ButonEnabledDurumu();
            var oldEntity = (KisiIletisim)OldEntity;
            var currentEntity = (KisiIletisim)CurrentEntity;

            btnKaydet.Enabled = oldEntity.Id != currentEntity.Id ||
                                oldEntity.Kod != currentEntity.Kod ||
                                oldEntity.Baslik != currentEntity.Baslik ||
                                oldEntity.IletisimTuru != currentEntity.IletisimTuru ||
                                oldEntity.IzinDurumu != currentEntity.IzinDurumu ||
                                oldEntity.IletisimKanalTipi != currentEntity.IletisimKanalTipi ||
                                oldEntity.Kanallar != currentEntity.Kanallar ||
                                //oldEntity.KullaniciAdi != currentEntity.KullaniciAdi ||
                                //oldEntity.SosyalMedyaUrl != currentEntity.SosyalMedyaUrl ||
                                oldEntity.SIPKullaniciAdi != currentEntity.SIPKullaniciAdi ||
                                oldEntity.SIPServer != currentEntity.SIPServer ||
                                oldEntity.Ilgili != currentEntity.Ilgili ||
                                oldEntity.Oncelik != currentEntity.Oncelik ||
                                oldEntity.VoipMi != currentEntity.VoipMi ||
                                oldEntity.IzinTarihi != currentEntity.IzinTarihi ||
                                //oldEntity.Web != currentEntity.Web ||
                                oldEntity.SosyalMedyaPlatformuId != currentEntity.SosyalMedyaPlatformuId ||
                                oldEntity.UlkeKodu != currentEntity.UlkeKodu ||
                                oldEntity.Numara != currentEntity.Numara ||
                                oldEntity.DahiliNo != currentEntity.DahiliNo ||
                                oldEntity.EPosta != currentEntity.EPosta ||
                                oldEntity.OzelKod1Id != currentEntity.OzelKod1Id ||
                                oldEntity.OzelKod2Id != currentEntity.OzelKod2Id ||
                                oldEntity.Aciklama != currentEntity.Aciklama ||
                                oldEntity.Durum != currentEntity.Durum;

            if (txtIletisimTurleri.EditValue == null) return;

            IletisimTuru iletisimTuru;

            try
            {
                iletisimTuru = EnumFunctions.GetValueFromDescription<IletisimTuru>(txtIletisimTurleri.EditValue.ToString());
            }
            catch
            {
                return;
            }

            txtUlkeKodu.Enabled = true;
            txtTelefonVeFax.Enabled = true;
            txtDahili.Enabled = true;
            txtEPosta.Enabled = true;
            txtWeb.Enabled = true;
            txtSosyalMedyaPlatformu.Enabled = true;
            txtSosyalMedyaUrl.Enabled = true;
            txtKullaniciAdi.Enabled = true;
            txtSIPKullaniciAdi.Enabled = true;
            txtSIPServer.Enabled = true;
            tglVoip.Enabled = true;

            switch (iletisimTuru)
            {
                case IletisimTuru.Telefon:
                    txtEPosta.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    break;

                case IletisimTuru.EPosta:
                    txtUlkeKodu.Enabled = false;
                    txtTelefonVeFax.Enabled = false;
                    txtDahili.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;

                case IletisimTuru.Web:
                    txtUlkeKodu.Enabled = false;
                    txtTelefonVeFax.Enabled = false;
                    txtDahili.Enabled = false;
                    txtEPosta.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;

                case IletisimTuru.SosyalMedya:
                    txtUlkeKodu.Enabled = false;
                    txtTelefonVeFax.Enabled = false;
                    txtDahili.Enabled = false;
                    txtEPosta.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;

                case IletisimTuru.Fax:
                    txtEPosta.Enabled = false;
                    txtSosyalMedyaPlatformu.Enabled = false;
                    txtWeb.Enabled = false;
                    txtSosyalMedyaUrl.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtSIPKullaniciAdi.Enabled = false;
                    txtSIPServer.Enabled = false;
                    tglVoip.Enabled = false;
                    break;
            }
        }
        private void TxtIletisimTurleri_EditValueChanged(object sender, EventArgs e)
        {
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((KisiIletisimBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KisiId == _kisiId);
        }

        protected override bool EntityUpdate()
        {
            return ((KisiIletisimBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KisiId == _kisiId);
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.KisiIletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.KisiIletisim);
                else if (sender == txtSosyalMedyaPlatformu)
                    sec.Sec(txtSosyalMedyaPlatformu, KartTuru.SosyalMedyaPlatformu);
        }
    }
}