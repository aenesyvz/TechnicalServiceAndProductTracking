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
    public partial class FormAddNewDepartment : Form
    {
        public FormAddNewDepartment()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTrackingEntities = new DboTechnicalServiceAndProductTrackingEntities2();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDepartments department = new TBLDepartments();
            department.DepartmentName = txtDepartmanAd.Text;
            department.Statement = txtAçıklama.Text;
            dboTechnicalServiceAndProductTrackingEntities.TBLDepartments.Add(department);
            dboTechnicalServiceAndProductTrackingEntities.SaveChanges();
            MessageBox.Show("Yeni departman başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }
    }
}
