using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program Name: MoveEstimator
//Author: James Shoemaker
//Date written: April 23, 2019
//Purpose: Week 3 Assignment


namespace MoveEstimator
{
    public partial class MoveEstimator : Form
    {
        public MoveEstimator()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double hours = double.Parse(txtHrs.Text);
            double miles = double.Parse(txtMls.Text);

            //Calculate total
            double total = 200 + (150 * hours) + (2 * miles);

            lblDisplay.Text = "For a move taking " +  hours  +  " hours and going "  +  miles  + " miles...";

            lblMessage.Text = "The total is: " + total.ToString("C");


        }
    }
}
