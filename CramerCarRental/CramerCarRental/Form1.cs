using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CramerCarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //There isn't any error proofing done in this.
            //this is just an example of how the program would work
            int days = Convert.ToInt16(txtDays.Text);
            double miles = Convert.ToDouble(txtMiles.Text);
            double total = (days * 20) + (miles * 0.2);
            txtTotal.Text = total.ToString("C");
        }
    }
}
