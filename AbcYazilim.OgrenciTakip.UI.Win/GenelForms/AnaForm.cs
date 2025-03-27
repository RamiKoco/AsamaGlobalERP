using AbcYazilim.OgrenciTakip.UI.Win.Forms.OkulForms;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.GenelForms
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {         

            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {

            if(e.Item == btnOkulKartlari)
            {
                OkulKartlari frm = new OkulKartlari();
                frm.MdiParent = ActiveForm;
                frm.Show();
            }

            //Cursor.Current = Cursors.WaitCursor;

            //if (e.Item == btnOkulKartlari)
            //    ShowListForms<OkulListForm>.ShowListForm(KartTuru.Okul);
            //else if (e.Item == btnIlKartlari)
            //    ShowListForms<IlListForm>.ShowListForm(KartTuru.Il);
            //else if (e.Item == btnAileBilgiKartlari)
            //    ShowListForms<AileBilgiListForm>.ShowListForm(KartTuru.AileBilgi);
            //else if (e.Item == btnIptalNedeniKartlari)
            //    ShowListForms<IptalNedeniListForm>.ShowListForm(KartTuru.IptalNedeni);
            //else if (e.Item == btnYabanciDilKartlari)
            //    ShowListForms<YabanciDilListForm>.ShowListForm(KartTuru.YabanciDil);
            //else if (e.Item == btnTesvikKartlari)
            //    ShowListForms<TesvikListForm>.ShowListForm(KartTuru.Tesvik);
            //else if (e.Item == btnKontenjanKartlari)
            //    ShowListForms<KontenjanListForm>.ShowListForm(KartTuru.Kontenjan);
            //else if (e.Item == btnRehberKartlari)
            //    ShowListForms<RehberListForm>.ShowListForm(KartTuru.Rehber);
            //else if (e.Item == btnSinifGrupKartlari)
            //    ShowListForms<SinifGrupListForm>.ShowListForm(KartTuru.SinifGrup);
            //else if (e.Item == btnMeslekKartlari)
            //    ShowListForms<MeslekListForm>.ShowListForm(KartTuru.Meslek);
            //else if (e.Item == btnYakinlikKartlari)
            //    ShowListForms<YakinlikListForm>.ShowListForm(KartTuru.Yakinlik);
            //else if (e.Item == btnIsyeriKartlari)
            //    ShowListForms<IsyeriListForm>.ShowListForm(KartTuru.Isyeri);
            //else if (e.Item == btnGorevKartlari)
            //    ShowListForms<GorevListForm>.ShowListForm(KartTuru.Gorev);
            //else if (e.Item == btnIndirimTuruKartlari)
            //    ShowListForms<IndirimTuruListForm>.ShowListForm(KartTuru.IndirimTuru);
            //else if (e.Item == btnEvrakKartlari)
            //    ShowListForms<EvrakListForm>.ShowListForm(KartTuru.Evrak);
            //else if (e.Item == btnPromosyonKartlari)
            //    ShowListForms<PromosyonListForm>.ShowListForm(KartTuru.Promosyon);
            //else if (e.Item == btnServisYeriKartlari)
            //    ShowListForms<ServisListForm>.ShowListForm(KartTuru.Servis);
            //else if (e.Item == btnSinifKartlari)
            //    ShowListForms<SinifListForm>.ShowListForm(KartTuru.Sinif);
            //else if (e.Item == btnHizmetTuruKartlari)
            //    ShowListForms<HizmetTuruListForm>.ShowListForm(KartTuru.HizmetTuru);
            //else if (e.Item == btnHizmetKartlari)
            //    ShowListForms<HizmetListForm>.ShowListForm(KartTuru.Hizmet);
            //else if (e.Item == btnKasaKartlari)
            //    ShowListForms<KasaListForm>.ShowListForm(KartTuru.Kasa);
            //else if (e.Item == btnBankaKartlari)
            //    ShowListForms<BankaListForm>.ShowListForm(KartTuru.Banka);
            //else if (e.Item == btnAvukatKartlari)
            //    ShowListForms<AvukatListForm>.ShowListForm(KartTuru.Avukat);
            //else if (e.Item == btnCariKartlar)
            //    ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari);
            //else if (e.Item == btnOdemeTuruKartlari)
            //    ShowListForms<OdemeTuruListForm>.ShowListForm(KartTuru.OdemeTuru);
            //else if (e.Item == btnBankaHesapKartlari)
            //    ShowListForms<BankaHesapListForm>.ShowListForm(KartTuru.BankaHesap);
            //else if (e.Item == btnIletisimKartlari)
            //    ShowListForms<IletisimListForm>.ShowListForm(KartTuru.Iletisim);
            //else if (e.Item == btnOgrenciKartlari)
            //    ShowListForms<OgrenciListForm>.ShowListForm(KartTuru.Ogrenci);
            //else if (e.Item == btnIndirimKartlari)
            //    ShowListForms<IndirimListForm>.ShowListForm(KartTuru.Indirim);
            //else if (e.Item == btnTahakkukKartlari)
            //    ShowListForms<TahakkukListForm>.ShowListForm(KartTuru.Tahakkuk);
            //else if (e.Item == btnMakbuzKartlari)
            //    ShowListForms<MakbuzListForm>.ShowListForm(KartTuru.Makbuz);
            //else if (e.Item == btnFaturaKartlari)
            //    ShowListForms<FaturaPlaniListForm>.ShowListForm(KartTuru.Fatura);
            //else if (e.Item == btnFaturaTahakkukKarti)
            //    ShowEditForms<FaturaTahakkukEditForm>.ShowDialogEditForm(KartTuru.Fatura);
            //else if (e.Item == btnGenelAmacliRapor)
            //    ShowEditReports<GenelAmacliRapor>.ShowEditReport(KartTuru.GenelAmacliRapor);
            //else if (e.Item == btnSinifRaporlari)
            //    ShowEditReports<SinifRaporlari>.ShowEditReport(KartTuru.SinifRaporlari);
            //else if (e.Item == btnHizmetAlimRaporu)
            //    ShowEditReports<HizmetAlimRaporu>.ShowEditReport(KartTuru.HizmetAlimRaporu);
            //else if (e.Item == btnNetUcretRaporu)
            //    ShowEditReports<NetUcretRaporu>.ShowEditReport(KartTuru.NetUcretRaporu);
            //else if (e.Item == btnUcretVeOdemeRaporu)
            //    ShowEditReports<UcretVeOdemeRaporu>.ShowEditReport(KartTuru.UcretVeOdemeRaporu);
            //else if (e.Item == btnIndirimDagilimRaporu)
            //    ShowEditReports<IndirimDagilimRaporu>.ShowEditReport(KartTuru.IndirimDagilimRaporu);
            //else if (e.Item == btnMesleklereGoreKayitRaporu)
            //    ShowEditReports<MesleklereGoreKayitRaporu>.ShowEditReport(KartTuru.MesleklereGoreKayitRaporu);
            //else if (e.Item == btnAylikKayitRaporu)
            //    ShowEditReports<AylikKayitRaporu>.ShowEditReport(KartTuru.AylikKayitRaporu);
            //else if (e.Item == btnGelirDagilimRaporu)
            //    ShowEditReports<GelirDagilimRaporu>.ShowEditReport(KartTuru.GelirDagilimRaporu);
            //else if (e.Item == btnUcretOrtalamalariRaporu)
            //    ShowEditReports<UcretOrtalamalariRaporu>.ShowEditReport(KartTuru.UcretOrtalamalariRaporu);
            //else if (e.Item == btnOdemeBelgeleriRaporu)
            //    ShowEditReports<OdemeBelgeleriRaporu>.ShowEditReport(KartTuru.OdemeBelgeleriRaporu);
            //else if (e.Item == btnTahsilatRaporu)
            //    ShowEditReports<TahsilatRaporu>.ShowEditReport(KartTuru.TahsilatRaporu);
            //else if (e.Item == btnGecikenAlacaklarRaporu)
            //    ShowEditReports<OdemesiGecikenAlacaklarRaporu>.ShowEditReport(KartTuru.OdemesiGecikenAlacaklarRaporu);
            //else if (e.Item == btnKullaniciParametreleri)
            //{
            //    var entity = ShowEditForms<KullaniciParametreEditForm>.ShowDialogEditForm<KullaniciParametreS>(KullaniciId);
            //    if (entity == null) return;
            //    KullaniciParametreleri = entity;
            //    imgArkaPlanResim.EditValue = entity.ArkaPlanResim;
            //}
            //else if (e.Item == btnHesapMakinesi)
            //    try
            //    {
            //        Process.Start("calc.exe");
            //    }
            //    catch
            //    {
            //        Messages.HataMesaji("Hesap Makinesi Bulunamadı.");
            //    }
            //else if (e.Item == btnSube)
            //{
            //    for (int i = 0; i < Application.OpenForms.Count; i++)
            //    {
            //        if (Application.OpenForms[i] is GirisForm || Application.OpenForms[i] is AnaForm) continue;
            //        Application.OpenForms[i].Close();
            //        i--;
            //    }
            //    SubeDonemSecimi(true);
            //}
            //else if (e.Item == btnSifreDegistir)
            //    ShowEditForms<SifreDegistirEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate);

            //Cursor.Current = Cursors.Default;
        }
    }
}