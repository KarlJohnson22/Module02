using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double miMultiplier = 1.60934;
        double kmMultiplier = 0.621371;
        double answer;

        private void btnMItoKM_Click(object sender, EventArgs e)
        {
            double miles = Convert.ToDouble(txtMiles.Text);
            double kilometers = miles * 1.60934;
            txtKM.Text = Convert.ToString(kilometers);
        }

        private void btnKMtoMI_Click(object sender, EventArgs e)
        {
            double kilometers = Convert.ToDouble(txtKM.Text);
            double miles = kilometers * 0.621371;
            txtMiles.Text = Convert.ToString(miles);
        }
    }
}
