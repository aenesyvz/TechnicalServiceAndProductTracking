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
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            var degerler = from category in dboTechnicalServiceAndProductTracking.TBLCategories
                           select new
                           {
                               category.Id,
                               category.CategoryName
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormCategories_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtKategoriId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtKategoriAd.Text = gridView1.GetFocusedRowCellValue("CategoryName").ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(txtKategoriAd.Text != "")
            {
                TBLCategories category = new TBLCategories();
                category.CategoryName = txtKategoriAd.Text;
                dboTechnicalServiceAndProductTracking.TBLCategories.Add(category);
                dboTechnicalServiceAndProductTracking.SaveChanges();
                MessageBox.Show("Kategori başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Kategori adı boş geçilemez!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Kategori silme işlemi yapmak istiyor musunuz?", "Kontrol", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(secenek == DialogResult.Cancel)
            {
                MessageBox.Show("Kategori silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = int.Parse(txtKategoriId.Text);
                var deger = dboTechnicalServiceAndProductTracking.TBLCategories.Find(id);
                dboTechnicalServiceAndProductTracking.TBLCategories.Remove(deger);
                dboTechnicalServiceAndProductTracking.SaveChanges();
                MessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var deger = dboTechnicalServiceAndProductTracking.TBLCategories.Find(id);
            deger.CategoryName = txtKategoriAd.Text;
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        void temizle()
        {
            txtKategoriId.Text = "";
            txtKategoriAd.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
