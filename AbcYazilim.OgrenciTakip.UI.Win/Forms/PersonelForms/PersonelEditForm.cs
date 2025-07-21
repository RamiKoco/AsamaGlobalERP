using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.PersonelForms
{
    public partial class PersonelEditForm : BaseEditForm
    {
        private List<EtiketL> _tumEtiketler;
        private List<long> _oldEtiketIdListesi = new List<long>();
        private List<long> _guncelEtiketIdListesi = new List<long>();
        public PersonelEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            Bll = new PersonelBll(DataLayoutGenelBilgiler);
            BaseKartTuru = KartTuru.Personel;
            EventsLoad();
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());
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
            txtAdi.Text = entity.Ad;
            txtSoyAdi.Text = entity.Soyad;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();
            imgResim.EditValue = entity.Resim;
            txtAciklama.Text = entity.Aciklama;
            txtDepartman.Id = entity.DepartmanId;
            txtDepartman.Text = entity.DepartmanAdi;
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
                Ad = txtAdi.Text,
                Soyad = txtSoyAdi.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                Resim = (byte[])imgResim.EditValue,
                Aciklama = txtAciklama.Text,
                DepartmanId = txtDepartman.Id,
                PozisyonId = txtPozisyon.Id,               
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool etiketDegisti = !_oldEtiketIdListesi?.SequenceEqual(_guncelEtiketIdListesi ?? new List<long>()) ?? false;



            bool TableValueChanged()
            {
                //if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.TableValueChanged) return true;
                //if (_adreslerTable != null && _adreslerTable.TableValueChanged) return true;
                //if (_bilgiNotlariTable != null && _bilgiNotlariTable.TableValueChanged) return true;

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

            //if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;
            //if (_iletisimBilgileriTable != null && !_iletisimBilgileriTable.Kaydet()) return false;
            //if (_adreslerTable != null && !_adreslerTable.Kaydet()) return false;
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

        //protected override void BagliTabloYukle()
        //{
        //    bool TableValueChanged(BaseTablo tablo)
        //    {
        //        return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>()
        //            .Any(x => x.Insert || x.Update || x.Delete);
        //    }


        //    //if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
        //    //    _bilgiNotlariTable.Yukle();
        //    //if (_iletisimBilgileriTable != null && TableValueChanged(_iletisimBilgileriTable))
        //    //    _iletisimBilgileriTable.Yukle();
        //    //if (_adreslerTable != null && TableValueChanged(_adreslerTable))
        //    //    _adreslerTable.Yukle();
        //}

        //protected override bool BagliTabloHataliGirisKontrol()
        //{
        //    if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
        //    {
        //        tabUst.SelectedPage = pageNotlar;
        //        _bilgiNotlariTable.Tablo.GridControl.Focus();
        //        return true;
        //    }

        //    if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HataliGiris())
        //    {
        //        tabUst.SelectedPage = pageIletisimBilgileri;
        //        _iletisimBilgileriTable.Tablo.GridControl.Focus();
        //        return true;
        //    }

        //    if (_adreslerTable != null && _adreslerTable.HataliGiris())
        //    {
        //        tabUst.SelectedPage = pageAdresBilgileri;
        //        _adreslerTable.Tablo.GridControl.Focus();
        //        return true;
        //    }

        //    return false;
        //}

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtAdi.Focus();
                txtSoyAdi.SelectAll();
            }

            //else if (e.Page == pageNotlar)
            //{
            //    if (pageNotlar.Controls.Count == 0)
            //    {
            //        _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
            //        pageNotlar.Controls.Add(_bilgiNotlariTable);
            //        _bilgiNotlariTable.Yukle();

            //    }

            //    _bilgiNotlariTable.Tablo.GridControl.Focus();

            //}

            //else if (e.Page == pageIletisimBilgileri)
            //{
            //    if (pageIletisimBilgileri.Controls.Count == 0)
            //    {
            //        _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
            //        pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
            //        _iletisimBilgileriTable.Yukle();

            //    }

            //    _iletisimBilgileriTable.Tablo.GridControl.Focus();
            //}

            //else if (e.Page == pageAdresBilgileri)
            //{
            //    if (pageAdresBilgileri.Controls.Count == 0)
            //    {
            //        _adreslerTable = new AdreslerTable().AddTable(this);
            //        pageAdresBilgileri.Controls.Add(_adreslerTable);
            //        _adreslerTable.Yukle();
            //    }

            //    _adreslerTable.Tablo.GridControl.Focus();

            //}
        }
    }
}