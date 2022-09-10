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
    public partial class FormDefectiveProductRegistration : Form
    {
        public FormDefectiveProductRegistration()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TBLProductAcceptance productAcceptance = new TBLProductAcceptance();
            productAcceptance.Current = int.Parse(lpuMusteri.EditValue.ToString());
            productAcceptance.ArrivalDate = DateTime.Parse(txtTarih.Text);
            productAcceptance.Staff = int.Parse(lpPersonel.EditValue.ToString());
            productAcceptance.ProductSerialNo = txtSeriNo.Text;
            productAcceptance.StatusDetail = "Ürün kaydoldu";
            dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Add(productAcceptance);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Arızalı ürün başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDefectiveProductRegistration_Load(object sender, EventArgs e)
        {
            lpuMusteri.Properties.DataSource = (from customer in dboTechnicalServiceAndProductTracking.TBLCurrentInformations
                                                select new
                                                {
                                                    customer.Id,
                                                    Ad = customer.FirstName + customer.LastName,
                                                }).ToList();
            lpPersonel.Properties.DataSource = (from staff in dboTechnicalServiceAndProductTracking.TBLStaffs
                                                select new
                                                {
                                                    staff.Id,
                                                    Ad = staff.FirstName + staff.LastName,
                                                }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
