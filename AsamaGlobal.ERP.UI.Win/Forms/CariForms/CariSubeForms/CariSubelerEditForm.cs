using AsamaGlobal.ERP.Bll.General.CarilerBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto.CariDto.CariSubeDto;
using AsamaGlobal.ERP.Model.Entities.Base.Interfaces;
using AsamaGlobal.ERP.Model.Entities.CariEntity.CariSube;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.UserControls.UserControl.Base;
using AsamaGlobal.ERP.UI.Win.UserControls.UserControl.CariSubelerEditFormTable;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System.Linq;

namespace AsamaGlobal.ERP.UI.Win.Forms.CariForms.CariSubeForms
{
    public partial class CariSubelerEditForm : BaseEditForm
    {
        #region Variables
        private readonly long _carilerId;
        private readonly string _carilerAdi;
        private BaseTablo _bilgiNotlariTable;
        #endregion
        public CariSubelerEditForm(params object[] prm)
        {
            InitializeComponent();
            _carilerId = (long)prm[0];
            _carilerAdi = prm[1].ToString();

            DataLayoutControls = new[] { DataLayoutGenel, DataLayoutGenelBilgiler };
            Bll = new CariSubelerBll(DataLayoutGenelBilgiler);
            BaseKartTuru = KartTuru.CariSubeler;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariSubelerS() : ((CariSubelerBll)Bll).Single(FilterFunctions.Filter<CariSubeler>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();
            Text = Text + $" - ( {_carilerAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariSubelerBll)Bll).YeniKodVer(x => x.CarilerId == _carilerId);
            txtCariSubeAdi.Focus();
        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>()
                    .Any(x => x.Insert || x.Update || x.Delete);
            }

            if (_bilgiNotlariTable != null && TableValueChanged(_bilgiNotlariTable))
                _bilgiNotlariTable.Yukle();

        }
   
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariSubelerS)OldEntity;
            txtKod.Text = entity.Kod;
            txtCariSubeAdi.Text = entity.CariSubeAdi;
            txtIlgili.Text = entity.Ilgili;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new CariSubeler
            {
                Id = Id,
                Kod = txtKod.Text,
                CariSubeAdi = txtCariSubeAdi.Text,
                Ilgili = txtIlgili.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                CarilerId = BaseIslemTuru == IslemTuru.EntityInsert ? _carilerId : ((CariSubelerS)OldEntity).CarilerId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
        //protected override bool EntityInsert()
        //{
        //    return ((CariSubelerBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _carilerId);
        //}

        //protected override bool EntityUpdate()
        //{
        //    return ((CariSubelerBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _carilerId);
        //}
        protected override bool EntityInsert()
        {

            if (BagliTabloHataliGirisKontrol()) return false;
            var result = ((CariSubelerBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _carilerId) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;
            var result = ((CariSubelerBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.CarilerId == _carilerId) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.CariSubeler);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.CariSubeler);
        }
        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (_bilgiNotlariTable != null && _bilgiNotlariTable.HataliGiris())
            {
                tabUst.SelectedPage = pageNotlar;
                _bilgiNotlariTable.Tablo.GridControl.Focus();
                return true;
            }

            return false;
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_bilgiNotlariTable != null && _bilgiNotlariTable.TableValueChanged) return true;

                return false;
            }

            if (FarkliSubeIslemi)
                Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil);
            else
                Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity,
                     TableValueChanged());

        }
        protected override bool BagliTabloKaydet()
        {
            if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;

            return true;
        }
        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
            {
                txtCariSubeAdi.Focus();
            }

            else if (e.Page == pageNotlar)
            {
                if (pageNotlar.Controls.Count == 0)
                {
                    _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
                    pageNotlar.Controls.Add(_bilgiNotlariTable);
                    _bilgiNotlariTable.Yukle();

                }

                _bilgiNotlariTable.Tablo.GridControl.Focus();
            }
        }
    }
}