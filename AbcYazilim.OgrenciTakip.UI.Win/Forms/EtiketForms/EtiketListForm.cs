using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.GenelForms;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.EtiketForms
{
    public partial class EtiketListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Etiket, bool>> _filter;

        #endregion
        public EtiketListForm()
        {
            InitializeComponent();
            Bll = new EtiketBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public EtiketListForm(params object[] prm) : this()
        {
            if (prm != null)
            {
                var panelGoster = (bool)prm[0];
            }

            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) &&  x.Durum == AktifKartlariGoster;
        }


        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Etiket;
            FormShow = new ShowEditForms<EtiketEditForm>();
            Navigator = longNavigator.Navigator;            
        }
        protected override void Listele()
        {
            //Tablo.GridControl.DataSource = ((EtiketBll)Bll).List(FilterFunctions.Filter<Etiket>(AktifKartlariGoster));

            var list = ((EtiketBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

        protected override void SelectEntity()
        {
            base.SelectEntity();
        }
    }
}