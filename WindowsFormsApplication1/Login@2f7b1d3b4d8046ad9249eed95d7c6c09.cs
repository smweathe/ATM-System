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


namespace atmsystem
{
    public partial class Login : Form
    {
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=STEVE-PC;Initial Catalog=atm;Integrated Security=True";

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from users where pin = '" + pin_txt.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Ok");
            }
            else if (count > 0)
            {
                MessageBox.Show("Invalid PIN");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}