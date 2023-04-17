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
    public partial class frmRNS : Form
    {
        public string username;
        public frmRNS(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand cmd = new SqlCommand("insert into Staff " +
                "set Firstname = '" + txtFName.Text +
            "', Lastname ='" + txtLName.Text +
            "',Username ='" + txtUsername.Text +
            "',Email ='" + txtEAddress.Text +
            "',Password ='" + txtPW.Text +
            "',Phone ='" + txtPN.Text +
            "',Postal ='" + txtPC.Text +
            "',City ='" + txtC.Text +
            "',State ='" + txtState.Text +
            "',Country ='" + txtCountry.Text +
            "',Address ='" + txtAddress.Text +
            "',Gender ='" + ccbGender.Text +
            "'Role ='" + ccbRole.Text +
            "'DOB ='" + dtpDOB.Text +
            // change format!! update -> insert



            "'where Username = '" + username + ";" +
            "INSERT INTO Users (Username, Password, Role) " +
            "VALUES('" + txtUsername.Text +
                    "','" + txtPW.Text +
                    "','"+ ccbRole.Text + "'", con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully";
            else
                status = "Fail";
            con.Close();
            MessageBox.Show(status, "Information:");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
