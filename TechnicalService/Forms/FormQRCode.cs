﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TechnicalService.Forms
{
    public partial class FormQRCode : Form
    {
        public FormQRCode()
        {
            InitializeComponent();
        }

        private void FormQRCode_Load(object sender, EventArgs e)
        {

        }

        private void BtnQrCode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(textEdit1.Text);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
