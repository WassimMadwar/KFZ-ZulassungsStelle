﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_;
using Basis_W_App.License;

namespace Basis_W_App.Drivers
{
    public partial class ctrDriverHistory : UserControl
    {
        private int DriverID_;
        private clsDriver ObjDriver_;
        private DataTable dtDriverLocalLicensesHistory;
        private DataTable dtDriverInternationalLicensesHistory;

        public ctrDriverHistory()
        {
            InitializeComponent();
        }

        private void LoadLocalLicenseInfo()
        {

            dtDriverLocalLicensesHistory = clsDriver.GetLicenses(DriverID_);


            dgvLocalLicensesHistory.DataSource = dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 110;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 170;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 170;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;

            }
        }

        private void LoadInternationalLicenseInfo()
        {

            dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(DriverID_);


            dgvInternationalLicensesHistory.DataSource = dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {
                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 160;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 130;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 130;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 180;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 180;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 120;

            }
        }

        public void LoadInfo(int DriverID)
        {
            DriverID_ = DriverID;
            ObjDriver_ = clsDriver.FindByDriverID(DriverID_);
            
            if (ObjDriver_ == null)
            {
                MessageBox.Show(" Sorry there are no longer Driver : " + DriverID_);
                return;
            }
            LoadLocalLicenseInfo();
            LoadInternationalLicenseInfo();
        }

        public void LoadInfoByPersonID(int PersonID)
        {

            ObjDriver_ = clsDriver.FindByPersonID(PersonID);

            if (ObjDriver_ == null)
            {
                MessageBox.Show(" Sorry there is no linked with Person  : " + PersonID);
                return;
            }

           
            DriverID_ = ObjDriver_.DriverID;

            LoadLocalLicenseInfo();
            LoadInternationalLicenseInfo();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;

            //DriverLicense.frmShowLicenseInfo frm = new DriverLicense.frmShowLicenseInfo(LicenseID);
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
       
        public void Clear()
        {
            dtDriverLocalLicensesHistory.Clear();
            dtDriverInternationalLicensesHistory.Clear(); 

        }

        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
