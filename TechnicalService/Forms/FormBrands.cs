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
    public partial class FormBrands : Form
    {
        public FormBrands()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormBrands_Load(object sender, EventArgs e)
        {
            var degerler = dboTechnicalServiceAndProductTracking.TBLProducts.OrderBy(x => x.UnitsInStock).GroupBy(y => y.Brand).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = dboTechnicalServiceAndProductTracking.TBLProducts.Count().ToString();
            labelControl3.Text = dboTechnicalServiceAndProductTracking.MaksUrunMarka().FirstOrDefault();
            labelControl5.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                  select x.UnitsInStock).Distinct().Count().ToString();
            labelControl7.Text = (from x in dboTechnicalServiceAndProductTracking.TBLProducts
                                   orderby x.SalePrice descending
                                   select x.ProductName).FirstOrDefault();
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DboTechnicalServiceAndProductTracking;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Brand,Count(*) from TBLProducts group by Brand", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
            baglanti.Open();
            /*SqlCommand komut2 = new SqlCommand("Select TBLCategories.CategoryName,Count(*) from TBLProducts" +
                "inner join TBLCategories on TBLCategories.Id = TBLProducts.Category group by TBLCategory.CategoryName", baglanti);
            SqlDataReader d2 = komut2.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();*/
        }
    }
}
