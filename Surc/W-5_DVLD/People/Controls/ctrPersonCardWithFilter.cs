using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W_Business_;



namespace Basis_W_App.People.Controls
{
    public partial class ctrPersonCardWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;
        
       
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btn_AddNewPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gb_Filters.Enabled = _FilterEnabled;
            }
        }
        
       
        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrPersonCard1.PersonID; }
        }

        //TO DELETE
        // 29/6 DELETED
   /*     public clsPerson_B SelectedPersonInfo
        {
            get { return ctrPersonCard1.SelectedPersonInfo; }
        }*/

        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////

        //TO DELETE
        // 29/6 DELETED
        /*protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }*/

        ////////////////////////////////////////////////////////////////////

        public void LoadPersonInfo(int PersonID)
        {
            cb_FilterBy.SelectedIndex = 2;
            txt_FilterValue.Text = PersonID.ToString();

            FindNow();
        }

        ////////////////////////////////////////////////////////////////////

        private void FindNow()
        {

            switch (cb_FilterBy.Text)
            {
                case "Person ID":
                    {
                        ctrPersonCard1.LoadPersonInfo(int.Parse(txt_FilterValue.Text));
                        break;
                    }
                case "National No.":
                    {
                        ctrPersonCard1.LoadPersonInfo((txt_FilterValue.Text));
                        break;
                    }

                default: break;

            }

            if (OnPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnPersonSelected(ctrPersonCard1.PersonID);
        }

        ////////////////////////////////////////////////////////////////////

        private void ctrPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cb_FilterBy.SelectedIndex = 0;
            //txt_FilterValue.Focus();
            cb_FilterBy.Focus();
        }

        ////////////////////////////////////////////////////////////////////

        private void DataArrival(object MySender, int PersonID)
        {
            // Handle the data received

            cb_FilterBy.SelectedIndex = 1;
            txt_FilterValue.Text = PersonID.ToString();
            ctrPersonCard1.LoadPersonInfo(PersonID);
        }

        ////////////////////////////////////////////////////////////////////

        //TO DELETE
        public void FilterFocus()
        {
            txt_FilterValue.Focus();
        }

        ////////////////////////////////////////////////////////////////////

        private void cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_FilterValue.Visible = (cb_FilterBy.Text != "None");

            if (txt_FilterValue.Visible)
            {
                txt_FilterValue.Text = "";
                //txt_FilterValue.Focus(); changed at 30/6  to 
                FilterFocus();
            }
        }

        ////////////////////////////////////////////////////////////////////

        private void btn_FindPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        ////////////////////////////////////////////////////////////////////

        private void txt_FilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_FilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_FilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txt_FilterValue, null);
            }
        }

        ////////////////////////////////////////////////////////////////////

        private void btn_AddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAdd = new frmAddUpdatePerson();
            frmAdd.DataBack += DataArrival;
            frmAdd.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////

        private void txt_FilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btn_FindPerson.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cb_FilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        ////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////
    }



}
