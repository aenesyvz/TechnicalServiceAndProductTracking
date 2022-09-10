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
    public partial class FormNewCurrentList : Form
    {
        public FormNewCurrentList()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            gridControl1.DataSource = (from current in dboTechnicalServiceAndProductTracking.TBLCurrentInformations
                                       select new
                                       {
                                           current.Id,
                                           current.FirstName,
                                           current.LastName,
                                           current.City,
                                           current.District
                                       }).ToList();
        }
        private void FormNewCurrentList_Load(object sender, EventArgs e)
        {
            listele();
            labelControl12.Text = dboTechnicalServiceAndProductTracking.TBLCurrentInformations.Count().ToString();
            lookUpEdit2.Properties.DataSource = (from il in dboTechnicalServiceAndProductTracking.iller
                                                 select new
                                                 {
                                                     il.id,
                                                     il.sehir
                                                 }).ToList();
        }
        int secilen;
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from ilce in dboTechnicalServiceAndProductTracking.ilceler
                                                 select new
                                                 {
                                                     ilce.id,
                                                     ilce.ilce,
                                                     ilce.sehir
                                                 }).Where(x => x.sehir == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAd.Text != "" && txtSoyad.Text != "")
            {
                TBLCurrentInformations currentInformations = new TBLCurrentInformations();
                currentInformations.FirstName = txtAd.Text;
                currentInformations.LastName = txtSoyad.Text;
                currentInformations.City = lookUpEdit2.Text;
                currentInformations.District = lookUpEdit1.Text;
                dboTechnicalServiceAndProductTracking.TBLCurrentInformations.Add(currentInformations);
                dboTechnicalServiceAndProductTracking.SaveChanges();
                MessageBox.Show("Cari sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Hata", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
