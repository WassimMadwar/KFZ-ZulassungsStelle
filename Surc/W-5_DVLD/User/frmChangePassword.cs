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
using W_Business_;

namespace Basis_W_App.User
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;

        private clsUser_B _User;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void _ResetDefaultValues()
        {
            txt_CurrentPassword.Text = "";
            txt_NewPassword.Text = "";
            txt_ConfirmPassword.Text = "";
            txt_CurrentPassword.Focus();
        }      




        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = clsUser_B.FindByUserID(_UserID);

            if (_User == null)
            {
                //Heir we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            ctrUserCard1.LoadUserInfo(_UserID);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_CurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_CurrentPassword, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_CurrentPassword, null);
            };

            if (_User.Password != txt_CurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_CurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_CurrentPassword, null);
            };
        }

        private void txt_NewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_NewPassword, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txt_NewPassword, null);
            };
        }

        private void txt_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txt_ConfirmPassword.Text.Trim() != txt_NewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txt_ConfirmPassword, null);
            };
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hier =====================================================================
            _User.Password = txt_NewPassword.Text;
            //_User.Password = clsUtilities_W.ComputeHash(txt_NewPassword.Text);

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("An Error Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
