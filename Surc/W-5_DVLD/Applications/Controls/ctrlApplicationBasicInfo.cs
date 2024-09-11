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
using Basis_W_App.Tools_W;
using static System.Net.Mime.MediaTypeNames;
using Basis_W_App.People;

namespace Basis_W_App.Applications.Controls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private clsApplication_B ObjBasisApp;

        /// <summary>
        /// _ApplicationID 
        /// </summary>
        private int AppID_;
        public int AppID
            { get { return AppID_; } }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void FillAppInfo()
        {

            AppID_ = ObjBasisApp.AppID;
            lbl_ApplicationID.Text = ObjBasisApp.AppID.ToString();
            lbl_Status.Text = ObjBasisApp.StatusText;
            lbl_Type.Text = ObjBasisApp.ObjAppTypeInfo.AppTitle;
            lbl_Fees.Text = ObjBasisApp.PaidFees.ToString();
            lbl_Applicant.Text = ObjBasisApp.ApplicantFullName;
            lbl_Date.Text = clsUtilities_W.DateToShort(ObjBasisApp.AppDate);
            lbl_StatusDate.Text = clsUtilities_W.DateToShort(ObjBasisApp.LastStatusDate);
            lbl_CreatedByUser.Text = ObjBasisApp.ObjCreatedByUserInfo.UserName;

        }

        /////////////////////////////////////////////////////////////////////////////////////

        public void ResetAppInfo()
        {
            AppID_ = -1;

            lbl_ApplicationID.Text = "[????]";
            lbl_Status.Text = "[????]";
            lbl_Type.Text = "[????]";
            lbl_Fees.Text = "[????]";
            lbl_Applicant.Text = "[????]";
            lbl_Date.Text = "[????]";
            lbl_StatusDate.Text = "[????]";
            lbl_CreatedByUser.Text = "[????]";

        }

        /////////////////////////////////////////////////////////////////////////////////////

        public void LoadApplicationInfo(int AppID)
        {
            ObjBasisApp = clsApplication_B.FindBaseApp_B(AppID);
            if (ObjBasisApp == null)
            {
                ResetAppInfo();
                MessageBox.Show("No Application with ApplicationID = " + AppID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                FillAppInfo();
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void ll_ViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(ObjBasisApp.AppID);
            frm.ShowDialog();

            LoadApplicationInfo(AppID);
        }

        /////////////////////////////////////////////////////////////////////////////////////


    }
}
