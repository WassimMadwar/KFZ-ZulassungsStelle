﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basis_W_App.License
{
    public partial class frmShowLicenseInfo : Form
    {
        private int LicenseID_ = -1;
        public frmShowLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            LicenseID_ = LicenseID;
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrDriverLicenseInfo1.LoadInfo(LicenseID_);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
