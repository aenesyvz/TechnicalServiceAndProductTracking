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
    public partial class FormFaultyDetail : Form
    {
        public FormFaultyDetail()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            TBLProductTracking productTracking = new TBLProductTracking();
            productTracking.SerialNo = txtSeriNo.Text;
            productTracking.TrackingDate = DateTime.Parse(txtTarih.Text);
            productTracking.Açıklama = richTextBox1.Text;
            dboTechnicalServiceAndProductTracking.TBLProductTracking.Add(productTracking);
            dboTechnicalServiceAndProductTracking.SaveChanges();

            TBLProductAcceptance productAcceptance = new TBLProductAcceptance();
            int productId = int.Parse(id);
            var deger = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Find(productId);
            deger.StatusDetail = comboBox1.Text;
            MessageBox.Show("Arıza detayı güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string id,seriNo;
        private void FormFaultyDetail_Load(object sender, EventArgs e)
        {
            txtSeriNo.Text = seriNo;
        }
    }
}
