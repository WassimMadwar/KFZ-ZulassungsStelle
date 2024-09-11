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
using W_Business_.Application_B;
using W_Business_.ApplicationType_B_W;
using W_Business_.License_B;
using static W_Business_.License_B.clsLicense_B;

namespace Basis_W_App.License
{
    public partial class frmReplaceLostOrDamagedLicense : Form
    {
        private int _NewLicenseID = -1;

        private int GetAppTypeID_frm()
        {
            
            if (rbDamagedLicense.Checked)
                return (int)clsApplication_B.enAppType.ReplaceDamagedLic;
            else
                return (int)clsApplication_B.enAppType.ReplaceLostLic;
        }

        private enIssueReason GetIssueReason_frm()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamagedLicense.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }

        public frmReplaceLostOrDamagedLicense()
        {
            InitializeComponent();
        }

        private void ctrDriverLicenseFilter_OnLicenseSelected(int MyObj)
        {
            int SelectedLicenseID = MyObj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();


            if (SelectedLicenseID == -1)
            {
                return;
            }

            llShowLicenseHistory.Enabled = true;
            llShowLicenseInfo.Enabled = true;

            //check the license is not Active.
            if (!ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;

                return;
            }


            btnIssueReplacement.Enabled = true;

        }

        private void frmReplaceLostOrDamagedLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsUtilities_W.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsLogIn_W.CurrentUser.UserName;

            rbDamagedLicense.Checked = true;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationType_B.Find(GetAppTypeID_frm()).AppFees.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Lost License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsApplicationType_B.Find(GetAppTypeID_frm()).AppFees.ToString();  
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense_B NewLicense = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ReplaceLicense
                (GetIssueReason_frm(), clsLogIn_W.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrDriverLicenseInfoFilter1.FilterEnabled = false;
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowLicenseInfo(ctrDriverLicenseInfoFilter1.LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReplaceLostOrDamagedLicense_Activated(object sender, EventArgs e)
        {
            ctrDriverLicenseInfoFilter1.txtLicenseIDFocus();
        }
    }
}
