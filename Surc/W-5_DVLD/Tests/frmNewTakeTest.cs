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
using W_Business_.Test_B;

namespace Basis_W_App.Tests
{
    public partial class frmNewTakeTest : Form
    {
        private int TestAppointmentID_;
        private clsTestType_B.enTestTypeID TestTypeID_;

        private int TestID_ = -1;
        private clsTest ObjTest;

        public frmNewTakeTest(int AppointmentID, clsTestType_B.enTestTypeID TestTypeID)
        {
            InitializeComponent();
            TestAppointmentID_ = AppointmentID;
            TestTypeID_ = TestTypeID;

        }

        private void frmNewTakeTest_Load(object sender, EventArgs e)
        {
            ctrTakeTest1.TestTypeID = TestTypeID_;
            ctrTakeTest1.LoadInfo(TestAppointmentID_);

            if (ctrTakeTest1.TestAppointmentID == -1)
            {
                btn_Save.Enabled = false;
            }
            else
            {
                btn_Save.Enabled = true;
            }

            int _TestID = ctrTakeTest1.TestID;
            if (_TestID != -1) 
            {
                ObjTest = clsTest.Find(_TestID);

                if (ObjTest.TestResult)
                {
                    rb_Pass.Checked = true;
                    txt_Notes.Text = ObjTest.Notes;

                }
                else
                {
                    rb_Fail.Checked = true;
                    txt_Notes.Text = ObjTest.Notes;
                }
                lbl_UserMessage.Visible = true;
                rb_Fail.Enabled = false;
                rb_Pass.Enabled = false;
                txt_Notes.Enabled = false;
                btn_Save.Enabled = false;

            }
            else
            {
                ObjTest = new clsTest();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            ObjTest.TestAppointmentID = TestAppointmentID_;
            ObjTest.TestResult = rb_Pass.Checked;
            ObjTest.Notes = txt_Notes.Text.Trim();
            ObjTest.CreatedByUserID = clsLogIn_W.CurrentUser.UserID;

            if (ObjTest.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Save.Enabled = false;    

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
