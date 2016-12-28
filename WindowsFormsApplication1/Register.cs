using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace atmsystem
{
    public partial class Register : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public Register()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            //Registers new user
            //All txt boxes empty
            if (pinTxtBox.Text == "" && nameTxtBox.Text == "" && phoneTxtBox.Text == "" && emailTxtBox.Text == "")
            {
                MessageBox.Show("You have not entered any data.");
            }
            //1 or more txt boxes empty
            else if (pinTxtBox.Text == "" || nameTxtBox.Text == "" || phoneTxtBox.Text == "" || emailTxtBox.Text == "")
            {
                MessageBox.Show("Please fill all fields to register.");
            }
            else
            {
                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];

                string connectionString = conSettings.ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("INSERT INTO users (pin, name, phone, email) values(@pin, @name, @phone, @email)", con);
                cmd.Parameters.AddWithValue("@pin", pinTxtBox.Text);
                cmd.Parameters.AddWithValue("@name", nameTxtBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTxtBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTxtBox.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MainMenu.Default.Show();
                this.Hide();
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }


    }
}   