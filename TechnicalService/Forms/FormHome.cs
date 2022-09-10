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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void FormHome_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from product in dboTechnicalServiceAndProductTracking.TBLProducts
                                      select new
                                      {
                                          product.ProductName,
                                          product.UnitsInStock
                                      }).Where(x =>x.UnitsInStock < 20).ToList();
            gridControl2.DataSource = (from current in dboTechnicalServiceAndProductTracking.TBLCurrentInformations
                                       select new
                                       {
                                           current.FirstName,
                                           current.LastName,
                                           current.City
                                       }).ToList();
            gridControl3.DataSource = dboTechnicalServiceAndProductTracking.UrunKategori().ToList();
            DateTime today = DateTime.Today;
            var deger = (from note in dboTechnicalServiceAndProductTracking.TBLNotes
                         .OrderBy(x => x.Id).Where(y => y.NoteDate == today)
                         select new
                         {
                             note.Title,
                             note.Contents
                         });
            gridControl4.DataSource = deger.ToList();

            //string ad1, konu1, ad2, konu2, ad3, konu3, ad4, konu4, ad5, konu5, ad6, konu6, ad7, konu7, ad8, konu8, ad9, konu9, ad10, konu10;   //Dinamik olarak oluşturabilir
            /*labelControl1.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 1).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 1).Konu;
            labelControl2.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 2).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 2).Konu;
            labelControl3.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 3).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 3).Konu;
            labelControl4.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 4).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 4).Konu;
            labelControl5.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 5).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 5).Konu;
            labelControl6.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 6).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 6).Konu;
            labelControl7.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 7).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 7).Konu;
            labelControl8.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 8).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 8).Konu;
            labelControl9.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 9).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 9).Konu;
            labelControl10.Text = dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 10).AdSoyad + " - " + dboTechnicalServiceAndProductTracking.TBLMessage.First(x => x.Id == 10).Konu;*/
        }
    }
}
