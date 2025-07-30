using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AbcYazilim.OgrenciTakip.Data.OgrenciTakipMigration;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.KitapTuru;
namespace AbcYazilim.OgrenciTakip.Data.Contexts
{
    public class OgrenciTakipContext : BaseDbContext<OgrenciTakipContext,Configuration>
    {
       
        public OgrenciTakipContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public OgrenciTakipContext(string connectionString) : base (connectionString)
        {
            Configuration.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            //modelBuilder.Entity<Ulke>().HasMany(x => x.Il).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Il>().HasMany(x => x.Ilce).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Kisi>().HasMany(x => x.KisiIletisim).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Cariler>().HasMany(x => x.CariSubeler).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Banka>().HasMany(x => x.BankaSube).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Indirim>().HasMany(x => x.IndiriminUygulanacagiHizmetBilgileri).WithRequired().WillCascadeOnDelete(true);           
        }

        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Mahalle> Mahalle { get; set; }
        public DbSet<Okul> Okul { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<AileBilgi> AileBilgi { get; set; }
        public DbSet<IptalNedeni> IptalNedeni { get; set; }
        public DbSet<YabanciDil> YabanciDil { get; set; }
        public DbSet<Tesvik> Tesvik { get; set; }
        public DbSet<Kontenjan> Kontenjan { get; set; }
        public DbSet<Rehber> Rehber { get; set; }
        public DbSet<SinifGrup> SinifGrup { get; set; }
        public DbSet<Meslek> Meslek { get; set; }
        public DbSet<KayitKaynak> KayitKaynak { get; set; }
        public DbSet<KisiGrubu> KisiGrubu { get; set; }
        public DbSet<Yakinlik> Yakinlik { get; set; }
        public DbSet<Isyeri> Isyeri { get; set; }
        public DbSet<Gorev> Gorev { get; set; }
        public DbSet<IndirimTuru> IndirimTuru { get; set; }
        public DbSet<Evrak> Evrak { get; set; }
        public DbSet<Sube> Sube { get; set; }
        public DbSet<Donem> Donem { get; set; }
        public DbSet<Promosyon> Promosyon { get; set; }
        public DbSet<Servis> Servis { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<HizmetTuru> HizmetTuru { get; set; }
        public DbSet<Hizmet> Hizmet { get; set; }
        public DbSet<OzelKod> OzelKod { get; set; }
        public DbSet<Kasa> Kasa { get; set; }
        public DbSet<Banka> Banka { get; set; }
        public DbSet<BankaSube> BankaSube { get; set; }
        public DbSet<Avukat> Avukat { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<OdemeTuru> OdemeTuru { get; set; }
        public DbSet<BankaHesap> BankaHesap { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Indirim> Indirim { get; set; }
        public DbSet<IndiriminUygulanacagiHizmetBilgileri> IndiriminUygulanacagiHizmetBilgileri { get; set; }
        public DbSet<Tahakkuk> Tahakkuk { get; set; }
        public DbSet<KardesBilgileri> KardesBilgileri { get; set; }
        public DbSet<AileBilgileri> AileBilgileri { get; set; }
        public DbSet<SinavBilgileri> SinavBilgileri { get; set; }
        public DbSet<EvrakBilgileri> EvrakBilgileri { get; set; }
        public DbSet<PromosyonBilgileri> PromosyonBilgileri { get; set; }
        public DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
        public DbSet<EposBilgileri> EposBilgileri { get; set; }
        public DbSet<BilgiNotlari> BilgiNotlari { get; set; }
        public DbSet<HizmetBilgileri> HizmetBilgileri { get; set; }
        public DbSet<IndirimBilgileri> IndirimBilgileri { get; set; }
        public DbSet<OdemeBilgileri> OdemeBilgileri { get; set; }
        public DbSet<GeriOdemeBilgileri> GeriOdemeBilgileri { get; set; }
        public DbSet<Makbuz> Makbuz { get; set; }
        public DbSet<MakbuzHareketleri> MakbuzHareketleri { get; set; }
        public DbSet<Rapor> Rapor { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<GecikmeAciklamalari> GecikmeAciklamalari { get; set; }
        public DbSet<DonemParametre> DonemParametre { get; set; }
        public DbSet<KullaniciParametre> KullaniciParametre { get; set; }
        public DbSet<MailParametre> MailParametre { get; set; }
        public DbSet<KurumBilgileri> KurumBilgileri { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolYetkileri> RolYetkileri { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciBirimYetkileri> KullaniciBirimYetkileri { get; set; }
        public DbSet<RamiDeneme> RamiDeneme { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<Kurgu> Kurgu { get; set; }
        public DbSet<KitapTuru> KitapTuru { get; set; }
        public DbSet<Kisi> Kisi { get; set; }
        public DbSet<KisiEtiket> KisiEtiket { get; set; }
        public DbSet<Etiket> Etiket { get; set; }
        public DbSet<Renk> Renk { get; set; }
        public DbSet<EtiketKayitTuruBaglanti> EtiketKayitTuruBaglanti { get; set; }
        public DbSet<AdresBilgileri> AdresBilgileri { get; set; }
        public DbSet<AdresTurleri> AdresTurleri { get; set; }
        public DbSet<SosyalMedyaPlatformu> SosyalMedyaPlatformu { get; set; }
        public DbSet<AdresHareketleri> AdresHareketleri { get; set; }
        public DbSet<Departman> Departman { get; set; }
        public DbSet<KimlikTuru> KimlikTuru { get; set; }
        public DbSet<Uyruk> Uyruk { get; set; }
        public DbSet<Pozisyon> Pozisyon { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<BelgeTuru> BelgeTuru { get; set; }
        public DbSet<KurumTuru> KurumTuru { get; set; }
        public DbSet<Kurumlar> Kurumlar { get; set; }
        public DbSet<PersonelBelge> PersonelBelge { get; set; }
        public DbSet<Cariler> Cariler { get; set; }
        public DbSet<CariSubeler> CariSubeler { get; set; }
        public DbSet<KisiIletisim> KisiIletisim { get; set; }
    }
}