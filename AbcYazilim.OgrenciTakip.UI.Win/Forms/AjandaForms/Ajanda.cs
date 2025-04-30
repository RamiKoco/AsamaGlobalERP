using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcYazilim.OgrenciTakip.UI.Win.Forms.AjandaForms
{
    public partial class Ajanda : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Ajanda()
        {
            InitializeComponent();
        }

        private void Ajanda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yeni_KurumDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.yeni_KurumDataSet.Resources);
            // TODO: This line of code loads data into the 'yeni_KurumDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.yeni_KurumDataSet.Appointments);

        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(yeni_KurumDataSet);
            yeni_KurumDataSet.AcceptChanges();
        }
    }
}