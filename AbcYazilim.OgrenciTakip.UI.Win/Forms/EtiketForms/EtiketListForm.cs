using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using System.Drawing;
using System.Security.Principal;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.EtiketForms
{
    public partial class EtiketListForm : BaseListForm
    {
        public EtiketListForm()
        {
            InitializeComponent();
            Bll = new EtiketBll();
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
            Tablo.GridControl.DataSource = ((EtiketBll)Bll).List(FilterFunctions.Filter<Etiket>(AktifKartlariGoster));

        }
    }
}