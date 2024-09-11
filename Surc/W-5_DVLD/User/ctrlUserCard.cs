using Basis_W_App.People.Controls;
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
    public partial class ctrUserCard : UserControl
    {
        private clsUser_B _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public ctrUserCard()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser_B.FindByUserID(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        //////////////////////////////////////////////////////////////////

        private void _FillUserInfo()
        {

            ctrPersonCard1.LoadPersonInfo(_User.PersonID);
            lbl_UserID.Text = _User.UserID.ToString();
            lbl_UserName.Text = _User.UserName.ToString();

            if (_User.IsActive)
                lbl_IsActive.Text = "Yes";
            else
                lbl_IsActive.Text = "No";

        }

        //////////////////////////////////////////////////////////////////

        private void _ResetPersonInfo()
        {

            ctrPersonCard1.ResetPersonInfo();
            lbl_UserID.Text = "[???]";
            lbl_UserName.Text = "[???]";
            lbl_IsActive.Text = "[???]";
        }

        //////////////////////////////////////////////////////////////////


    }
}
