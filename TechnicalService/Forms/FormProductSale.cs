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
    public partial class FormProductSale: Form
    {
        public FormProductSale()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormProductSale_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLMovementProduct movementProduct = new TBLMovementProduct();
            movementProduct.Product = int.Parse(txtÜrünId.Text);
            movementProduct.Customer = int.Parse(txtMüşteri.Text);
            movementProduct.Staff = int.Parse(txtPersonel.Text);
            movementProduct.MovementDate = DateTime.Parse(txtTarih.Text);
            movementProduct.Quantity = int.Parse(txtAdet.Text);
            movementProduct.Price = decimal.Parse(txtSatışFiyat.Text);
            movementProduct.ProductSerialNo = txtSeriNo.Text;
            dboTechnicalServiceAndProductTracking.TBLMovementProduct.Add(movementProduct);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Satış işlemi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
