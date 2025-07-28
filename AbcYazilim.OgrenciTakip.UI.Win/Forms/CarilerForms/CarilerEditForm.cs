using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.CarilerForms
{
    public partial class CarilerEditForm : BaseEditForm
    {
        public CarilerEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new CarilerBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Cariler;
            EventsLoad();
            txtKimlikNo.Validating += TxtKimlikNo_Validating;
            txtKimlikTuru.EditValueChanged += TxtKimlikTuru_EditValueChanged;
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CarilerS() : ((CarilerBll)Bll).Single(FilterFunctions.Filter<Cariler>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CarilerBll)Bll).YeniKodVer();
            txtAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CarilerS)OldEntity;

            txtKod.Text = entity.Kod;
            txtCariAdi.Text = entity.CariAdi;
            txtKimlikNo.Text = entity.KimlikNo;
            txtAdi.Text = entity.Ad;
            txtSoyAdi.Text = entity.Soyad;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtVergiKodu.Text = entity.VergiKodu;
            txtKimlikTuru.Id = entity.KimlikTuruId;
            TxtKimlikTuru_IdChanged(txtKimlikTuru, EventArgs.Empty);
            txtKimlikTuru.Text = entity.KimlikTuruAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Cariler
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCariAdi.Text,
                KimlikNo = txtKimlikNo.Text,
                Ad = txtAdi.Text,
                Soyad = txtSoyAdi.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                VergiKodu = txtVergiKodu.Text,
                KimlikTuruId = txtKimlikTuru.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
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
                    sec.Sec(txtOzelKod1, KartTuru.Cariler);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Cariler);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Cariler);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Cariler);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Cariler);
                else if (sender == txtKimlikTuru)
                {
                    sec.Sec(txtKimlikTuru);

                    if (txtKimlikTuru.Id != null)
                    {
                        var bll = new KimlikTuruBll();
                        var secilen = bll.Single(x => x.Id == (long)txtKimlikTuru.Id) as KimlikTuru;
                        int yeniUzunluk = secilen?.Uzunluk ?? 11;
                        string karakterTipi = secilen?.KarakterTipi;

                        // Zorunlu uzunluk
                        txtKimlikNo.Properties.MaxLength = yeniUzunluk;

                        // Maske ayarları
                        txtKimlikNo.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
                        txtKimlikNo.Properties.Mask.UseMaskAsDisplayFormat = true;

                        if (karakterTipi == "Numeric")
                        {
                            txtKimlikNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                            txtKimlikNo.Properties.Mask.EditMask = $@"\d{{{yeniUzunluk}}}";
                        }
                        else if (karakterTipi == "AlphaNumeric")
                        {
                            txtKimlikNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                            txtKimlikNo.Properties.Mask.EditMask = $@"[a-zA-Z0-9]{{{yeniUzunluk}}}";
                        }
                        else
                        {
                            txtKimlikNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                            txtKimlikNo.Properties.Mask.EditMask = null;
                        }

                        // Giriş fazlaysa kırp
                        if (txtKimlikNo.Text.Length > yeniUzunluk)
                            txtKimlikNo.Text = txtKimlikNo.Text.Substring(0, yeniUzunluk);
                    }
                }

        }

        private void TxtKimlikTuru_IdChanged(object sender, EventArgs e)
        {
            if (txtKimlikTuru.Id == null)
                return;

            var bll = new KimlikTuruBll();
            var secilen = bll.Single(x => x.Id == (long)txtKimlikTuru.Id) as KimlikTuru;

            int yeniUzunluk = secilen?.Uzunluk ?? 11;
            txtKimlikNo.Properties.MaxLength = yeniUzunluk;

            if (txtKimlikNo.Text.Length > yeniUzunluk)
                txtKimlikNo.Text = txtKimlikNo.Text.Substring(0, yeniUzunluk);
        }
        private void TxtKimlikTuru_EditValueChanged(object sender, EventArgs e)
        {
            if (txtKimlikTuru.EditValue == null)
                return;

            var bll = new KimlikTuruBll();

            if (long.TryParse(txtKimlikTuru.EditValue.ToString(), out long secilenId))
            {
                var secilen = bll.Single(x => x.Id == secilenId) as KimlikTuru;
                if (secilen == null)
                    return;

                int yeniUzunluk = secilen.Uzunluk;

                // MaxLength ayarla
                txtKimlikNo.Properties.MaxLength = yeniUzunluk;

                // Mask kapalı, çünkü Validating ile kontrol ediyoruz
                txtKimlikNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                txtKimlikNo.Properties.Mask.EditMask = null;
            }
        }
        private void TxtKimlikNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtKimlikTuru.Id == null)
                return;

            var bll = new KimlikTuruBll();
            var secilen = bll.Single(x => x.Id == (long)txtKimlikTuru.Id) as KimlikTuru;

            if (secilen == null)
                return;

            int istenenUzunluk = secilen.Uzunluk;
            string karakterTipi = secilen.KarakterTipi;
            string girilen = txtKimlikNo.Text.Trim();

            // Uzunluk kontrolü
            if (girilen.Length != istenenUzunluk)
            {
                Messages.UyariMesaji($"Kimlik numarası {istenenUzunluk} karakter olmalıdır.");
                e.Cancel = true;
                return;
            }

            // Karakter tipi kontrolü
            if (karakterTipi == "Numeric")
            {
                // Sadece rakam kontrolü
                if (!System.Text.RegularExpressions.Regex.IsMatch(girilen, @"^\d+$"))
                {
                    Messages.UyariMesaji("Kimlik numarası sadece rakamlardan oluşmalıdır.");
                    e.Cancel = true;
                    return;
                }
            }
            else if (karakterTipi == "AlphaNumeric")
            {
                // Harf ve rakam kontrolü
                if (!System.Text.RegularExpressions.Regex.IsMatch(girilen, @"^[a-zA-Z0-9]+$"))
                {
                    Messages.UyariMesaji("Kimlik numarası sadece harf ve rakamlardan oluşmalıdır.");
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}