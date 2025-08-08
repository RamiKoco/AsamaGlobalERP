﻿using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System.Diagnostics;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.KisiEditFormTable
{
    public partial class IletisimBilgileriTable : BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();

            Bll = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            HideItems = new BarItem[] { btnBelgeHareketleri };
            solPane.SelectedPageChanged += NavigationPane_SelectedPageChanged;           
            insUptNavigator.Visible = false;
            smallNavigatorTelefon.Navigator.NavigatableControl = Tablo.GridControl;
            smallNavigatorEPosta.Navigator.NavigatableControl = Tablo.GridControl;
            smallNavigatorWeb.Navigator.NavigatableControl = Tablo.GridControl;
            smallNavigatorSosyalMedya.Navigator.NavigatableControl = Tablo.GridControl;           
        }
        private void NavigationPane_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            var selectedPage = e.Page as NavigationPage;
            Debug.WriteLine($"[DEBUG] Seçilen sayfa: {selectedPage?.Name}");
            DegiskenleriDoldur();          

            switch (selectedPage?.Name)
            {
                case "pageTelefon":
                    smallNavigatorTelefon.Navigator.NavigatableControl = Tablo.GridControl;
                    break;

                case "pageWeb":
                    smallNavigatorWeb.Navigator.NavigatableControl = Tablo.GridControl;
                    break;

                case "pageEPosta":
                    smallNavigatorEPosta.Navigator.NavigatableControl = Tablo.GridControl;
                    break;

                case "pageSosyalMedya":
                    smallNavigatorSosyalMedya.Navigator.NavigatableControl = Tablo.GridControl;
                    break;
            }

            Listele();
        }
    
        protected internal override void Listele()
        {
           
            var list = ((IletisimBilgileriBll)Bll)
                .List(x => x.KisiId == OwnerForm.Id)
                .ToBindingList<IletisimBilgileriL>();

            if (Tablo?.GridControl != null)
                Tablo.GridControl.DataSource = list;

        }
      
        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IletisimBilgileriL>(i);               

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }     

        protected override void DegiskenleriDoldur()
        {

            switch (solPane.SelectedPage.Name)
            {

                case "pageTelefon":
                    Tablo = tablo;                   
                    break;

                case "pageWeb":
                    Tablo = webTablo;
                    break;

                case "pageEPosta":
                    Tablo = epostaTablo;
                    break;

                case "pageSosyalMedya":
                    Tablo = sosyalMedyaTablo;
                    break;

            }
        }

        protected virtual void TabloEventsYukle()
        {
            if (Tablo == null) return;

            Tablo.DoubleClick -= Tablo_DoubleClick;
            Tablo.KeyDown -= Tablo_KeyDown;
            Tablo.MouseUp -= Tablo_MouseUp;

            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;
        }
        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null || e.Button != MouseButtons.Right)
                return;

            if (solPane?.SelectedPage?.Name == "pageTelefon")
                return;

            popupMenu.ShowPopup(Cursor.Position);
        }
    }
}
