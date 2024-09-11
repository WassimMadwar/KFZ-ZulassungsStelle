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

namespace Basis_W_App.People
{
    public partial class frmListPeople : Form
    {

        private static DataTable _dt_DB_AllPeople = clsPerson_B.GetAllPeople();

        /// <summary>
        /// Give an display only selected columns not all data from DB-Table
        /// </summary>
        private DataTable _dtPeople = _dt_DB_AllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                      "FirstName", "SecondName", "ThirdName", "LastName",
                                                      "GenderCaption", "DateOfBirth", "CountryName",
                                                      "Phone", "Email");

        private void _RefreshPeopleList()//"SecondName", "ThirdName",
        {
            _dt_DB_AllPeople = clsPerson_B.GetAllPeople();
            _dtPeople = _dt_DB_AllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GenderCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgv_People.DataSource = _dtPeople;
            lbl_RecordsCount.Text = dgv_People.Rows.Count.ToString();
        }

        public frmListPeople()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////

        private void cb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_FilterValue.Visible = (cb_FilterBy.Text != "None");

            if (txt_FilterValue.Visible)
            {
                txt_FilterValue.Text = "";
                txt_FilterValue.Focus();
            }

        }

        ////////////////////////////////////////////////////////////////////////

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgv_People.DataSource = _dtPeople;
            cb_FilterBy.SelectedIndex = 0;
            lbl_RecordsCount.Text = _dtPeople.Rows.Count.ToString();
            if (dgv_People.Rows.Count > 0) 
            {
                dgv_People.Columns[0].HeaderText = "Person ID";
                dgv_People.Columns[0].Width = 110;

                dgv_People.Columns[1].HeaderText = "Nationality No.";
                dgv_People.Columns[1].Width = 120;


                dgv_People.Columns[2].HeaderText = "First Name";
                dgv_People.Columns[2].Width = 120;

                dgv_People.Columns[3].HeaderText = "Second Name";
                dgv_People.Columns[3].Width = 140;


                dgv_People.Columns[4].HeaderText = "Third Name";
                dgv_People.Columns[4].Width = 120;

                dgv_People.Columns[5].HeaderText = "Last Name";
                dgv_People.Columns[5].Width = 120;

                dgv_People.Columns[6].HeaderText = "Gender";
                dgv_People.Columns[6].Width = 120;

                dgv_People.Columns[7].HeaderText = "Date Of Birth";
                dgv_People.Columns[7].Width = 140;

                dgv_People.Columns[8].HeaderText = "Country";
                dgv_People.Columns[8].Width = 120;


                dgv_People.Columns[9].HeaderText = "Phone";
                dgv_People.Columns[9].Width = 120;


                dgv_People.Columns[10].HeaderText = "Email";
                dgv_People.Columns[10].Width = 170;
            }
        }

        ////////////////////////////////////////////////////////////////////////

        private void txt_FilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";// to DB

            switch (cb_FilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID"; 
                    break;

                case "National No.":
                    FilterColumn = "NationalNo"; 
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gender":
                    FilterColumn = "GenderCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;


            }

            if (txt_FilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbl_RecordsCount.Text = dgv_People.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
            {  //in this case we deal with integer not string.
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txt_FilterValue.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txt_FilterValue.Text.Trim());
            }



            lbl_RecordsCount.Text = dgv_People.Rows.Count.ToString();
        }

        ////////////////////////////////////////////////////////////////////////

        private void txt_FilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_FilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        ////////////////////////////////////////////////////////////////////////

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgv_People.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////////

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgv_People.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            
            _RefreshPeopleList();

        }

        ////////////////////////////////////////////////////////////////////////

        private void AddPersonStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            _RefreshPeopleList();
        }

        ////////////////////////////////////////////////////////////////////////

        private void dgv_People_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgv_People.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////////

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        ////////////////////////////////////////////////////////////////////////

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAddUpdatePerson();
            frm1.ShowDialog();
            _RefreshPeopleList();
        }

        ////////////////////////////////////////////////////////////////////////

        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Person [" + dgv_People.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Perform Delete and refresh
                if (clsPerson_B.DeletePerson((int)dgv_People.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        ////////////////////////////////////////////////////////////////////////

        private void PhoneCallStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        ////////////////////////////////////////////////////////////////////////

        private void SendEmailStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        ////////////////////////////////////////////////////////////////////////
        
    }
}
