using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Model.Entities.Base;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.Controls;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.PersonelEditFormTable
{
    public partial class KisiselBilgilerTable : BaseTablo
    {
        private MyDataLayoutControl DataLayoutControl { get; }
        public BaseEntity OldEntity { get; private set; }
        public IslemTuru BaseIslemTuru { get; private set; }

        private KartTuru BaseKartTuru;
        public KisiselBilgilerTable()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new PersonelBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Personel;
            EventsLoad();
        }
 

    }
}
