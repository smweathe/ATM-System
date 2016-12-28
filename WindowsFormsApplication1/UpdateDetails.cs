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
    public partial class UpdateDetails : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        public UpdateDetails()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Registers new user
            //All txt boxes empty
            if (pinTxtBox.Text == "" && nameTxtBox.Text == "" && phoneTxtBox.Text == "" && emailTxtBox.Text == "")
            {
                MessageBox.Show("You have not entered any data");
            }
            //1 or more txt boxes empty
            else if (pinTxtBox.Text == "" || nameTxtBox.Text == "" || phoneTxtBox.Text == "" || emailTxtBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];

                string connectionString = conSettings.ConnectionString;
                con = new SqlConnection(connectionString);

                cmd = new SqlCommand("UPDATE [users] (pin, name, phone, email) values(@pin, @name, @phone, @email", con);
                cmd.Parameters.AddWithValue("@pin", pinTxtBox.Text);
                cmd.Parameters.AddWithValue("@name", nameTxtBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTxtBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTxtBox.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MainMenu.Default.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainMenu.Default.Show();
            this.Hide();
        }
    }
}
