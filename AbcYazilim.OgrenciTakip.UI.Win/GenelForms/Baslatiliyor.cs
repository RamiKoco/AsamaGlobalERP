using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;

namespace AbcYazilim.OgrenciTakip.UI.Win.GenelForms
{
    public partial class Baslatiliyor : SplashScreen
    {
        public Baslatiliyor()
        {
            InitializeComponent();
            lblVersiyon.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}