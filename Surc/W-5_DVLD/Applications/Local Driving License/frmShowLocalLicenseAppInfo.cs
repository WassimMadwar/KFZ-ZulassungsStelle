using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basis_W_App.Applications.Local_Driving_License
{
    public partial class frmShowLocalLicenseAppInfo : Form
    {
        private int LocalLicenseAppID_ = -1;

        public frmShowLocalLicenseAppInfo(int LocalLicenseAppID)
        {
            InitializeComponent();
            LocalLicenseAppID_ = LocalLicenseAppID; 
        }

        private void frmShowLocalLicenseAppInfo_Load(object sender, EventArgs e)
        {
            ctrLocalLicenseAppInfo1.LoadInfoBy_LocalLicenseAppID(LocalLicenseAppID_);
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
