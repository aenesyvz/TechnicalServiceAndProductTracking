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
    public partial class FormNewCategory : Form
    {
        public FormNewCategory()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(txtKategoriAd.Text != "")
            {
                TBLCategories category = new TBLCategories();
                category.CategoryName = txtKategoriAd.Text;
                dboTechnicalServiceAndProductTracking.TBLCategories.Add(category);
                dboTechnicalServiceAndProductTracking.SaveChanges();
                MessageBox.Show("Kategori başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori adı boş geçilemez!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
