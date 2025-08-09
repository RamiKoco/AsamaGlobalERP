using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.MahalleForms
{
    public partial class MahalleEditForm : BaseEditForm
    {
        #region Variables
        
        private readonly long _ilceId;
        private readonly string _ilceAdi;

        #endregion

        public MahalleEditForm(params object[] prm)
        {
            InitializeComponent();           
            _ilceId = (long)prm[0];
            _ilceAdi = prm[1].ToString();


            DataLayoutControl = myDataLayoutControl;
            Bll = new MahalleBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Mahalle;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Mahalle() : ((MahalleBll)Bll).Single(FilterFunctions.Filter<Mahalle>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_ilceAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MahalleBll)Bll).YeniKodVer(x => x.IlceId == _ilceId);
            txtMahalleAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Mahalle)OldEntity;

            txtKod.Text = entity.Kod;
            txtMahalleAdi.Text = entity.MahalleAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Mahalle
            {
                Id = Id,
                Kod = txtKod.Text,
                MahalleAdi = txtMahalleAdi.Text,
                IlceId = _ilceId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((MahalleBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlceId == _ilceId);
        }

        protected override bool EntityUpdate()
        {
            return ((MahalleBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.IlceId == _ilceId);
        }
    }
}