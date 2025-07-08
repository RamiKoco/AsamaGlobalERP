using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base.Interfaces;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.TahakkukEditFormTable;
using DevExpress.CodeParser;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiEditForm : BaseEditForm
    {
        private BaseTablo _bilgiNotlariTable;
        private List<EtiketL> _tumEtiketler;
        private List<long> _oldEtiketIdListesi = new List<long>();
        private List<long> _guncelEtiketIdListesi = new List<long>();
        public KisiEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            Bll = new KisiBll(DataLayoutGenelBilgiler);
            BaseKartTuru = KartTuru.Kisi;
            EventsLoad();
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());          
                    
        }
        public override void Yukle()
        {
            EtiketleriYukle();
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KisiS() : ((KisiBll)Bll).Single(FilterFunctions.Filter<Kisi>(Id));          
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KisiBll)Bll).YeniKodVer();
            txtAdi.Focus();
        }
        private void EtiketleriYukle()
        {
            var etiketBll = new EtiketBll();
            _tumEtiketler = etiketBll.List(x => x.Durum == true && x.KayitTuru == KayitTuru.Kisi).Cast<EtiketL>().ToList();
            txtEtiket.Properties.DataSource = _tumEtiketler;
            txtEtiket.Properties.DisplayMember = "EtiketAdi";
            txtEtiket.Properties.ValueMember = "Id";
        }     
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KisiS)OldEntity;
            txtKod.Text = entity.Kod;          
            txtAdi.Text = entity.Ad;
            txtSoyAdi.Text = entity.Soyad;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.ToName();           
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtAciklama.Text = entity.Aciklama;
            txtKayitKaynak.Id = entity.KayitKaynakId;
            txtKayitKaynak.Text = entity.KayitKaynakAdi;
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtKisiGrubu.Id = entity.KisiGrubuId;
            txtKisiGrubu.Text = entity.KisiGrubuAdi;
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
            CurrentEntity = new Kisi
            {
                Id = Id,
                Kod = txtKod.Text,               
                Ad = txtAdi.Text,
                Soyad = txtSoyAdi.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),               
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                Aciklama = txtAciklama.Text,
                KayitKaynakId = txtKayitKaynak.Id,             
                MeslekId = txtMeslek.Id,
                KisiGrubuId = txtKisiGrubu.Id,
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
                return _bilgiNotlariTable?.TableValueChanged ?? false;
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

        protected override bool EntityInsert()
        {

            if (etiketTablo.HataliGiris()) return false;
            return ((KisiBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod ) && etiketTablo.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (etiketTablo.HataliGiris()) return false;
            return ((KisiBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && etiketTablo.Kaydet();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtKisiGrubu)
                    sec.Sec(txtKisiGrubu);
                else if (sender == txtKayitKaynak)
                    sec.Sec(txtKayitKaynak);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Kisi);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Kisi);
              
        }

        protected override void TabloYukle()
        {
            etiketTablo.OwnerForm = this;
            etiketTablo.Yukle();
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
            if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;

            if (seciliEtiketIdler != null)
            {
                using (var db = new OgrenciTakipContext())
                {
                    var eskiBaglantilar = db.EtiketKayitTuruBaglanti
                        .Where(x => x.KayitTuru == KayitTuru.Kisi && x.KayitId == Id)
                        .ToList();
                    db.EtiketKayitTuruBaglanti.RemoveRange(eskiBaglantilar);

                    foreach (var etiketId in seciliEtiketIdler)
                    {
                        var baglanti = new EtiketKayitTuruBaglanti
                        {
                            EtiketId = etiketId,
                            KayitTuru = KayitTuru.Kisi,
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
                    .Where(x => x.KayitTuru == KayitTuru.Kisi && x.KayitId == Id)
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

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>()
                    .Any(x => x.Insert || x.Update || x.Delete);
            }


            if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
                _bilgiNotlariTable.Yukle();
        }

        protected override bool BagliTabloHataliGirisKontrol()
        {  
            if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
            {
                tabUst.SelectedPage = pageNotlar;
                _bilgiNotlariTable.Tablo.GridControl.Focus();
                return true;
            }      

            return false;
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtAdi.Focus();
                txtSoyAdi.SelectAll();
            }

      
            else if (e.Page == pageNotlar)
            {
                if (pageNotlar.Controls.Count == 0)
                {
                    _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
                    pageNotlar.Controls.Add(_bilgiNotlariTable);
                    _bilgiNotlariTable.Yukle();

                }

                _bilgiNotlariTable.Tablo.GridControl.Focus();

            }
            
        }
    

    }
}