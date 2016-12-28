using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
#region Default Instance

        private static MainMenu defaultInstance;


        public static MainMenu Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new MainMenu();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

#endregion

        private void btndep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw w2 = new Withdraw();
            w2.ShowDialog();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBalance balance = new CheckBalance();
            balance.ShowDialog();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDetails update = new UpdateDetails();
            update.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logs out current user and sends them back to login form
            this.Close();
            Login l1 = new Login();
            l1.Show();
        }

    }
}
