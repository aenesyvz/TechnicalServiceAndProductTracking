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
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            gridControl1.DataSource = dboTechnicalServiceAndProductTracking.TBLNotes.Where(x => x.Status == false).ToList();
            gridControl2.DataSource = dboTechnicalServiceAndProductTracking.TBLNotes.Where(x => x.Status == true).ToList();
        }
        private void FormNotes_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            TBLNotes note = new TBLNotes();
            note.Title = txtBaşlık.Text;
            note.Contents = txtİçerik.Text;
            note.Status = false;
            dboTechnicalServiceAndProductTracking.TBLNotes.Add(note);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Not başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtNoteId.Text);
            var deger = dboTechnicalServiceAndProductTracking.TBLNotes.Find(id);
            dboTechnicalServiceAndProductTracking.TBLNotes.Remove(deger);
            dboTechnicalServiceAndProductTracking.SaveChanges();
            MessageBox.Show("Not başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
             if(checkEdit1.Checked == true)
             {
                int id = int.Parse(txtNoteId.Text);
                var deger = dboTechnicalServiceAndProductTracking.TBLNotes.Find(id);
                deger.Status = true;
                dboTechnicalServiceAndProductTracking.SaveChanges();
                MessageBox.Show("Not okundu olarak işaretlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNoteId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
