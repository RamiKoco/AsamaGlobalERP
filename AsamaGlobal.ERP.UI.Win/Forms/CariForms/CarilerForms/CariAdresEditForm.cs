using AbcYazilim.OgrenciTakip.Common.Enums;
using AsamaGlobal.ERP.Bll.General.CarilerBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Common.Functions;
using AsamaGlobal.ERP.Model.Dto.CariDto;
using AsamaGlobal.ERP.Model.Entities.CariEntity;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using DevExpress.XtraEditors;
using System;
using AsamaGlobal.ERP.UI.Win.Forms.CariForms;
using AsamaGlobal;
using AsamaGlobal.ERP;
using AsamaGlobal.ERP.UI;
using AsamaGlobal.ERP.UI.Win;
using AsamaGlobal.ERP.UI.Win.Forms;

namespace AsamaGlobal.ERP.UI.Win.Forms.CariForms.CarilerForms
{
    public partial class CariAdresEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _cariId;
        private readonly string _cariAdi;
        #endregion
        public CariAdresEditForm(params object[] prm)
        {
            InitializeComponent();
            _cariId = (long)prm[0];
            _cariAdi = prm[1].ToString();

            DataLayoutControl = myDataLayoutControl;
            Bll = new CariAdresBll(myDataLayoutControl);
            txtAdresTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AdresTipi>());
            BaseKartTuru = KartTuru.CariAdres;

            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariAdresS() : ((CariAdresBll)Bll).Single(FilterFunctions.Filter<CariAdres>(Id));
            NesneyiKontrollereBagla();
            Text = Text + $" - ( {_cariAdi} )";
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariAdresBll)Bll).YeniKodVer(x => x.CarilerId == _cariId);
            txtBaslik.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariAdresS)OldEntity;
            txtKod.Text = entity.Kod;
            txtBaslik.Text = entity.Baslik;
            txtAdresNotu.Text = entity.AdresNotu;
            txtAdresTipi.SelectedItem = entity.AdresTipi.ToName();
            txtUlke.Id = entity.UlkeId;
            txtUlke.Text = entity.UlkeAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAdresTurleri.Id = entity.AdresTurleriId;
            txtAdresTurleri.Text = entity.AdresTurleriAdi;
            txtPostaKodu.Text = entity.PostaKodu;
            txtAdres.Text = entity.Adres;
            txtEnlem.EditValue = entity.Enlem ?? 0m;
            txtBoylam.EditValue = entity.Boylam ?? 0m;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            decimal.TryParse(txtEnlem.EditValue?.ToString(), out var enlem);
            decimal.TryParse(txtBoylam.EditValue?.ToString(), out var boylam);

            CurrentEntity = new CariAdres
            {
                Id = Id,
                Kod = txtKod.Text,
                Baslik = txtBaslik.Text,
                AdresNotu = txtAdresNotu.Text,
                AdresTipi = txtAdresTipi.Text.GetEnum<AdresTipi>(),
                UlkeId = txtUlke.Id,
                IlId = txtIl.Id,
                IlceId = txtIlce.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                AdresTurleriId = txtAdresTurleri.Id,
                PostaKodu = txtPostaKodu.Text,
                Adres = txtAdres.Text,
                CarilerId = BaseIslemTuru == IslemTuru.EntityInsert ? _cariId : ((CariAdresS)OldEntity).CarilerId,
                Enlem = enlem,
                Boylam = boylam,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };
            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((CariAdresBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _cariId);
        }

        protected override bool EntityUpdate()
        {
            return ((CariAdresBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _cariId);
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtUlke)
                    sec.Sec(txtUlke);
                else if (sender == txtIl)
                    sec.Sec(txtIl);
                else if (sender == txtIlce)
                    sec.Sec(txtIlce, txtIl);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.CariAdres);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.CariAdres);
                else if (sender == txtAdresTurleri)
                    sec.Sec(txtAdresTurleri, KartTuru.AdresTurleri);

        }
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtIl) return;
            txtIl.ControlEnabledChange(txtIlce);
        }
    }
}