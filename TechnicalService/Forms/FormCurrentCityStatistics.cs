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
    public partial class FormCurrentCityStatistics : Form
    {
        public FormCurrentCityStatistics()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DboTechnicalServiceAndProductTracking;Integrated Security=True");
        private void FormCurrentCityStatistics_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource = dboTechnicalServiceAndProductTracking.TBLCurrentInformations
                .OrderBy(x => x.City)
                .GroupBy(x => x.City)
                .Select(z => new
                {
                    İl = z.Key,Toplam = z.Count()
                }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select City,Count(*) from TBLCurrentInformations group by City", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
