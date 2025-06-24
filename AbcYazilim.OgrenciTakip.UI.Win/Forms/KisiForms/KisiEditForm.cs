using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;

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
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;  
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kisi
            {
                Id = Id,
                Kod = txtKod.Text,               
                Ad = txtAdi.Text,
                Soyad = txtSoyAdi.Text,
                Cinsiyet = txtCinsiyet.Text.GetEnum<Cinsiyet>(),               
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                Aciklama = txtAciklama.Text,
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
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.KisiTest);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.KisiTest);
              
        }      
    }
}