using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basis_W_App.Drivers
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int PersonID_ = -1;
        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }

        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            PersonID_ = PersonID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if (PersonID_ != -1)
            {
                ctrPersonCardWithFilter1.LoadPersonInfo(PersonID_);
                ctrPersonCardWithFilter1.FilterEnabled = false;
                //ctrDriverHistory1.LoadInfoByPersonID(PersonID_);
            }
            else
            {
                ctrPersonCardWithFilter1.Enabled = true;

            }

        }
  


   

        private void MyEvent_OnPersonSelected(int MyObj)
        {
            PersonID_ = MyObj;
            if (PersonID_ == -1)
            {
                ctrDriverHistory1.Clear();

            }
            else
                ctrDriverHistory1.LoadInfoByPersonID(PersonID_);
        }
    }
}
