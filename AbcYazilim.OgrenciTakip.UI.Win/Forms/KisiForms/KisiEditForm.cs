using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Data.Contexts;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KisiForms
{
    public partial class KisiEditForm : BaseEditForm
    {
        private List<EtiketL> _tumEtiketler;
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
            var secilenEtiketIdListesi = txtEtiket.EditValue as IEnumerable<long>;
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
            BagliTabloKaydet();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, etiketTablo.TableValueChanged);

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

        private void EtiketleriYukle()
        {
            var etiketBll = new EtiketBll();
            _tumEtiketler = etiketBll.List(x => x.Durum == true).Cast<EtiketL>().ToList();
            txtEtiket.Properties.DataSource = _tumEtiketler;
            txtEtiket.Properties.DisplayMember = "EtiketAdi";
            txtEtiket.Properties.ValueMember = "Id";
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


            if (seciliEtiketIdler != null && seciliEtiketIdler.Any())
            {
                using (var db = new OgrenciTakipContext())
                {
                    // Önce bu kişiye ait eski etiket bağlantılarını sil
                    var eskiBaglantilar = db.EtiketKayitTuruBaglanti
                        .Where(x => x.KayitTuru == KayitTuru.Kisi)
                        .ToList();
                    db.EtiketKayitTuruBaglanti.RemoveRange(eskiBaglantilar);

                    // Yeni seçili etiketleri ekle
                    foreach (var etiketId in seciliEtiketIdler)
                    {
                        var baglanti = new EtiketKayitTuruBaglanti
                        {
                            EtiketId = etiketId,
                            KayitTuru = KayitTuru.Kisi,                           
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
                    .Where(x => x.KayitTuru == KayitTuru.Kisi)
                    .Select(x => x.EtiketId)
                    .ToList();

                txtEtiket.EditValue = string.Join(",", seciliEtiketler);
            }
        }
    }
}