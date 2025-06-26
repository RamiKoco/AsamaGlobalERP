using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraEditors;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.EtiketForms
{
    public partial class EtiketEditForm : BaseEditForm
    {
        public EtiketEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new EtiketBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Etiket;
            EventsLoad();
            txtKayitTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KayitTuru>());
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new EtiketS() : ((EtiketBll)Bll).Single(FilterFunctions.Filter<Etiket>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((EtiketBll)Bll).YeniKodVer();
            txtEtiketAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (EtiketS)OldEntity;

            txtKod.Text = entity.Kod;
            txtEtiketAdi.Text = entity.Ad;
            txtKayitTuru.SelectedItem = entity.KayitTuru.ToName();
            txtRenk.Id = entity.RenkId;
            txtRenk.Text = entity.RenkAdi;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Etiket
            {
                Id = Id,
                Kod = txtKod.Text,
                Ad = txtEtiketAdi.Text,
                KayitTuru = txtKayitTuru.Text.GetEnum<KayitTuru>(),
                RenkId= txtRenk.Id,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtRenk)
                    sec.Sec(txtRenk);               

        }
    }
}