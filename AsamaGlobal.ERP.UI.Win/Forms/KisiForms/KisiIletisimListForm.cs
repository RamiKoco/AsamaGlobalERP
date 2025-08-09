using AsamaGlobal.ERP.Bll.General.KisiBll;
using AsamaGlobal.ERP.Common.Enums;
using AsamaGlobal.ERP.UI.Win.Forms.BaseForms;
using AsamaGlobal.ERP.UI.Win.Show;
using System.Drawing;

namespace AsamaGlobal.ERP.UI.Win.Forms.KisiForms
{
    public partial class KisiIletisimListForm : BaseListForm
    {
        #region Variables
        private readonly long _kisiId;
        private readonly string _kisiAdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView view;
        #endregion
        public KisiIletisimListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new KisiIletisimBll();

            _kisiId = (long)prm[0];
            _kisiAdi = prm[1].ToString();

            view = grid.MainView as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView;
            //if (view != null)
            //    //view.RowCellStyle += View_RowCellStyle;
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.KisiIletisim;
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_kisiAdi} )";
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KisiIletisimBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.KisiId == _kisiId);
        }
        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<KisiIletisimEditForm>.ShowDialogEditForm(KartTuru.KisiIletisim, id, _kisiId, _kisiAdi);
            ShowEditFormDefault(result);

        }   
        //private void View_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        //{
        //    if (e.Column.FieldName == "Whatsapp" || e.Column.FieldName == "Arama" || e.Column.FieldName == "Sms"|| e.Column.FieldName == "EPBool")
        //    {
        //        var view = sender as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView;
        //        var value = view.GetRowCellValue(e.RowHandle, e.Column);

        //        if (value is bool boolValue && boolValue)
        //        {
        //            e.Appearance.BackColor = Color.LightYellow;
        //            e.Appearance.ForeColor = Color.DarkBlue;
        //        }
        //        //else
        //        //{
        //        //    e.Appearance.BackColor = Color.White;
        //        //    e.Appearance.ForeColor = Color.Black; // Dilersen başka renk seçebilirsin
        //        //}
        //    }
        //}

    }
}