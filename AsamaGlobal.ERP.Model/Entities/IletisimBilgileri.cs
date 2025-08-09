<<<<<<< HEAD
﻿using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AsamaGlobal.ERP.Model.Entities
{
    public class IletisimBilgileri : BaseHareketEntity
    {
        public long TahakkukId { get; set; }
        public long IletisimId { get; set; }
        public long YakinlikId { get; set; }
        public bool Veli { get; set; }
        public AdresTuru? FaturaAdresi { get; set; }

        public Iletisim Iletisim { get; set; }
        public Yakinlik Yakinlik { get; set; }
=======
﻿using AbcYazilim.OgrenciTakip.Common.Enums;
using AsamaGlobal.ERP.Model.Entities.Base;

namespace AbcYazilim.OgrenciTakip.Model.Entities
{
    public class IletisimBilgi : BaseHareketEntity
    {
        public long? KisiId { get; set; }
        public long? PersonelId { get; set; }
        public long IletisimlerId { get; set; }
        public bool Veli { get; set; }
        public IletisimTuru? IletisimTuru { get; set; }
        public Iletisimler Iletisimler { get; set; }
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
    }
}
