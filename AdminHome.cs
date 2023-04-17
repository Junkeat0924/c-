using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_G29_2._0
{
    public partial class AdminHome : Form
    {
        public string username;
        public AdminHome(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void btnRNS_Click(object sender, EventArgs e)
        {
            frmRNS frmRNS = new frmRNS(username);
            frmRNS.ShowDialog();
        }

        private void btnVSR_Click(object sender, EventArgs e)
        {
            frmVSR frmVSR = new frmVSR();
            frmVSR.ShowDialog();
        }

        private void btnVTI_Click(object sender, EventArgs e)
        {
            frmVTI frmVTI = new frmVTI();
            frmVTI.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
