﻿using AbcYazilim.OgrenciTakip.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.Base;
using AsamaGlobal.ERP.Model.Entities.CariEntity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsamaGlobal.ERP.Model.Dto.CariDto
{
    [NotMapped]
    public class CariIletisimS : CariIletisim
    {
        public string SosyalMedyaPlatformuAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
    public class CariIletisimL : BaseEntity
    {
        public IletisimTuru IletisimTuru { get; set; }
        public IletisimDurumu IzinDurumu { get; set; }
        public IletisimKanalTipi IletisimKanalTipi { get; set; }
        public string Baslik { get; set; }
        public string Kanallar { get; set; }
        public bool Arama { get; set; }
        public bool Sms { get; set; }
        public bool Whatsapp { get; set; }
        public bool EPBool { get; set; }
        public string UlkeKodu { get; set; }
        public string Numara { get; set; }
        public string DahiliNo { get; set; }
        public string EPosta { get; set; }
        public DateTime? IzinTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string SosyalMedyaUrl { get; set; }
        public string SIPKullaniciAdi { get; set; }
        public string SIPServer { get; set; }
        public string Ilgili { get; set; }
        public short Oncelik { get; set; }
        public bool VoipMi { get; set; }
        public string Web { get; set; }
        public string SosyalMedyaPlatformuAdi { get; set; }
        public string Aciklama { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }
}
