using AbcYazilim.OgrenciTakip.Bll.Base;
using AbcYazilim.OgrenciTakip.Bll.Interfaces;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.Bll.General
{
    public class PozisyonBll : BaseGenelBll<Pozisyon>, IBaseGenelBll, IBaseCommonBll
    {
        public PozisyonBll() : base(KartTuru.Pozisyon) { }
        public PozisyonBll(Control ctrl) : base(ctrl, KartTuru.Pozisyon) { }

        public override BaseEntity Single(Expression<Func<Pozisyon, bool>> filter)
        {
            return BaseSingle(filter, x => new PozisyonS
            {

                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                RenkId = x.RenkId,
                RenkAdi = x.Renk.RenkAdi,
                DepartmanId = x.DepartmanId,
                DepartmanAdi = x.Departman.Ad,               
                Aciklama = x.Aciklama,
                Durum = x.Durum

            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Pozisyon, bool>> filter)
        {
            return BaseList(filter, x => new PozisyonL
            {
                Id = x.Id,
                Kod = x.Kod,
                Ad = x.Ad,
                RenkAdi = x.Renk.RenkAdi,
                DepartmanAdi = x.Departman.Ad,
                Aciklama = x.Aciklama

            }).OrderBy(x => x.Kod).ToList();
        }
    }
}
