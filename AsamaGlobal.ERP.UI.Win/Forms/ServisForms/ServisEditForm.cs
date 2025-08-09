﻿using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.GenelForms;

namespace AsamaGlobal.ERP.UI.Win.Forms.ServisForms
{
    public partial class ServisEditForm : BaseEditForm
    {
        public ServisEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ServisBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Servis;
            EventsLoad();
        }
        
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Servis() : ((ServisBll)Bll).Single(FilterFunctions.Filter<Servis>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ServisBll) Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
            txtServisYeri.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Servis)OldEntity;

            txtKod.Text = entity.Kod;
            txtServisYeri.Text = entity.ServisYeri;
            txtUcret.Value = entity.Ucret;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Servis
            {
                Id = Id,
                Kod = txtKod.Text,
                ServisYeri = txtServisYeri.Text,
                Ucret = txtUcret.Value,
                Aciklama = txtAciklama.Text,
                SubeId = AnaForm.SubeId,
                DonemId = AnaForm.DonemId,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((ServisBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }

        protected override bool EntityUpdate()
        {
            return ((ServisBll) Bll).Update(OldEntity, CurrentEntity,
                x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);

        }
    }
}