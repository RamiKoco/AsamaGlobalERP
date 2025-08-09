﻿using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.GenelForms;

namespace AsamaGlobal.ERP.UI.Win.Forms.EvrakForms
{
    public partial class EvrakEditForm : BaseEditForm
    {
        public EvrakEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new EvrakBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Evrak;
            EventsLoad();

        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Evrak() : ((EvrakBll)Bll).Single(FilterFunctions.Filter<Evrak>(Id));
            NesneyiKontrollereBagla();
           

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((EvrakBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtEvrakAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Evrak)OldEntity;

            txtKod.Text = entity.Kod;
            txtEvrakAdi.Text = entity.EvrakAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Evrak
            {
                Id = Id,
                Kod = txtKod.Text,
                EvrakAdi = txtEvrakAdi.Text,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((EvrakBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((EvrakBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

    }
}