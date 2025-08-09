using AbcYazilim.OgrenciTakip.Bll.General;
<<<<<<< HEAD
using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;
using AsamaGlobal.ERP.UI.Win.UserControls.Navigators;
using DevExpress.Utils.FormShadow;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsamaGlobal.ERP.UI.Win.Forms.EtiketForms
{
    public partial class EtiketListForm : BaseListForm
    {
=======
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
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        public EtiketListForm()
        {
            InitializeComponent();
            Bll = new EtiketBll();
<<<<<<< HEAD
        }
=======
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


>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Etiket;
            FormShow = new ShowEditForms<EtiketEditForm>();
<<<<<<< HEAD
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((EtiketBll)Bll).List(FilterFunctions.Filter<Etiket>(AktifKartlariGoster));

=======
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
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        }
    }
}