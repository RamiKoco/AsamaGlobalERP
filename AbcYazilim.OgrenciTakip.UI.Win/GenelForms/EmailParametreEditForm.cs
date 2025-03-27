using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Functions;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.GenelForms
{
    public partial class EmailParametreEditForm : BaseEditForm
    {
        public EmailParametreEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MailParametreBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnSil };
            txtSssKullan.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            EventsLoad();

        }
        public override void Yukle()
        {
            OldEntity = ((MailParametreBll)Bll).Single(null) ?? new MailParametre();
            ((MailParametre)OldEntity).Sifre = "Bu Email Şifresidir".Encrypt(OldEntity.Id + OldEntity.Kod);

            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = "Email";
            txtEmail.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MailParametre)OldEntity;

            Id = entity.Id;
            txtKod.Text = entity.Kod;
            txtEmail.Text = entity.Email;
            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert ? null : entity.Sifre.Decrypt(entity.Id + entity.Kod);
            txtPortNo.Value = entity.PortNo;
            txtHost.Text = entity.Host;
            txtSssKullan.SelectedItem = entity.SslKullan.ToName();
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new MailParametre
            {
                Id = Id,
                Kod = txtKod.Text,
                Email = txtEmail.Text,
                Sifre = string.IsNullOrWhiteSpace(txtSifre.Text) ? null : txtSifre.Text.Encrypt(Id+txtKod.Text),
                PortNo = (int)txtPortNo.Value,
                Host = txtHost.Text,
                SslKullan = txtSssKullan.Text.GetEnum<EvetHayir>()
            };
            ButonEnabledDurumu();

        }

    }
}