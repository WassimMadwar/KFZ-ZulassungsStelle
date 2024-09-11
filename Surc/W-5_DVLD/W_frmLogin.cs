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

namespace Basis_W_App
{
    public partial class W_frmLogin : Form
    {
        public W_frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void W_frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsLogIn_W.GetStoredCredential(ref UserName, ref Password))
            {
                txt_UserName.Text = UserName;
                txt_Password.Text = Password;
                chk_RememberMe.Checked = true;
            }
            else
                chk_RememberMe.Checked = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            clsUser_B user = clsUser_B.FindByUsernameAndPassword(txt_UserName.Text.Trim(), txt_Password.Text.Trim());

            if (user != null)
            {

                if (chk_RememberMe.Checked)
                {
                    //store username and password
                    clsLogIn_W.RememberUsernameAndPassword(txt_UserName.Text.Trim(), txt_Password.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsLogIn_W.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txt_UserName.Focus();
                    MessageBox.Show("Your account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsLogIn_W.CurrentUser = user;
                this.Hide();
                Main frm = new Main(this);
                frm.ShowDialog();


            }
            else
            {
                txt_UserName.Focus();
                MessageBox.Show("Invalid W Username or Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
