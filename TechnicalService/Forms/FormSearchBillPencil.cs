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
    public partial class FormSearchBillPencil : Form
    {
        public FormSearchBillPencil()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            int id = Convert.ToInt32(txtFaturaId.Text);
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
            gridControl1.DataSource = degerler.Where(x => x.BillId == id).ToList();
        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
