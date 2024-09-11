using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basis_W_App.License.International_License
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int InterLicID_;
        public frmShowInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            InterLicID_ = InternationalLicenseID;

        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrInternationalLicenseInfo1.LoadInternationalLicenseInfo(InterLicID_);   
        }
    }
}
