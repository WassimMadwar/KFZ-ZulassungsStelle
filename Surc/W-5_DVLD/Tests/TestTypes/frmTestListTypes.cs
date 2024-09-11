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
    public partial class frmTestListTypes : Form
    {
        private DataTable _dtAllTestTypes;
        
        public frmTestListTypes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// But it is not like _RefreshPeopleList 
        /// </summary>
        private void _RefreshList()
        {
            _dtAllTestTypes = clsTestType_B.GetAllTestTypes();
            dgv_TestTypes.DataSource = _dtAllTestTypes;

            lbl_RecordsCount.Text = dgv_TestTypes.Rows.Count.ToString();

            if (dgv_TestTypes.Rows.Count > 0)
            {
                dgv_TestTypes.Columns[0].HeaderText = "TypeID";
                dgv_TestTypes.Columns[0].Width = 120;

                dgv_TestTypes.Columns[1].HeaderText = "Title";
                dgv_TestTypes.Columns[1].Width = 200;

                dgv_TestTypes.Columns[2].HeaderText = "Description";
                dgv_TestTypes.Columns[2].Width = 400;

                dgv_TestTypes.Columns[3].HeaderText = "Fees Money";
                dgv_TestTypes.Columns[3].Width = 120;
            }
        }

        /// ////////////////////////////////////////////////////////////////
        
        private void frmTestListTypes_Load(object sender, EventArgs e)
        {
            /*_dtAllTestTypes = clsTestType.GetAllTestTypes();
            dgv_TestTypes.DataSource = _dtAllTestTypes;

            lbl_RecordsCount.Text = dgv_TestTypes.Rows.Count.ToString();

            if (dgv_TestTypes.Rows.Count > 0)
            {
                dgv_TestTypes.Columns[0].HeaderText = "TypeID";
                dgv_TestTypes.Columns[0].Width = 120;

                dgv_TestTypes.Columns[1].HeaderText = "Title";
                dgv_TestTypes.Columns[1].Width = 200;

                dgv_TestTypes.Columns[2].HeaderText = "Description";
                dgv_TestTypes.Columns[2].Width = 400;

                dgv_TestTypes.Columns[3].HeaderText = "Fees";
                dgv_TestTypes.Columns[3].Width = 120;
            }*/
            _RefreshList();
        }

        /// ////////////////////////////////////////////////////////////////

        private void EditStripMenu_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((clsTestType_B.enTestTypeID)dgv_TestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshList();
        }

        /// ////////////////////////////////////////////////////////////////

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// ////////////////////////////////////////////////////////////////

    }
}
