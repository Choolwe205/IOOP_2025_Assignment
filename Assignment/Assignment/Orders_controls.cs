﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Orders_controls : UserControl
    {
        int quantity;

        public Orders_controls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantity += 1;
            button1.Text = "Add   " + quantity.ToString(); 

        }
    }
}
