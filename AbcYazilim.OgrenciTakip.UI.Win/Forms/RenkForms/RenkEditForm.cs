using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;


namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.RenkForms
{
    public partial class RenkEditForm : BaseEditForm
    {
        public RenkEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new RenkBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Renk;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Renk() : ((RenkBll)Bll).Single(FilterFunctions.Filter<Renk>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RenkBll)Bll).YeniKodVer();
            txtRenkAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Renk)OldEntity;

            txtKod.Text = entity.Kod;
            txtRenkAdi.Text = entity.RenkAdi;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Renk
            {
                Id = Id,
                Kod = txtKod.Text,
                RenkAdi = txtRenkAdi.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }

    }
}