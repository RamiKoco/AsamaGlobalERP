﻿using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.OdemeTuruForms
{
    public partial class OdemeTuruListForm : BaseListForm
    {
        public OdemeTuruListForm()
        {
            InitializeComponent();
            Bll = new OdemeTuruBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.OdemeTuru;
            FormShow = new ShowEditForms<OdemeTuruEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((OdemeTuruBll) Bll).List(FilterFunctions.Filter<OdemeTuru>(AktifKartlariGoster));
        }
    }
}