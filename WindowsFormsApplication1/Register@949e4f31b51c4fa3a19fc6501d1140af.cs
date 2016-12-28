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


namespace atmsystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ATM;Data Source=STEVE-PC");
            try
            {
                con.Open();
                statusLbl.Text = "Connection Successful";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Insert into TestTable values ('" + pinTxtBox.Text + "', '" + firstnameTxtBox.Text + "' , '" + lastnameTxtBox.Text + "','" + phoneTxtBox.Text + "','" + emailTxtBox.Text + "');";

                try
                {
                    cmd.ExecuteNonQuery();
                    statusLbl.Text = "Added";
                }
                catch (Exception)
                {
                    statusLbl.Text = "Error";
                }
            }
            catch (Exception)
            {
                statusLbl.Text = "Connection failed";
            }
        }
    }
}