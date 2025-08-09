using System.Linq;
using AsamaGlobal.ERP.Bll.Functions;
using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Dto;
using AsamaGlobal.ERP.UI.Win.Forms.HizmetForms;
using AsamaGlobal.ERP.UI.Win.Forms.TahakkukForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.GenelForms;
using AsamaGlobal.ERP.UI.Win.Show;
using AsamaGlobal.ERP.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;

namespace AsamaGlobal.ERP.UI.Win.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class KardesBilgileriTable : BaseTablo
    {
        public KardesBilgileriTable()
        {
            InitializeComponent();

            Bll = new KardesBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] {btnKartDuzenle };
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((KardesBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).ToBindingList<KardesBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KardesBilgileriL>().Where(x => !x.Delete).Select(x => x.KardesTahakkukId).ToList();
            ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);

            var entities = ShowListForms<TahakkukListForm>.ShowDialogListForm(KartTuru.Tahakkuk, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<TahakkukL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KardesBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    KardesTahakkukId = entity.Id,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    SinifAdi = entity.SinifAdi,
                    KayitSekli = entity.KayitSekli,
                    KayitDurumu = entity.KayitDurumu,
                    IptalDurumu = entity.Durum?IptalDurumu.DevamEdiyor:IptalDurumu.IptalEdildi,
                    SubeAdi = entity.SubeAdi,
                    Insert = true
                };


                source.Add(row);

            }

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButonEnabledDurumu(true);

        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<KardesBilgileriL>();
            if (entity == null) return;
            ShowEditForms<TahakkukEditForm>.ShowDialogEditForm(KartTuru.Tahakkuk, entity.KardesTahakkukId, entity.SubeId != AnaForm.SubeId || entity.DonemId != AnaForm.DonemId);

        }
    }
}
