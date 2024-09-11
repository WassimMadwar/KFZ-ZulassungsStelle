using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_.License_B;
// the different between PersonCardFilter and ctrDriverLicenseInfoFilter
// heir we use the  ObjSelectedLicense Info from the control as Object 
// and in PersonCardFilter we use the variables from the control
namespace Basis_W_App.License.Controls
{
    public partial class ctrDriverLicenseInfoFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;

        //TO DELETE
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        private int LicenseID_ = -1;
        
        public int LicenseID
        {
            get { return ctrDriverLicenseInfo1.LicenseID; }
        }
        public clsLicense_B ObjSelectedLicense
        {
            get { return ctrDriverLicenseInfo1.ObjTargetLicense; }
        }

        // to call the control from another form but without Activated to the Filter
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public ctrDriverLicenseInfoFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrDriverLicenseInfo1.LoadInfo(LicenseID);
            LicenseID_ = ctrDriverLicenseInfo1.LicenseID;
            if (OnLicenseSelected != null && FilterEnabled)
            {
                OnLicenseSelected(LicenseID_);
            }
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }

        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseID, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtLicenseID, null);
            }
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;

            }
            LicenseID_ = int.Parse(txtLicenseID.Text.Trim());
            LoadLicenseInfo(LicenseID_);
        }
    }
}
