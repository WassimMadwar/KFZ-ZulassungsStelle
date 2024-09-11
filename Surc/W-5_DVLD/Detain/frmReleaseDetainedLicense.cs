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
using Basis_W_App.Tools_W;
using Basis_W_App.License;
using Basis_W_App.Drivers;


namespace Basis_W_App.Detain
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int SelectedLicenseID_ = -1;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();

            SelectedLicenseID_ = LicenseID;
            ctrDriverLicenseInfoFilter1.LoadLicenseInfo(LicenseID);
            ctrDriverLicenseInfoFilter1.FilterEnabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(SelectedLicenseID_);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDriverInfo.PersonID);  
            frm.ShowDialog();
        }
        private void ReleaseEvent_OnLicenseSelected(int obj)
        {
            SelectedLicenseID_ = obj;

            if (SelectedLicenseID_ == -1)
            {
                return;
            }
            lblLicenseID.Text = SelectedLicenseID_.ToString();

            llShowLicenseHistory.Enabled = (SelectedLicenseID_ != -1);
            llShowLicenseInfo.Enabled = (SelectedLicenseID_ != -1);

            if (!ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsDetained)
            {
                MessageBox.Show("Selected License is Not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblApplicationFees.Text = clsApplicationType_B.Find((int)clsApplication_B.enAppType.ReleaseDetainedLic).AppFees.ToString();
            lblCreatedByUser.Text = clsLogIn_W.CurrentUser.UserName;

            lblDetainID.Text = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.LicenseID.ToString();

            lblCreatedByUser.Text = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDetainedInfo.ObjCreatedByUser.UserName;
            lblDetainDate.Text = clsUtilities_W.DateToShort(ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDetainedInfo.DetainDate);
            lblFineFees.Text = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;

            bool IsReleased = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ReleaseDetainedLicense(clsLogIn_W.CurrentUser.UserID, ref ApplicationID); ;



            lblApplicationID.Text = ApplicationID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Failed to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrDriverLicenseInfoFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }
    }
}
