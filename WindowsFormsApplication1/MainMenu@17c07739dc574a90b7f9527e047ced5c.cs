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

    }
}
