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

namespace Basis_W_App.Tests.TestTypes
{
    public partial class frmEditTestType : Form
    {
  
        private clsTestType_B.enTestTypeID _TestTypeID = clsTestType_B.enTestTypeID.VisionTest;
        private clsTestType_B _TestType;

        public frmEditTestType(clsTestType_B.enTestTypeID TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;

        }


        /// ////////////////////////////////////////////////////////////////

        private void frmEditTestType_Load(object sender, EventArgs e)
        {

            _TestType = clsTestType_B.Find(_TestTypeID);

            if (_TestType != null)
            {


                lbl_TestTypeID.Text = ((int)_TestTypeID).ToString();
                txt_Title.Text = _TestType.Title;
                txt_Description.Text = _TestType.Description;
                txt_Fees.Text = _TestType.Fees.ToString();
            }

            else
            {
                MessageBox.Show("Could not find Test Type with id = " + _TestTypeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        /// ////////////////////////////////////////////////////////////////

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _TestType.Title = txt_Title.Text.Trim();
            _TestType.Description = txt_Description.Text.Trim();
            _TestType.Fees = Convert.ToSingle(txt_Fees.Text.Trim());


            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// ////////////////////////////////////////////////////////////////

        private void txt_Title_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Title.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Title, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txt_Title, null);
            };
        }

        /// ////////////////////////////////////////////////////////////////

        private void txt_Description_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Description.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Description, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txt_Description, null);
            };
        }

        /// ////////////////////////////////////////////////////////////////

        private void txt_Fees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Fees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Fees, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txt_Fees, null);
            };
        }

        /// ////////////////////////////////////////////////////////////////

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// ////////////////////////////////////////////////////////////////

    }
}
