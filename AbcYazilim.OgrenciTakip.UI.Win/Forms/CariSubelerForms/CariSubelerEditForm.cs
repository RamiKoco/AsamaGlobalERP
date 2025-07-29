using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.CariSubelerForms
{
    public partial class CariSubelerEditForm :BaseEditForm
    {
        #region Variables
        private readonly long _carilerId;
        private readonly string _carilerAdi;
        #endregion
        public CariSubelerEditForm(params object[] prm)
        {
            InitializeComponent();
            _carilerId = (long)prm[0];
            _carilerAdi = prm[1].ToString();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            Bll = new CariSubelerBll(DataLayoutGenelBilgiler);
            BaseKartTuru = KartTuru.CariSubeler;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariSubelerS() : ((CariSubelerBll)Bll).Single(FilterFunctions.Filter<CariSubeler>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_carilerAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariSubelerBll)Bll).YeniKodVer(x => x.CarilerId == _carilerId);
            txtCariSubeAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariSubelerS)OldEntity;
            txtKod.Text = entity.Kod;
            txtCariSubeAdi.Text = entity.CariSubeAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new CariSubeler
            {
                Id = Id,
                Kod = txtKod.Text,
                CariSubeAdi = txtCariSubeAdi.Text,
                CarilerId = _carilerId,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((CariSubelerBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _carilerId);
        }

        protected override bool EntityUpdate()
        {
            return ((CariSubelerBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _carilerId);
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.CariSubeler);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.CariSubeler);
        }

        protected internal override void ButonEnabledDurumu()
        {
            var oldEntity = (CariSubeler)OldEntity;
            var currentEntity = (CariSubeler)CurrentEntity;

            btnKaydet.Enabled = oldEntity.Id != currentEntity.Id ||
                                oldEntity.Kod != currentEntity.Kod ||
                                oldEntity.CariSubeAdi != currentEntity.CariSubeAdi ||
                                oldEntity.OzelKod1Id != currentEntity.OzelKod1Id ||
                                oldEntity.OzelKod2Id != currentEntity.OzelKod2Id ||
                                oldEntity.Aciklama != currentEntity.Aciklama ||
                                oldEntity.Durum != currentEntity.Durum;
        }


    }
}