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
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            var degerler = from product in dboTechnicalServiceAndProductTracking.TBLProducts
                           //join category in dboTechnicalServiceAndProductTracking.TBLCategories
                           //on product.Category equals category.Id
                           select new
                           {
                               product.Id,
                               product.ProductName,
                               product.Brand,
                               product.UnitsInStock,
                               product.PurchasePrice,
                               product.SalePrice,
                               //Kategori = category.CategoryName
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FormProductList_Load(object sender, EventArgs e)
        {
            listele();
            lueKategori.Properties.DataSource = (from category in dboTechnicalServiceAndProductTracking.TBLCategories
                                                 select new
                                                 {
                                                     category.Id,
                                                     category.CategoryName
                                                 }).ToList();
            temizle();
        }
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtUrunId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                txtUrunAd.Text = gridView1.GetFocusedRowCellValue("ProductName").ToString();
                txtMarka.Text = gridView1.GetFocusedRowCellValue("Brand").ToString();
                txtStok.Text = gridView1.GetFocusedRowCellValue("UnitsInStock").ToString();
                txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("PurchasePrice").ToString();
                txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SalePrice").ToString();
                //lueKategori.EditValue = gridView1.GetFocusedRowCellValue("Category").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLProducts product = new TBLProducts();
            product.ProductName = txtUrunAd.Text;
            product.Brand = txtMarka.Text;
            product.PurchasePrice = decimal.Parse(txtAlisFiyat.Text);
            product.SalePrice = decimal.Parse(txtSatisFiyat.Text);
            product.UnitsInStock = short.Parse(txtStok.Text);
            product.Status = false;
            //product.Category = byte.Parse(lueKategori.EditValue.ToString());
            dboTechnicalServiceAndProductTracking.TBLProducts.Add(product);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = dboTechnicalServiceAndProductTracking.TBLProducts.Find(id);
            dboTechnicalServiceAndProductTracking.TBLProducts.Remove(deger);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = dboTechnicalServiceAndProductTracking.TBLProducts.Find(id);
            deger.ProductName = txtUrunAd.Text;
            deger.Brand = txtMarka.Text;
            deger.UnitsInStock = short.Parse(txtStok.Text);
            deger.PurchasePrice = decimal.Parse(txtAlisFiyat.Text);
            deger.SalePrice = decimal.Parse(txtSatisFiyat.Text);
            deger.Category = byte.Parse(lueKategori.EditValue.ToString());
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        void temizle()
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtMarka.Text = "";
            txtStok.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }
    }
}
