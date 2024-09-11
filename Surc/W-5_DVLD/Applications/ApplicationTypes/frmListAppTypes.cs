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
using W_Business_.ApplicationType_B_W;

namespace Basis_W_App.Applications.ApplicationTypes
{
    public partial class frmListAppTypes : Form
    {
        private DataTable _dtAllApplicationTypes;

        public frmListAppTypes()
        {
            InitializeComponent();
        }

        private void frmListAppTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationType_B.GetAllAppTypes();
            dgv_AppTypes.DataSource = _dtAllApplicationTypes;
            lbl_RecordsCount.Text = dgv_AppTypes.Rows.Count.ToString();
            
            if (dgv_AppTypes.Rows.Count > 0) 
            {
                dgv_AppTypes.Columns[0].HeaderText = "ID";
                dgv_AppTypes.Columns[0].Width = 110;

                dgv_AppTypes.Columns[1].HeaderText = "Title";
                dgv_AppTypes.Columns[1].Width = 400;
                
                dgv_AppTypes.Columns[2].HeaderText = "Fees";
                dgv_AppTypes.Columns[2].Width = 100;
            }
        }

        private void EditStripMenu_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType((int)dgv_AppTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListAppTypes_Load(null, null);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
