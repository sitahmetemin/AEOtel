﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerve.Desktop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
