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
    public partial class FormFaultyProductDetails : Form
    {
        public FormFaultyProductDetails()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormFaultyProductDetails_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from productTracking in dboTechnicalServiceAndProductTracking.TBLProductTracking
                                      select new
                                      {
                                          productTracking.Id,
                                          productTracking.SerialNo,
                                          productTracking.TrackingDate,
                                          productTracking.Açıklama
                                      }).ToList();
        }
    }
}
