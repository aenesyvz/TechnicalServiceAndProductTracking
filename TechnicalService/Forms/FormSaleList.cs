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
    public partial class FormSaleList : Form
    {
        public FormSaleList()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormSaleList_Load(object sender, EventArgs e)
        {
            var degerler = from sale in dboTechnicalServiceAndProductTracking.TBLMovementProduct
                           join staff in dboTechnicalServiceAndProductTracking.TBLStaffs on sale.Staff equals staff.Id
                           join product in dboTechnicalServiceAndProductTracking.TBLProducts on sale.Product equals product.Id
                           join customer in dboTechnicalServiceAndProductTracking.TBLCurrentInformations on sale.Customer equals customer.Id
                           select new
                           {
                               sale.Id,
                               Urun = product.ProductName,
                               Musteri = customer.FirstName + " "  + customer.LastName,
                               Personel = staff.FirstName + " " + staff.LastName,
                               sale.MovementDate,
                               sale.Quantity,
                               sale.Price,
                               sale.ProductSerialNo
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
