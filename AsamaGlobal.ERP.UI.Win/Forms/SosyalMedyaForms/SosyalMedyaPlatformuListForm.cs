﻿using AbcYazilim.OgrenciTakip.Model.Entities;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Functions;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.SosyalMedyaForms
{
    public partial class SosyalMedyaPlatformuListForm : BaseListForm
    {
        public SosyalMedyaPlatformuListForm()
        {
            InitializeComponent();
            Bll = new Bll.General.SosyalMedyaPlatformuBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SosyalMedyaPlatformu;
            FormShow = new ShowEditForms<SosyalMedyaPlatformuEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((Bll.General.SosyalMedyaPlatformuBll)Bll).List(FilterFunctions.Filter<SosyalMedyaPlatformu>(AktifKartlariGoster));
        }
    }
}