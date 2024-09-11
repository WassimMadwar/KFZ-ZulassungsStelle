using Basis_W_App.People.Controls;
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
    public partial class frmAddUpdateUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;

        clsUser_B _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        //////////////////////////////////////////////////////////////////

        private void _ResetDefaultValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser_B();
                tp_LoginInfo.Enabled = false;

                ctrPersonCardWithFilterUser.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                tp_LoginInfo.Enabled = true;
                btn_Save.Enabled = true;


            }

            txt_UserName.Text = "";
            txt_Password.Text = "";
            txt_ConfirmPassword.Text = "";
            chk_IsActive.Checked = true;
               

        }

        //////////////////////////////////////////////////////////////////

        private void _LoadData()
        {

            _User = clsUser_B.FindByUserID(_UserID);
            ctrPersonCardWithFilterUser.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lbl_UserID.Text = _User.UserID.ToString();
            txt_UserName.Text = _User.UserName;
            txt_Password.Text = _User.Password;
            txt_ConfirmPassword.Text = _User.Password;
            chk_IsActive.Checked = _User.IsActive;
            ctrPersonCardWithFilterUser.LoadPersonInfo(_User.PersonID);
        }

        //////////////////////////////////////////////////////////////////

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        //////////////////////////////////////////////////////////////////

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fields are not valid !, put the mouse over the red icon(s) to see the ERROR",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = ctrPersonCardWithFilterUser.PersonID;
            _User.UserName = txt_UserName.Text.Trim();
            _User.Password = txt_Password.Text.Trim();
            //_User.Password = clsUtilities_W.ComputeHash(txt_Password.Text.Trim());
            _User.IsActive = chk_IsActive.Checked;

            if (_User.Save())
            {
                lbl_UserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //////////////////////////////////////////////////////////////////

        private void btn_PersonInfoNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btn_Save.Enabled = true;
                tp_LoginInfo.Enabled = true;
                tc_UserInfo.SelectedTab = tc_UserInfo.TabPages["tp_LoginInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrPersonCardWithFilterUser.PersonID != -1)
            {

                if (clsUser_B.isUserExistForPersonID(ctrPersonCardWithFilterUser.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonCardWithFilterUser.FilterFocus();
                }
                else
                {
                    btn_Save.Enabled = true;
                    tp_LoginInfo.Enabled = true;
                    tc_UserInfo.SelectedTab = tc_UserInfo.TabPages["tp_LoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrPersonCardWithFilterUser.FilterFocus();

            }

        }

        //////////////////////////////////////////////////////////////////

        private void txt_UserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_UserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUser_B.isUserExist(txt_UserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txt_UserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txt_UserName, null);
                };
            }
            else
            {
                //incase update 
                if (_User.UserName != txt_UserName.Text.Trim())
                {
                    if (clsUser_B.isUserExist(txt_UserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txt_UserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_UserName, null);
                    };
                }
            }
        }

        //////////////////////////////////////////////////////////////////

        private void txt_Password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Password, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txt_Password, null);
            };
        }

        //////////////////////////////////////////////////////////////////

        private void txt_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txt_ConfirmPassword.Text.Trim() != txt_Password.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txt_ConfirmPassword, null);
            };
        }

        //////////////////////////////////////////////////////////////////

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //////////////////////////////////////////////////////////////////

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrPersonCardWithFilterUser.FilterFocus();
        }

        //////////////////////////////////////////////////////////////////
    }
}
