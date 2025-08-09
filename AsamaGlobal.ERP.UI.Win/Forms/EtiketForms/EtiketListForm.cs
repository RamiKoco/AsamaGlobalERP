using AbcYazilim.OgrenciTakip.Bll.General;
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
        public EtiketListForm()
        {
            InitializeComponent();
            Bll = new Bll.General.EtiketBll();
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
            Tablo.GridControl.DataSource = ((Bll.General.EtiketBll)Bll).List(FilterFunctions.Filter<Etiket>(AktifKartlariGoster));

        }
    }
}