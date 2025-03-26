using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System.Linq.Expressions;
using System.Windows.Forms;
using System;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class KurumBilgileriBll : BaseGenelBll<KurumBilgileri>, IBaseGenelBll, IBaseCommonBll
    {
        public KurumBilgileriBll(Control ctrl) : base(ctrl) { }

        public override BaseEntity Single(Expression<Func<KurumBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new KurumBilgileriS
            {
                Id = x.Id,
                Kod = x.Kod,
                KurumAdi = x.KurumAdi,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi

            });
        }
    }
}
