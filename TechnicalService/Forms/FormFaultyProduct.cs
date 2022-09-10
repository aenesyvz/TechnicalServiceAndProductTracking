using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechnicalService.Forms
{
    public partial class FormFaultyProduct : Form
    {
        public FormFaultyProduct()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormFaultyProduct_Load(object sender, EventArgs e)
        {
            var degerler = from faultyProduct in dboTechnicalServiceAndProductTracking.TBLProductAcceptance
                           join product in dboTechnicalServiceAndProductTracking.TBLProducts on faultyProduct.Id equals product.Id
                           join customer in dboTechnicalServiceAndProductTracking.TBLCurrentInformations on faultyProduct.Current equals customer.Id
                           join staff in dboTechnicalServiceAndProductTracking.TBLStaffs on faultyProduct.Staff equals staff.Id
                           select new
                           {
                               faultyProduct.Id,
                               Ürün = product.ProductName,
                               Müşteri = customer.FirstName + " " + customer.LastName,
                               Personel = staff.FirstName + " " + staff.LastName,
                               faultyProduct.ReleaseDate,
                               faultyProduct.ArrivalDate,
                               faultyProduct.StatusDetail
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl3.Text = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Count(x => x.Status == false).ToString();
            labelControl5.Text = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Count(x => x.Status == true).ToString();
            labelControl14.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Count().ToString();
            labelControl7.Text = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Count(x => x.StatusDetail == "Parça bekleniyor").ToString();
            labelControl12.Text = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Count(x => x.StatusDetail == "Mesaj bekleniyor").ToString();
            labelControl7.Text = dboTechnicalServiceAndProductTracking.TBLProductAcceptance.Count(x => x.StatusDetail == "İptal edilen işlemler").ToString();
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DboTechnicalServiceAndProductTracking;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select StatusDetail,Count(*) from TBLProductAcceptance group by StatusDetail", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormFaultyDetail formFaultyDetail = new FormFaultyDetail();
            formFaultyDetail.id = gridView1.GetFocusedRowCellValue("ProcessId").ToString();
            formFaultyDetail.seriNo = gridView1.GetFocusedRowCellValue("ProductSerialNo").ToString();
        }
    }
}
