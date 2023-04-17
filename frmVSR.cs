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
    public partial class frmVSR : Form
    {
        public frmVSR()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand cmd = new SqlCommand("select Description from Orders where MONTH(CollectionDate)= '"+  comboBox1.Text  +"'", con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sReport = dr.GetString("Description");
                    lbViewIn.Items.Add(sReport);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
