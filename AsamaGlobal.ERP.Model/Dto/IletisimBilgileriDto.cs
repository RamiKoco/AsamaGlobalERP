<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;

namespace AsamaGlobal.ERP.Model.Dto
{
    [NotMapped]
    public class IletisimBilgileriL : IletisimBilgileri, IBaseHareketEntity
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string EvTel { get; set; }
        public string IsTel1 { get; set; } 
        public string IsTel2 { get; set; }
        public string CepTel1 { get; set; }
        public string CepTel2 { get; set; }
        public string EvAdres { get; set; }
        public string EvAdresIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }
        public string IsAdres { get; set; }
        public string IsAdresIlAdi { get; set; }
        public string IsAdresIlceAdi { get; set; }
        public string YakinlikAdi { get; set; }
=======
﻿using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Model.Entities.Base.Interfaces;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbcYazilim.OgrenciTakip.Model.Dto.IletisimlerDto
{
    [NotMapped]
    public class IletisimBilgiL : IletisimBilgi, IBaseHareketEntity
    {
        public string Baslik { get; set; }
        public string UlkeKodu { get; set; }
        public string Numara { get; set; }
        public string DahiliNo { get; set; }
        public string EPosta { get; set; }
        public IletisimTuru IletisimTuruAdi { get; set; }
        public IletisimDurumu IzinDurumu { get; set; }
        public DateTime? IzinTarihi { get; set; }
        public string SosyalMedyaPlatformuAdi { get; set; }
        public string Kanallar { get; set; }
        public string KullaniciAdi { get; set; }
        public string SosyalMedyaUrl { get; set; }
        public string SIPKullaniciAdi { get; set; }
        public string SIPServer { get; set; }
        public string Ilgili { get; set; }
        public short Oncelik { get; set; }
        public bool VoipMi { get; set; }
        public bool VarsayilanMi { get; set; }
        public bool AramaAktifMi { get; set; }
        public bool SmsAktifMi { get; set; }
        public bool WhatsAppAktifMi { get; set; }
        public bool EmailAktifMi { get; set; }
        public string Web { get; set; }
        public string Aciklama { get; set; }
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
<<<<<<< HEAD

    [HighlightedClass]
    public class IletisimBilgileriR
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string AdiSoyadi { get; set; }
        public string EvTel { get; set; }
        public string IsTel1 { get; set; }
        public string IsTel2 { get; set; }
        public string CepTel1 { get; set; }
        public string CepTel2 { get; set; }
        public string EvAdres { get; set; }
        public string EvAdresIlAdi { get; set; }
        public string EvAdresIlceAdi { get; set; }
        public string EvAdresTam { get; set; }
        public string IsAdres { get; set; }
        public string IsAdresIlAdi { get; set; }
        public string IsAdresIlceAdi { get; set; }
        public string IsAdresTam { get; set; }
        public string YakinlikAdi { get; set; }
=======
    [HighlightedClass]
    public class IletisimBilgiR
    {
        public string Baslik { get; set; }
        public string UlkeKodu { get; set; }
        public string Numara { get; set; }
        public string DahiliNo { get; set; }
        public string EPosta { get; set; }
        public IletisimTuru IletisimTuru { get; set; }
        public IletisimDurumu IzinDurumu { get; set; }
        public DateTime? IzinTarihi { get; set; }
        public string SosyalMedyaPlatformuAdi { get; set; }
        public string Kanallar { get; set; }
        public string KullaniciAdi { get; set; }
        public string SosyalMedyaUrl { get; set; }
        public string SIPKullaniciAdi { get; set; }
        public string SIPServer { get; set; }
        public string Ilgili { get; set; }
        public short Oncelik { get; set; }
        public bool VoipMi { get; set; }
        public bool VarsayilanMi { get; set; }
        public bool AramaAktifMi { get; set; }
        public bool SmsAktifMi { get; set; }
        public bool WhatsAppAktifMi { get; set; }
        public bool EmailAktifMi { get; set; }
        public string Web { get; set; }
        public string Aciklama { get; set; }
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        public string MeslekAdi { get; set; }
        public string IsyeriAdi { get; set; }
        public string GorevAdi { get; set; }

    }
<<<<<<< HEAD

=======
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
}
