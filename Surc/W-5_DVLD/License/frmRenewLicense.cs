using Basis_W_App.Tools_W;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_.ApplicationType_B_W;
using W_Business_.Application_B;
using W_Business_.License_B;

namespace Basis_W_App.License
{
    public partial class frmRenewLicense : Form
    {
        private int _NewLicenseID = -1;

        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            ctrDriverLicenseInfoFilter1.txtLicenseIDFocus();


            lblApplicationDate.Text = clsUtilities_W.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;

            lblExpirationDate.Text = "???";
            lblApplicationFees.Text = clsApplicationType_B.Find((int)clsApplication_B.enAppType.RenewLic).AppFees.ToString();
            lblCreatedByUser.Text = clsLogIn_W.CurrentUser.UserName;
        }
        private void ctrDriverLicenseFilter_OnLicenseSelected(int MyObj)
        {
            int SelectedLicenseID = MyObj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();


            if (SelectedLicenseID == -1)
            {
                return;
            }

            int DefaultValidityLength = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjLicenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text = clsUtilities_W.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblLicenseFees.Text = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjLicenseClassInfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.Notes;

            llShowLicenseHistory.Enabled = true;
            llShowLicenseInfo.Enabled = true;

            //check the license is not Expired.
            if (!ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsLicenseExpired_B())
            {
                MessageBox.Show("Selected License is not yet expired, it will expire on: " + clsUtilities_W.DateToShort(ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ExpirationDate)
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;

                return;
            }

            //check the license is not Active.
            if (!ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenewLicense.Enabled = false;

                return;
            }



            btnRenewLicense.Enabled = true;

        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense_B NewLicense =
                ctrDriverLicenseInfoFilter1.ObjSelectedLicense.RenewLicense(txtNotes.Text.Trim(),
                clsLogIn_W.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenewLicense.Enabled = false;
            ctrDriverLicenseInfoFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void frmRenewLicense_Activated(object sender, EventArgs e)
        {
            ctrDriverLicenseInfoFilter1.txtLicenseIDFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLicenseInfo(ctrDriverLicenseInfoFilter1.LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
