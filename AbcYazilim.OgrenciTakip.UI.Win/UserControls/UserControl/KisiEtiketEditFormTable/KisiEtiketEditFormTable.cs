using AbcYazilim.OgrenciTakip.Bll.Functions;
using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using System.Drawing;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.EtiketForms;

using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.GenelForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using System.Linq;


namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.KisiEtiketEditFormTable
{
    public partial class KisiEtiketEditFormTable : BaseTablo
    {
        public KisiEtiketEditFormTable()
        {
            InitializeComponent();
            Bll = new KisiEtiketBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((KisiEtiketBll)Bll).List(x => x.KisiId == OwnerForm.Id).ToBindingList<KisiEtiketL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KisiEtiketL>().Where(x => !x.Delete).Select(x => x.EtiketId).ToList();

            var entities = ShowListForms<EtiketListForm>
                .ShowDialogListForm(KartTuru.Etiket, ListeDisiTutulacakKayitlar, true, false)
                .EntityListConvert<EtiketL>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KisiEtiketL
                {
                    KisiId = OwnerForm.Id,
                    EtiketId = entity.Id,
                    EtiketAdi = entity.EtiketAdi,                    
                    Insert = true
                };

                source.Add(row);

            }

            tablo.Focus();
            tablo.RefleshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colEtiketAdi;

            ButonEnabledDurumu(true);
        }
    }
}
