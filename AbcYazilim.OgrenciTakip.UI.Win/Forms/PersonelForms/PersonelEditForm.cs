using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.PersonelEditFormTable;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.PersonelForms
{
    public partial class PersonelEditForm : BaseEditForm
    {
        private BaseTablo _adreslerTable;
        private BaseTablo _iletisimBilgileriTable;
        private List<EtiketL> _tumEtiketler;
        private List<long> _oldEtiketIdListesi = new List<long>();
        private List<long> _guncelEtiketIdListesi = new List<long>();
        public PersonelEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler, DataLayoutControlKisiselBilgiler };
            Bll = new PersonelBll(DataLayoutGenelBilgiler);
            BaseKartTuru = KartTuru.Personel;
            EventsLoad();
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            txtAskerlikDurumu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AskerlikDurumu>());
            txtMedeniDurum.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<MedeniDurum>());
            // Diğer initializationlar...
            txtKimlikNo.Validating += TxtKimlikNo_Validating;
            txtKimlikTuru.EditValueChanged += TxtKimlikTuru_EditValueChanged;
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
        public override void Yukle()
        {
            EtiketleriYukle();
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PersonelS() : ((PersonelBll)Bll).Single(FilterFunctions.Filter<Personel>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PersonelBll)Bll).YeniKodVer();
            txtAdi.Focus();
        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>()
                    .Any(x => x.Insert || x.Update || x.Delete);
            }


            //if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
            //    _bilgiNotlariTable.Yukle();
            if (_iletisimBilgileriTable != null && TableValueChanged(_iletisimBilgileriTable))
                _iletisimBilgileriTable.Yukle();
            if (_adreslerTable != null && TableValueChanged(_adreslerTable))
                _adreslerTable.Yukle();
        }
        private void EtiketleriYukle()
        {
            var etiketBll = new EtiketBll();
            _tumEtiketler = etiketBll.List(x => x.Durum == true && x.KayitTuru == KayitTuru.Personel).Cast<EtiketL>().ToList();
            txtEtiket.Properties.DataSource = _tumEtiketler;
            txtEtiket.Properties.DisplayMember = "EtiketAdi";
            txtEtiket.Properties.ValueMember = "Id";
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PersonelS)OldEntity;  
            txtKod.Text = entity.Kod;
            txtKimlikNo.Text = entity.KimlikNo;
            txtAdi.Text = entity.Ad;
            txtSoyAdi.Text = entity.Soyad;
            txtAnaAdi.Text = entity.AnaAdi;
            txtBabaAdi.Text = entity.BabaAdi;
            txtSGKSicilNo.Text = entity.SGKSicilNo;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();
            txtKanGrubu.SelectedItem = entity.KanGrubu.ToName();
            txtAskerlikDurumu.SelectedItem = entity.AskerlikDurumu.ToName();
            txtMedeniDurum.SelectedItem = entity.MedeniDurum.ToName();
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            imgResim.EditValue = entity.Resim;
            txtAciklama.Text = entity.Aciklama;
            txtDepartman.Id = entity.DepartmanId;
            txtDepartman.Text = entity.DepartmanAdi;
            txtKimlikTuru.Id = entity.KimlikTuruId;
            TxtKimlikTuru_IdChanged(txtKimlikTuru, EventArgs.Empty); 
            txtKimlikTuru.Text = entity.KimlikTuruAdi;   
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtUyruk.Id = entity.UyrukId;
            txtUyruk.Text = entity.UyrukAdi;
            txtPozisyon.Id = entity.PozisyonId;
            txtPozisyon.Text = entity.PozisyonAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            tglDurum.IsOn = entity.Durum;

            KisiyeAitEtiketleriYukle();
        }
        protected override void GuncelNesneOlustur()
        {
            var etiketValue = txtEtiket.EditValue;
            if (etiketValue is string str)
            {
                _guncelEtiketIdListesi = str
                    .Split(',')
                    .Select(x => long.TryParse(x, out var val) ? val : 0)
                    .Where(x => x > 0)
                    .ToList();
            }
            else
                _guncelEtiketIdListesi = new List<long>();

            CurrentEntity = new Personel
            {
                Id = Id,
                Kod = txtKod.Text,
                KimlikNo = txtKimlikNo.Text,
                Ad = txtAdi.Text,
                Soyad = txtSoyAdi.Text,
                BabaAdi = txtBabaAdi.Text,
                AnaAdi = txtAnaAdi.Text,
                SGKSicilNo = txtSGKSicilNo.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                MedeniDurum = txtMedeniDurum.Text.GetEnum<MedeniDurum>(),
                AskerlikDurumu = txtAskerlikDurumu.Text.GetEnum<AskerlikDurumu>(),
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                Resim = (byte[])imgResim.EditValue,
                Aciklama = txtAciklama.Text,
                DepartmanId = txtDepartman.Id,
                UyrukId = txtUyruk.Id,
                KimlikTuruId = txtKimlikTuru.Id,
                MeslekId = txtMeslek.Id,
                PozisyonId = txtPozisyon.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }

        protected override bool BagliTabloHataliGirisKontrol()
        {
            //if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
            //{
            //    tabUst.SelectedPage = pageNotlar;
            //    _bilgiNotlariTable.Tablo.GridControl.Focus();
            //    return true;
            //}

            if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HataliGiris())
            {
                tabUst.SelectedPage = pageIletisimBilgileri;
                _iletisimBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }

            if (_adreslerTable != null && _adreslerTable.HataliGiris())
            {
                tabUst.SelectedPage = pageAdresBilgileri;
                _adreslerTable.Tablo.GridControl.Focus();
                return true;
            }

            return false;
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool etiketDegisti = !_oldEtiketIdListesi?.SequenceEqual(_guncelEtiketIdListesi ?? new List<long>()) ?? false;



            bool TableValueChanged()
            {
                if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.TableValueChanged) return true;
                if (_adreslerTable != null && _adreslerTable.TableValueChanged) return true;
                return false;
            }

            if (FarkliSubeIslemi)
            {
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil);
            }
            else if (TableValueChanged())
            {
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, true);
            }
            else
            {
                GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, etiketDegisti);
            }
        }

        protected override bool BagliTabloKaydet()
        {
            var seciliEtiketIdler = txtEtiket.EditValue as IEnumerable<long>
                         ?? txtEtiket.EditValue as long[]
                         ?? txtEtiket.EditValue?.ToString()
                         ?.Split(',')
                         ?.Select(x => long.TryParse(x, out var val) ? val : 0)
                         ?.Where(x => x > 0)
                         ?.ToArray();
            if (_iletisimBilgileriTable != null && !_iletisimBilgileriTable.Kaydet()) return false;
            if (_adreslerTable != null && !_adreslerTable.Kaydet()) return false;

            if (seciliEtiketIdler != null)
            {
                using (var db = new OgrenciTakipContext())
                {
                    var eskiBaglantilar = db.EtiketKayitTuruBaglanti
                        .Where(x => x.KayitTuru == KayitTuru.Personel && x.KayitId == Id)
                        .ToList();
                    db.EtiketKayitTuruBaglanti.RemoveRange(eskiBaglantilar);

                    foreach (var etiketId in seciliEtiketIdler)
                    {
                        var baglanti = new EtiketKayitTuruBaglanti
                        {
                            EtiketId = etiketId,
                            KayitTuru = KayitTuru.Personel,
                            KayitId = Id
                        };
                        db.EtiketKayitTuruBaglanti.Add(baglanti);
                    }
                    db.SaveChanges();
                }
            }

            return true;
        }

        private void KisiyeAitEtiketleriYukle()
        {
            using (var db = new OgrenciTakipContext())
            {
                var seciliEtiketler = db.EtiketKayitTuruBaglanti
                    .Where(x => x.KayitTuru == KayitTuru.Personel && x.KayitId == Id)
                    .Select(x => x.EtiketId)
                    .ToList();

                txtEtiket.EditValue = string.Join(",", seciliEtiketler);

                _oldEtiketIdListesi = seciliEtiketler;
            }
        }

        public override bool Kaydet(bool kapanis)
        {
            if (txtKimlikTuru.Id != null)
            {
                var bll = new KimlikTuruBll();
                var secilen = bll.Single(x => x.Id == (long)txtKimlikTuru.Id) as KimlikTuru;
                int istenenUzunluk = secilen?.Uzunluk ?? 0;
                string karakterTipi = secilen?.KarakterTipi;
                string girilen = txtKimlikNo.Text?.Trim();

                // MASK boşluklarını temizle (örn: ____)
                girilen = girilen?.Replace("_", "");

                // Uzunluk kontrolü
                if (girilen.Length != istenenUzunluk)
                {
                    Messages.UyariMesaji($"Kimlik numarası tam {istenenUzunluk} karakter olmalıdır.");
                    return false;
                }

                // Karakter tipi kontrolü
                if (karakterTipi == "Numeric" && !System.Text.RegularExpressions.Regex.IsMatch(girilen, @"^\d+$"))
                {
                    Messages.UyariMesaji("Kimlik numarası sadece sayılardan oluşmalıdır.");
                    return false;
                }

                if (karakterTipi == "AlphaNumeric" && !System.Text.RegularExpressions.Regex.IsMatch(girilen, @"^[a-zA-Z0-9]+$"))
                {
                    Messages.UyariMesaji("Kimlik numarası sadece harf ve rakamlardan oluşmalıdır.");
                    return false;
                }
            }

            BagliTabloKaydet();
            _oldEtiketIdListesi = _guncelEtiketIdListesi.ToList();
            var sonuc = base.Kaydet(kapanis);
            return sonuc;
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtDepartman)
                    sec.Sec(txtDepartman);
                else if (sender == txtPozisyon)
                    sec.Sec(txtPozisyon);
                else if (sender == txtUyruk)
                    sec.Sec(txtUyruk);
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
                else if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Personel);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Personel);

        }
        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);

        }   

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtAdi.Focus();
                txtSoyAdi.SelectAll();
            }
            else if (e.Page == pageIletisimBilgileri)
            {
                if (pageIletisimBilgileri.Controls.Count == 0)
                {
                    _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
                    pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
                    _iletisimBilgileriTable.Yukle();

                }

                _iletisimBilgileriTable.Tablo.GridControl.Focus();

            }
            else if (e.Page == pageAdresBilgileri)
            {
                if (pageAdresBilgileri.Controls.Count == 0)
                {
                    _adreslerTable = new AdreslerTable().AddTable(this);
                    pageAdresBilgileri.Controls.Add(_adreslerTable);
                    _adreslerTable.Yukle();
                }

                _adreslerTable.Tablo.GridControl.Focus();

            }
        }
    }
}