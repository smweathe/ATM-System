using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace atmsystem
{
    public partial class CheckBalance : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public CheckBalance()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];

            string connectionString = conSettings.ConnectionString;
            con = new SqlConnection(connectionString);
            con.Open();
            
            cmd = new SqlCommand("SELECT balance FROM users", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtbal.Text = (dr["balance"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainMenu.Default.Show();
            this.Hide();
        }
    }
}
