using AbcYazilim.OgrenciTakip.Bll.General;
using AbcYazilim.OgrenciTakip.Common.Enums;
using AbcYazilim.OgrenciTakip.Common.Message;
using AbcYazilim.OgrenciTakip.Model.Dto;
using AbcYazilim.OgrenciTakip.UI.Win.Forms.PersonelForms;
using AbcYazilim.OgrenciTakip.UI.Win.Functions;
using AbcYazilim.OgrenciTakip.UI.Win.Show;
using AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.Base;
using DevExpress.XtraBars;

namespace AbcYazilim.OgrenciTakip.UI.Win.UserControls.UserControl.PersonelEditFormTable
{
    public partial class AdreslerTable : BaseTablo
    {
        public AdreslerTable()
        {
            InitializeComponent();
            Bll = new AdresHareketleriBll();
            Tablo = tablo;
            EventsLoad();
            TabloEventsYukle();
            HideItems = new BarItem[] { btnBelgeHareketleri };
            insUptNavigator.Navigator.Buttons.Append.Visible = false;
            insUptNavigator.Navigator.Buttons.Remove.Visible = false;
            insUptNavigator.Navigator.Buttons.Edit.Visible = false;
        }

        protected internal override void Listele()
        {

            var list = ((AdresHareketleriBll)Bll)
                .List(x => x.PersonelId == OwnerForm.Id)
                .ToBindingList<AdresHareketleriL>();

            if (Tablo?.GridControl != null)
                Tablo.GridControl.DataSource = list;
        }
        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<AdresHareketleriL>(i);

                if (!tablo.HasColumnErrors) continue;
                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }
        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<AdresHareketleriL>();
            if (entity == null) return;
            ShowEditForms<PersonelEditForm>.ShowDialogEditForm(KartTuru.Personel, entity.AdresBilgileriId);

        }
        protected virtual void TabloEventsYukle()
        {
            if (Tablo == null) return;

            Tablo.DoubleClick -= Tablo_DoubleClick;
            Tablo.KeyDown -= Tablo_KeyDown;
            Tablo.MouseUp -= Tablo_MouseUp;

            Tablo.KeyDown += Tablo_KeyDown;
        }
    }
}
