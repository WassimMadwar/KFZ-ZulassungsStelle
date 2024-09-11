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

namespace Basis_W_App.People
{
    public partial class frmFindPerson : Form
    {
        public delegate void DataBackEventHandler(object MySender, int PersonID);
        public event DataBackEventHandler DataBack;


        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, ctrPersonCardWithFilter1.PersonID);
        }
    }
}
