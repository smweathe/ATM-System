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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r2 = new Register();
            r2.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];

            string connectionString = conSettings.ConnectionString;

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("select * from users where pin = '" + pin_txt.Text.ToString() + "'", con);
                dr = cmd.ExecuteReader();

                int count = 0;

                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    //successful login
                    //send to main menu
                    this.Hide();
                    MainMenu.Default.Show();
                }
                else if (count > 0)
                {
                    MessageBox.Show("invalid pin");
                }
                else
                {
                    MessageBox.Show("login failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}