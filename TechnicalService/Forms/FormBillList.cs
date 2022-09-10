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
    public partial class FormBillList : Form
    {
        public FormBillList()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            var degerler = from billInformation in dboTechnicalServiceAndProductTracking.TBLBillInformations
                           join staff in dboTechnicalServiceAndProductTracking.TBLStaffs on billInformation.Staff equals staff.Id
                           join current in dboTechnicalServiceAndProductTracking.TBLCurrentInformations on billInformation.Current equals current.Id
                           select new
                           {
                               billInformation.Id,
                               billInformation.Serial,
                               billInformation.SequenceNo,
                               billInformation.BillDate,
                               billInformation.Time,
                               billInformation.TaxAdministration,
                               Customer = current.FirstName + " " + current.LastName,
                               Staff = staff.FirstName + " " + staff.LastName
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormBillList_Load(object sender, EventArgs e)
        {
            listele();
            lookUpEditCari.Properties.DataSource = (from current in dboTechnicalServiceAndProductTracking.TBLCurrentInformations
                                                    select new
                                                    {
                                                        current.Id,
                                                        ADSOYAD = current.FirstName + " " + current.LastName
                                                    }).ToList();
            lookUpEditPersonel.Properties.DataSource = (from staff in dboTechnicalServiceAndProductTracking.TBLStaffs
                                                        select new
                                                        {
                                                            staff.Id,
                                                            ADSOYAD = staff.FirstName + " " + staff.LastName
                                                        }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLBillInformations billInformation = new TBLBillInformations();
            billInformation.SequenceNo = txtSira.Text;
            billInformation.Serial = txtSeri.Text;
            billInformation.BillDate = Convert.ToDateTime(txtTarih.Text);
            billInformation.Time = txtSaat.Text;
            billInformation.TaxAdministration = txtVergiDairesi.Text;
            billInformation.Current = int.Parse(lookUpEditCari.EditValue.ToString());
            billInformation.Staff = int.Parse(lookUpEditPersonel.EditValue.ToString());
            dboTechnicalServiceAndProductTracking.TBLBillInformations.Add(billInformation);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Fatura sisteme başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
