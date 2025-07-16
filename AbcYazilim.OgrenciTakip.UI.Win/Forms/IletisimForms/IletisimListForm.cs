using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.BaseForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using DevExpress.XtraBars.Navigation;
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.IletisimForms
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
            solPane.SelectedPageChanged += NavigationPane_SelectedPageChanged; // Bunu ekle!
        }
        private void NavigationPane_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            var selectedPage = e.Page as NavigationPage;
            Debug.WriteLine($"[DEBUG] Seçilen sayfa: {selectedPage?.Name}");
            DegiskenleriDoldur();
            Listele(); // Güncel tabloya göre veri yüklenir
        }
       

        public IletisimListForm(params object[] prm):this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
            
        }

        protected override void DegiskenleriDoldur()
        {   

            switch (solPane.SelectedPage.Name)
            {
                case "pageTelefon":
                    Tablo = telefonTablo;
                    TabloEventsYukle();
                    break;

                case "pageGenel":
                    Tablo = tablo;
                    break;

                case "pageWeb":
                    Tablo = webTablo;
                    TabloEventsYukle();
                    break;

                case "pageEPosta":
                    Tablo = epostaTablo;
                    TabloEventsYukle();
                    break;

                case "pageSosyalMedya":
                    Tablo = sosyalMedyaTablo;
                    TabloEventsYukle();
                    break;

                //default:
                //    Tablo = tablo; // Ana tablo
                //    break;
            }
            BaseKartTuru = KartTuru.Iletisim;
            FormShow = new ShowEditForms<IletisimEditForm>();
            Navigator = longNavigator.Navigator;

        }
   
        protected virtual void TabloEventsYukle()
        {
            if (Tablo == null) return;

            Tablo.DoubleClick -= Tablo_DoubleClick;
            Tablo.KeyDown -= Tablo_KeyDown;
            Tablo.MouseDown -= Tablo_MouseUp; 

            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseDown += Tablo_MouseUp; 
        }
      
        protected override void Listele()
        {
            var kaynak = ((IletisimBll)Bll).List(FilterFunctions.Filter<Iletisim>(AktifKartlariGoster));
            if (kaynak != null && Tablo?.GridControl != null)
                Tablo.GridControl.DataSource = kaynak;
        }
     

    }
}