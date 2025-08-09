﻿using AbcYazilim.OgrenciTakip.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.Base;
using AsamaGlobal.ERP.Model.Entities.PersonelEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsamaGlobal.ERP.Model.Dto.PersonelDto
{
    [NotMapped]
    public class PersonelAdresS : PersonelAdres
    {
        public string AdresTurleriAdi { get; set; }
        public string UlkeAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class PersonelAdresL : BaseEntity
    {
        public string UlkeAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string AdresTurleriAdi { get; set; }
        public string Aciklama { get; set; }
        public string Baslik { get; set; }
        public string AdresNotu { get; set; }
        public string PostaKodu { get; set; }
        public string Adres { get; set; }
        public AdresTipi AdresTipi { get; set; }
        public decimal Enlem { get; set; }
        public decimal Boylam { get; set; }
        public bool VarsayilanMi { get; set; }
        public bool VarsayilanFaturaMi { get; set; }
        public bool VarsayilanSevkiyatMi { get; set; }
    }
}
