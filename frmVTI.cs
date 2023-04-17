using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_G29_2._0
{
    public partial class frmVTI : Form
    {
        public frmVTI()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SUM (Amount) from Orders where Month(CollectionDate)= '" + ccbMonth.Text + "'", con);
            string totalIncome = cmd.ExecuteScalar().ToString();
            txtTotalIncome.Text = totalIncome;
            con.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVTI_Load(object sender, EventArgs e)
        {

        }

        private void ccbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
