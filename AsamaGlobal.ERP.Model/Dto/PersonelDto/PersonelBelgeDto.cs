﻿using AsamaGlobal.ERP.Model.Entities.Base.Interfaces;
using AsamaGlobal.ERP.Model.Entities.PersonelEntity;
using DevExpress.DataAccess.ObjectBinding;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsamaGlobal.ERP.Model.Dto.PersonelDto
{
    [NotMapped]
    public class PersonelBelgeL : PersonelBelge, IBaseHareketEntity
    {
        public string KurumAdi { get; set; }
        public string BelgeAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class PersonelBelgeR
    {
        public string BelgeNo { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime GecerlilikTarihi { get; set; }
        public string KurumAdi { get; set; }
        public string BelgeAdi { get; set; }
        public string Aciklama { get; set; }

    }
}
