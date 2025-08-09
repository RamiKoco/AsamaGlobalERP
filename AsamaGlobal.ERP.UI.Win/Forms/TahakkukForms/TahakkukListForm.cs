using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using DevExpress.XtraBars;
using System;
using System.Linq;
using System.Linq.Expressions;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Common.Message;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.GenelForms;
using AsamaGlobal.ERP.UI.Win.Show;


namespace AsamaGlobal.ERP.UI.Win.Forms.TahakkukForms
{
    public partial class TahakkukListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Tahakkuk, bool>> _filter; 
        
        #endregion
        public TahakkukListForm()
        {
            InitializeComponent();
            Bll = new TahakkukBll();
            HideItems = new BarItem[] {btnYeni};
            _filter = x => x.Durum == AktifKartlariGoster && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId;
        }

        public TahakkukListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId && x.Durum == AktifKartlariGoster;
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Tahakkuk;
            FormShow = new ShowEditForms<TahakkukEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((TahakkukBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");   
        }
    }
}