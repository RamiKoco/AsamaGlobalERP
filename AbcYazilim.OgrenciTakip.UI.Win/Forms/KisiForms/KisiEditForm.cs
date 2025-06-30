using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
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
        public KisiEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            Bll = new KisiBll(DataLayoutGenelBilgiler);
            //Herhangi bir hata olduğunda bunun içerisindeki controllere odaklan demiş olacaz
            BaseKartTuru = KartTuru.Kisi;
            EventsLoad();
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());          
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KisiS() : ((KisiBll)Bll).Single(FilterFunctions.Filter<Kisi>(Id));
            EtiketleriYukle();
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KisiBll)Bll).YeniKodVer();
            txtAdi.Focus();
        }
        private List<EtiketL> _tumEtiketler;

        private void EtiketleriYukle()
        {
            _tumEtiketler = new EtiketBll().List(null).Cast<EtiketL>().ToList();

            txtEtiket2.Properties.Tokens.Clear();
            txtEtiket2.Properties.EditMode = TokenEditMode.Manual;

            foreach (var etiket in _tumEtiketler)
            {
                txtEtiket2.Properties.Tokens.Add(new TokenEditToken(etiket.EtiketAdi, etiket.Id));
            }
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
            txtEtiket.Id = entity.EtiketId;
            txtEtiket.Text = entity.EtiketAdi;
            txtKayitKaynak.Id = entity.KayitKaynakId;
            txtKayitKaynak.Text = entity.KayitKaynakAdi;
            //txtEtiket2.EditValue = entity.Etiketler?.Select(x => x.Id).ToList();
            //txtEtiket2.EditValue = new List<long> { entity.Id };
            //txtEtiket2.EditValue = entity.Etiketler?.Select(x => x.Id).ToList();
            _tumEtiketler = new EtiketBll().List(null).OfType<EtiketL>().ToList();
            // Buraya ekle:
            //txtEtiket2.EditValue = entity.Etiketler?.Select(x => x.Id).ToList() ?? new List<long>();
            txtMeslek.Id = entity.MeslekId;
            txtMeslek.Text = entity.MeslekAdi;
            txtKisiGrubu.Id = entity.KisiGrubuId;
            txtKisiGrubu.Text = entity.KisiGrubuAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;  
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            var secilenEtiketIdListesi = txtEtiket2.EditValue as IEnumerable<long>;
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
                // Çoklu etiket ilişkisi:
                EtiketId = secilenEtiketIdListesi?.FirstOrDefault() ?? 0,
                //EtiketId = txtEtiket.Id,
                MeslekId = txtMeslek.Id,
                KisiGrubuId = txtKisiGrubu.Id,
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
                if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtKisiGrubu)
                    sec.Sec(txtKisiGrubu);
                else if (sender == txtEtiket)
                    sec.Sec(txtEtiket);
                else if (sender == txtKayitKaynak)
                    sec.Sec(txtKayitKaynak);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Kisi);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Kisi);
              
        }      
    }
}