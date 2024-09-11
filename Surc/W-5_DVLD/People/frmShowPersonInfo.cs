using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basis_W_App.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrPersonCard1.LoadPersonInfo(PersonID);
        }

        public frmShowPersonInfo(string NationalityNo)
        {
            InitializeComponent();
            ctrPersonCard1.LoadPersonInfo(NationalityNo);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
