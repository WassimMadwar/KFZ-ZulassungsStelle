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
using W_Business_.License_B;
using W_Business_.Application_B;
using W_Business_.ApplicationType_B_W;
using Basis_W_App.Drivers;
using Basis_W_App.License.International_License;

namespace Basis_W_App.License
{
    public partial class frmNewInternationalLicense : Form
    {
        private int _InternationalLicenseID = -1;

        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }
        private void EventInternational_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblLocalLicenseID.Text = SelectedLicenseID.ToString();

            llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }

            //check the license class, person could not issue international license without having
            //normal license of class 3.

            if (ctrDriverLicenseInfoFilter1.ObjSelectedLicense.LicenseClassID != 3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if person already have an active international license
            int ActiveInternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrDriverLicenseInfoFilter1.ObjSelectedLicense.DriverID);

            if (ActiveInternationalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternationalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternationalLicenseID;
                btnIssueLicense.Enabled = false;
                return;
            }

            btnIssueLicense.Enabled = true;

        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = clsUtilities_W.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = clsUtilities_W.DateToShort(DateTime.Now.AddYears(1));//add one year.
            lblFees.Text = clsApplicationType_B.Find((int)clsApplication_B.enAppType.NewInternationalLic).AppFees.ToString();
            lblCreatedByUser.Text = clsLogIn_W.CurrentUser.UserName;
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicense NewInternational = new clsInternationalLicense();

            NewInternational.AppPersonID = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDriverInfo.PersonID;
            NewInternational.AppDate = DateTime.Now;
            NewInternational.AppStatus = clsApplication_B.enAppStatus.Completed;
            NewInternational.LastStatusDate = DateTime.Now;
            NewInternational.PaidFees = clsApplicationType_B.Find((int)clsApplication_B.enAppType.NewInternationalLic).AppFees;
            NewInternational.CreatedByUserID = clsLogIn_W.CurrentUser.UserID;

            NewInternational.DriverID = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.DriverID;
            NewInternational.IssuedUsingLocalLicenseID = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.LicenseID;  
            NewInternational.IssueDate = DateTime.Now;  
            NewInternational.ExpirationDate = DateTime.Now.AddYears(1);
            NewInternational.CreatedByUserID = clsLogIn_W.CurrentUser.UserID;  
            
            if(!NewInternational.Save())
            {
                MessageBox.Show("Failed to Issue International License btn Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lblApplicationID.Text = NewInternational.AppID.ToString();
            _InternationalLicenseID = NewInternational.InternationalLicenseID;
            lblInternationalLicenseID.Text = NewInternational.InternationalLicenseID.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + NewInternational.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueLicense.Enabled = false;
            ctrDriverLicenseInfoFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
                new frmShowPersonLicenseHistory(ctrDriverLicenseInfoFilter1.ObjSelectedLicense.ObjDriverInfo.PersonID);
            frm.ShowDialog();

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
