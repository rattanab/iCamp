using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
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

        private void Home_Load(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password='';database=icamp";

            MySqlConnection conn = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new SqlConnection(cs);
                conn.Open();

                String cmdText = "SELECT SessionName FROM camp_session"; // sql command as string
                SqlCommand cmd = new SqlCommand(cmdText, conn); // set the command to the connection
                reader = cmd.ExecuteReader(); // excute and get into the datareader
                //cmd.ExecuteNonQuery(); Execute with no query
                while (reader.Read())
                {
                    HomeSessionBox.Items.Add(reader.GetString(1)); // get the information as a string at the column index 0
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally // what to do after try/catch is done
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
