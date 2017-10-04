using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeSessionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register R = new Register();
            R.Show();

        }

        private void HomeExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void HomeRegisterActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpSheet S = new SignUpSheet();
            S.Show();
        }

        private void HomeActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            Activity A = new Activity();
            A.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn();
            L.Show();

        }
    }
}
