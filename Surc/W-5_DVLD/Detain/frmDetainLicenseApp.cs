using Basis_W_App.Drivers;
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

namespace Basis_W_App.License
{
    public partial class frmDetainLicenseApp : Form
    {
        private int DetainID_ = -1;
        private int SelectedLicenseID_ = -1;
        public frmDetainLicenseApp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetainLicenseApp_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsUtilities_W.DateToShort(DateTime.Now);
            lblCreatedByUser.Text = clsLogIn_W.CurrentUser.UserName;
        }

        private void MyEvent_OnLicenseSelected(int MyObj)
        {
            SelectedLicenseID_ = MyObj;
            lblLicenseID.Text = SelectedLicenseID_.ToString();

            llShowLicenseHistory.Enabled = (SelectedLicenseID_ != -1);

            if (SelectedLicenseID_ == -1)
            {
                return;
            }

            //ToDo: make sure the license is not detained already.|| !ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsActive
            if (ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsDetained )
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ctrDriverLicenseInfoFilter1.ObjSelectedLicense.IsActive)
            {
                MessageBox.Show("Selected License i NOT AKTIVE, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void frmDetainLicenseApp_Activated(object sender, EventArgs e)
        {
            ctrDriverLicenseInfoFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(SelectedLicenseID_);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(SelectedLicenseID_);  
            frm.ShowDialog();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);

            };


            if (!clsValidation_W.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            };
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            DetainID_ = ctrDriverLicenseInfoFilter1.ObjSelectedLicense.Detain(Convert.ToSingle(txtFineFees.Text), clsLogIn_W.CurrentUser.UserID);

            if (DetainID_ == -1)
            {
                MessageBox.Show("Failed to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblDetainID.Text = DetainID_.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + DetainID_.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrDriverLicenseInfoFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;
            llShowLicenseInfo.Enabled = true;  
        }
    }
}
