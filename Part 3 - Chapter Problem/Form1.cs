﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Chapter_Problem
{
    public partial class BasicInput : Form
    {
        public BasicInput()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //Button click event
            string Name = txtName.Text;
            double age = Convert.ToDouble(numup1.Text);
            double hight = Convert.ToDouble(txtHight.Text);
            lblOutput.Text = ($"Hello {Name} you are {age} years old and you are {hight} meters tall.");

        }

       
    }
}
