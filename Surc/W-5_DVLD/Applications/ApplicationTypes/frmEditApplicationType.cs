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

namespace Basis_W_App.Applications.ApplicationTypes
{
    public partial class frmEditApplicationType : Form
    {
        private int _ApplicationTypeID = -1;
        private clsApplicationType_B ApplicationType;


        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID; 
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {

            lbl_AppTypeID.Text = _ApplicationTypeID.ToString();
            ApplicationType = clsApplicationType_B.Find(_ApplicationTypeID);

            if (ApplicationType != null)
            {
                txt_Title.Text = ApplicationType.AppTitle;
                txt_Fees.Text = ApplicationType.AppFees.ToString();
            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Title_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_Title.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Title, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txt_Title, null);
            };
        }

        private void txt_Fees_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_Fees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Fees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_Fees, null);
            };


            if (!clsValidation_W.IsNumber(txt_Fees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Fees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txt_Fees, null);
            };
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

             ApplicationType.AppTitle = txt_Title.Text.Trim();
             ApplicationType.AppFees = Convert.ToSingle(txt_Fees.Text.Trim());


            if (ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //
    }
}
