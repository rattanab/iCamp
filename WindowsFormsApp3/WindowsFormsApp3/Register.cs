﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home H = new Home();
            H.Show();
        }

        private void RegisterSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
