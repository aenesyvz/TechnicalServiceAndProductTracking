using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Forms.FormProductList formProductList;
        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(formProductList == null || formProductList.IsDisposed)
            {
                formProductList = new Forms.FormProductList();
                formProductList.MdiParent = this;
                formProductList.Show();
            }
        }
        Forms.FormCategories formCategories;
        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(formCategories == null || formCategories.IsDisposed)
            {
                formCategories = new Forms.FormCategories();
                formCategories.MdiParent = this;
                formCategories.Show();
            }
            
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormNewCategory formNewCategory = new Forms.FormNewCategory();
            formNewCategory.Show();
        }
        Forms.FormProductStatistics formProductStatistics;
        private void BtnÜrünİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(formProductStatistics == null || formProductStatistics.IsDisposed)
            {
                formProductStatistics = new Forms.FormProductStatistics();
                formProductStatistics.MdiParent = this;
                formProductStatistics.Show();
            }
            
        }
        Forms.FormBrands formBrands;
        private void BtnMarkaİst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(formBrands == null || formBrands.IsDisposed)
            {
                formBrands = new Forms.FormBrands();
                formBrands.MdiParent = this;
                formBrands.Show();
            }
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormAddNewCurrent formAddNewCurrent = new Forms.FormAddNewCurrent();
            formAddNewCurrent.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormNewCurrentList formNewCurrentList = new Forms.FormNewCurrentList();
            formNewCurrentList.MdiParent = this;
            formNewCurrentList.Show();
        }

        private void BtnCariİlİstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormCurrentCityStatistics formCurrentCityStatistics = new Forms.FormCurrentCityStatistics();
            formCurrentCityStatistics.MdiParent = this;
            formCurrentCityStatistics.Show();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormDepartments formDepartments = new Forms.FormDepartments();
            formDepartments.MdiParent = this;
            formDepartments.Show();
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormAddNewDepartment formAddNewDepartment = new Forms.FormAddNewDepartment();
            formAddNewDepartment.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormStaff formStaff = new Forms.FormStaff();
            formStaff.MdiParent = this;
            formStaff.Show();
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnDövizKurları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormExchangeRates formExchangeRates = new Forms.FormExchangeRates();
            formExchangeRates.MdiParent = this;
            formExchangeRates.Show();
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormYoutube formYoutube = new Forms.FormYoutube();
            formYoutube.MdiParent = this;
            formYoutube.Show();
        }

        private void BtnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormNotes formNotes = new Forms.FormNotes();
            formNotes.MdiParent = this;
            formNotes.Show();
        }

        private void BtnArızalıÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormFaultyProduct formFaultyProduct = new Forms.FormFaultyProduct();
            formFaultyProduct.MdiParent = this;
            formFaultyProduct.Show();
        }

        private void BtnÜrünSatış_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormProductSale formProductSale = new Forms.FormProductSale();
            formProductSale.Show();
        }

        private void BtnSatışListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormSaleList formSaleList = new Forms.FormSaleList();
            formSaleList.MdiParent = this;
            formSaleList.Show();
        }

        private void BtnYeniArızalıÜrünKaydı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormDefectiveProductRegistration formDefectiveProductRegistration = new Forms.FormDefectiveProductRegistration();
            formDefectiveProductRegistration.Show();
        }

        private void BtnArızalıÜrünAçıklaması_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormFaultyDetail formFaultyDetail = new Forms.FormFaultyDetail();
            formFaultyDetail.Show();
        }

        private void BtnArızalıÜrünDetayları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormFaultyProductDetails formFaultyProductDetails = new Forms.FormFaultyProductDetails();
            formFaultyProductDetails.MdiParent = this;
            formFaultyProductDetails.Show();
        }

        private void BtnQrCodeOluştur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormQRCode formQRCode = new Forms.FormQRCode();
            formQRCode.Show();
        }

        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormBillList formBillList = new Forms.FormBillList();
            formBillList.MdiParent = this;
            formBillList.Show();
        }

        private void BtnFaturayaKalemGirişi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormBillPencil formBillPencil = new Forms.FormBillPencil();
            formBillPencil.MdiParent = this;
            formBillPencil.Show();
        }

        private void BtnDetaylıFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormSearchBillPencil formSearchBillPencil = new Forms.FormSearchBillPencil();
            formSearchBillPencil.MdiParent = this;
            formSearchBillPencil.Show();
        }

        private void BtnHakkımızda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormAbout formAbout = new Forms.FormAbout();
            formAbout.MdiParent = this;
            formAbout.Show();
        }

        private void BtnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormMaps formMaps = new Forms.FormMaps();
            formMaps.MdiParent = this;
            formMaps.Show();
        }

        private void BtnRaporSihirbazı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FormReports  formReports = new Forms.FormReports();
            formReports.Show();
        }
        Forms.FormHome formHome;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (formHome == null || formHome.IsDisposed)
            {
                formHome = new Forms.FormHome();
                formHome.MdiParent = this;
                formHome.Show();
            }

        }
        
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formHome == null || formHome.IsDisposed)
            {
                formHome = new Forms.FormHome();
                formHome.MdiParent = this;
                formHome.Show();
            }
        }
    }
}
