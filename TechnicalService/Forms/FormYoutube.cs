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
    public partial class FormYoutube : Form
    {
        public FormYoutube()
        {
            InitializeComponent();
        }

        private void FormYoutube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://youtube.com");
        }
    }
}
