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
    public partial class FormProductStatistics : Form
    {
        public FormProductStatistics()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormProductStatistics_Load(object sender, EventArgs e)
        {
            labelControl2.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Count().ToString();
            labelControl3.Text = dboTechnicalServiceAndProductTracking.TBLCategories.Count().ToString();
            labelControl5.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Sum(x => x.UnitsInStock).ToString();
            labelControl7.Text = "10";
            labelControl19.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                   orderby x.UnitsInStock descending
                                   select x.ProductName).FirstOrDefault();
            labelControl18.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                   orderby x.UnitsInStock ascending
                                   select x.ProductName).FirstOrDefault();
            labelControl13.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                   orderby x.SalePrice descending
                                   select x.ProductName).FirstOrDefault();
            labelControl12.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                   orderby x.SalePrice ascending
                                   select x.ProductName).FirstOrDefault();
            labelControl31.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Count(x => x.Category == 4).ToString();
            labelControl24.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Count(x => x.Category == 1).ToString();
            labelControl23.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Count(x => x.Category == 3).ToString();
            labelControl38.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                   select x.Brand).Distinct().Count().ToString();
            labelControl29.Text = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Count().ToString();
            labelControl25.Text = dboTechnicalServiceAndProductTracking.MaksKategoriUrun().FirstOrDefault();
        }
    }
}
