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
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActivityDetailsOutsideActivityChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void ActivityDetailsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home H = new Home();
            H.Show();

        }

        private void ActivityDetailsGenerate_Click(object sender, EventArgs e)
        {
            foreach (string s in ActivityDetailsOutsideActivityChecklist.CheckedItems)
            {
                ActivityDetailsListBox.Items.Add(s);
            }
            foreach (string s in ActivityDetailsIndoorActivityChecklist.CheckedItems)
            {
                ActivityDetailsListBox.Items.Add(s);
            }
        }

        private void Activity_Load(object sender, EventArgs e)
        {
          
        }
    }
}
