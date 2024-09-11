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
    public partial class frmBookingTest : Form
    {
        private int TestAppointmentID_ ;
        private int LocalLicenseAppID_ = -1;
        private clsTestType_B.enTestTypeID TestTypeID_ = clsTestType_B.enTestTypeID.VisionTest;

        public frmBookingTest(int LocalLicenseAppID, clsTestType_B.enTestTypeID TestTypeID, int TestAppointmentID = -1)
        {
            InitializeComponent();
            TestAppointmentID_ = TestAppointmentID;
            LocalLicenseAppID_ = LocalLicenseAppID;
            TestTypeID_ = TestTypeID;
        }

        private void frmBookingTest_Load(object sender, EventArgs e)
        {
            ctrScheduleTest1.TestTypeID = TestTypeID_;
            ctrScheduleTest1.LoadInfo(LocalLicenseAppID_, TestAppointmentID_);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
