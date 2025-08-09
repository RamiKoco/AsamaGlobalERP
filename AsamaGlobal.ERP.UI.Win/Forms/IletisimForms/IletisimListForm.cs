<<<<<<< HEAD
﻿using System;
using System.Linq;
using System.Linq.Expressions;
using AsamaGlobal.ERP.Bll.General;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.Common.Message;
using AsamaGlobal.ERP.Model.Entities;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Show;

namespace AsamaGlobal.ERP.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseListForm
    {
        #region Variables

        private readonly Expression<Func<Iletisim, bool>> _filter;

        #endregion

        public IletisimListForm()
        {
            InitializeComponent();
            Bll = new IletisimBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public IletisimListForm(params object[] prm):this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
            
        }

=======
﻿using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
{
    public partial class IletisimListForm : BaseListForm
    {      
        public IletisimListForm()
        {
            InitializeComponent();      
            Bll = new IletisimBll();
        }
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Iletisim;
            FormShow = new ShowEditForms<IletisimEditForm>();
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
<<<<<<< HEAD
            var list = ((IletisimBll) Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())
                EklenebilecekEntityVar = true;
            else
                Messages.KartBulunamadiMesaji("Kart");
        }

=======
            Tablo.GridControl.DataSource = ((IletisimBll)Bll).List(FilterFunctions.Filter<Iletisim>(AktifKartlariGoster));
        }
>>>>>>> 92ec3194ed8d28bb6f8a79583dd73b2b425724ec
    }
}