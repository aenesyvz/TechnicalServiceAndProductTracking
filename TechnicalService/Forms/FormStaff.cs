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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }
        DboTechnicalServiceAndProductTrackingEntities2 dboTechnicalServiceAndProductTracking = new DboTechnicalServiceAndProductTrackingEntities2();
        void listele()
        {
            var degerler = from staff in dboTechnicalServiceAndProductTracking.TBLStaffs
                           //join department in dboTechnicalServiceAndProductTracking.TBLDepartments on staff.Department equals department.Id
                           select new
                           {
                               staff.Id,
                               staff.FirstName,
                               staff.LastName,
                               staff.Email,
                               staff.PhoneNumber,
                               //Departman = department.DepartmentName
                           };
            gridControl1.DataSource = degerler.ToList();
            lueDepartman.Properties.DataSource = (from departman in dboTechnicalServiceAndProductTracking.TBLDepartments
                                                 select new
                                                 {
                                                     departman.Id,
                                                     departman.DepartmentName
                                                 }).ToList();
        }
        private void FormStaff_Load(object sender, EventArgs e)
        {
            listele();
            //string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //ad1 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).FirstName;
            //soyad1 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).LastName;
            //labelControl12.Text = ad1 + " " + soyad1;
            ////labelControl20.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).TBLDepartment.DepartmentName;
            //labelControl22.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).Email;

            //ad2 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 2).FirstName;
            //soyad2 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 2).LastName;
            //labelControl18.Text = ad2 + " " + soyad2;
            ////labelControl16.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).TBLDepartment.DepartmentName;
            //labelControl14.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 2).Email;

            //ad3 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 3).FirstName;
            //soyad3 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 3).LastName;
            //labelControl28.Text = ad3 + " " + soyad3;
            ////labelControl26.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).TBLDepartment.DepartmentName;
            //labelControl24.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 3).Email;

            //ad4 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 4).FirstName;
            //soyad4 = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 4).LastName;
            //labelControl34.Text = ad4 + " " + soyad4;
            ////labelControl32.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 1).TBLDepartment.DepartmentName;
            //labelControl30.Text = dboTechnicalServiceAndProductTracking.TBLStaffs.First(x => x.Id == 4).Email;
        }
    }
}
