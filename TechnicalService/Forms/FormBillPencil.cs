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
    public partial class FormBillPencil : Form
    {
        public FormBillPencil()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            var degerler = from billDetail in dboTechnicalServiceAndProductTracking.TBLBillDetails
                           select new
                           {
                               billDetail.Id,
                               billDetail.Product,
                               billDetail.Quantity,
                               billDetail.Price,
                               billDetail.Amount,
                               billDetail.BillId
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormBillPencil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLBillDetails billDetail = new TBLBillDetails();
            billDetail.Product = txtÜrün.Text;
            billDetail.Quantity = int.Parse(txtAdet.Text);
            billDetail.Price = decimal.Parse(txtFiyat.Text);
            billDetail.Amount = decimal.Parse(txtTutar.Text);
            billDetail.BillId = int.Parse(txtFaturaId.Text);
            dboTechnicalServiceAndProductTracking.TBLBillDetails.Add(billDetail);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Faturaya kalem girişi yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
