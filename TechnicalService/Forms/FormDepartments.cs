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
    public partial class FormDepartments : Form
    {
        public FormDepartments()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            gridControl1.DataSource = dboTechnicalServiceAndProductTracking.TBLDepartments.ToList();
            labelControl12.Text = dboTechnicalServiceAndProductTracking.TBLDepartments.Count().ToString();
            labelControl14.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.Count().ToString();
        }
        private void FormDepartments_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDepartments department = new TBLDepartments();
            if(txtDepatmanİsmi.Text != "" && txtDepatmanİsmi.Text.Length <= 50 && rchAçıklama.Text.Length >= 1)
            {
                department.DepartmentName = txtDepatmanİsmi.Text;
                department.Statement = rchAçıklama.Text;
                dboTechnicalServiceAndProductTracking.TBLDepartments.Add(department);
                dboTechnicalServiceAndProductTracking.SaveChanges();
                MessageBox.Show("Yeni departman başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Yeni departman kaydedilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmanId.Text);
            var deger = dboTechnicalServiceAndProductTracking.TBLDepartments.Find(id);
            dboTechnicalServiceAndProductTracking.TBLDepartments.Remove(deger);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Departman başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepartmanId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtDepatmanİsmi.Text = gridView1.GetFocusedRowCellValue("DepartmentName").ToString();
            rchAçıklama.Text = gridView1.GetFocusedRowCellValue("Statement").ToString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDepartmanId.Text);
            var deger = dboTechnicalServiceAndProductTracking.TBLDepartments.Find(id);
            deger.DepartmentName = txtDepatmanİsmi.Text;
            deger.Statement = rchAçıklama.Text;
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Departman başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
