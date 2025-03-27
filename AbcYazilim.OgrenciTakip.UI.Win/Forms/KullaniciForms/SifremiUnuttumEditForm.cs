using System.Windows.Forms;
using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.KullaniciForms
{
    public partial class SifremiUnuttumEditForm : BaseEditForm
    {
        #region Variables
        
        private readonly string _kullaniciAdi; 

        #endregion
        public SifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGerial, btnSil };
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();

            _kullaniciAdi = prm[0].ToString();
        }

        public override void Yukle()
        {
            txtKullaniciAdi.Text = _kullaniciAdi;
        }

        protected override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayi() != DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).SingleDetail(x => x.Kod == txtKullaniciAdi.Text)
                .EntityConvert<KullaniciS>();
            if (entity == null)
            {
                Messages.HataMesaji("Veritabanında Kayıtlı Böyle Bir Kullanıcı Bulunmamaktadır.");
                return;
            }

            if (txtAdi.Text == entity.Adi && txtSoyadi.Text == entity.Soyadi && txtEmail.Text == entity.Email && txtGizliKelime.Text.Md5Sifrele() == entity.GizliKelime)
            {

                var result = Functions.GeneralFunctions.SifreUret();

                var currentEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    RolId = entity.RolId,
                    Aciklama = entity.Aciklama,
                    Durum = entity.Durum,
                    Sifre = result.sifre,
                    GizliKelime = result.gizliKelime
                };

                if (!((KullaniciBll)Bll).Update(entity, currentEntity)) return;
                var sonuc = txtKullaniciAdi.Text.SifreMailiGonder(entity.RolAdi, entity.Email,
                    result.secureSifre, result.secureGizliKelime);

                if (sonuc)
                {
                    Messages.BilgiMesaji("Şifre Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşti");
                    Close();
                }
                else
                    Messages.HataMesaji("Şifre Sıfırlama İşlemi Başarılı Bir Şekilde Gerçekleşti. Ancak E-Mail Gönderilemedi. Lütfen Tekrar Deneyiniz.");

            }
            else
                Messages.HataMesaji("Girilen Bilgiler Mevcut Bilgilerle Uyuşmuyor. Lütfen Kontrol Edip Tekrar Deneyiniz.");

        }
    }
}