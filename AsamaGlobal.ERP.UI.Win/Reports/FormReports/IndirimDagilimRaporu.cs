﻿using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.UI.Win.Forms.TahakkukForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Reports.FormReports.Base;
using AsamaGlobal.ERP.UI.Win.Show;
using System.Linq;
using AsamaGlobal.ERP.UI.Win.GenelForms;
using AsamaGlobal;
using AsamaGlobal.ERP;
using AsamaGlobal.ERP.UI;
using AsamaGlobal.ERP.UI.Win;

namespace AsamaGlobal.ERP.UI.Win.Reports.FormReports
{
    public partial class IndirimDagilimRaporu : BaseRapor
    {
        public IndirimDagilimRaporu()
        {
            InitializeComponent();
        }

        protected override void DegiskenleriDoldur()
        {


            DataLayoutControl = myDataLayoutControl;
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            Subeler = txtSubeler;
            Indirimler = txtIndirimler;
            KayitSekilleri = txtKayitSekli;
            KayitDurumlari = txtKayitDurumu;
            IptalDurumlari = txtIptalDurumu;

            SubeKartlariYukle();
            KayitSekliYukle();
            KayitDurumuYukle();
            IptalDurumuYukle();
            IndirimKartlariYukle();
            RaporTuru = KartTuru.IndirimDagilimRaporu;
        }
        protected override void Listele()
        {
            var subeler = txtSubeler.CheckedComboBoxList<long>();
            var indirimler = txtIndirimler.CheckedComboBoxList<long>();
            var kayitSekli = txtKayitSekli.CheckedComboBoxList<KayitSekli>();
            var kayitDurumu = txtKayitDurumu.CheckedComboBoxList<KayitDurumu>();
            var iptalDurumu = txtIptalDurumu.CheckedComboBoxList<IptalDurumu>();


            using (var bll = new IndirimDagilimRaporuBll())
            {
                tablo.GridControl.DataSource = bll.List(x =>
                    subeler.Contains(x.SubeId) &&
                    kayitSekli.Contains(x.KayitSekli) &&
                    kayitDurumu.Contains(x.KayitDurumu) &&
                    iptalDurumu.Contains(x.Durum ? IptalDurumu.DevamEdiyor : IptalDurumu.IptalEdildi) &&
                    x.DonemId == AnaForm.DonemId,indirimler);

                base.Listele();

            }

        }

        protected override void ShowEditForm()
        {
            var entity = tablo.GetRow<IndirimDagilimRaporuL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.TahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }


        
    }
}