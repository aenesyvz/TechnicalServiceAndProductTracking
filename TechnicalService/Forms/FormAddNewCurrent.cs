using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalService.Forms
{
    public partial class FormAddNewCurrent : Form
    {
        public FormAddNewCurrent()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCurrentInformations currentInformation = new TBLCurrentInformations();
            currentInformation.FirstName = txtCariAd.Text;
            currentInformation.LastName = TxtCariSoyad.Text;
            currentInformation.City = txtİl.Text;
            currentInformation.District = txtİlce.Text;
            dboTechnicalServiceAndProductTracking.TBLCurrentInformations.Add(currentInformation);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Yeni cari başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
