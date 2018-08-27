using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarenheitToCelsius
{
    public partial class DegreeCalculator : Form
    {
        public DegreeCalculator()
        {
            InitializeComponent();
        }

        

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            double degreeF = int.Parse(fahrenheit.Text);
            celsius.Text =  Convert.ToString((degreeF - 32) * ( 5.0 / 9.0));
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            double degreeC = int.Parse(celsius.Text);
            fahrenheit.Text = Convert.ToString((degreeC * 1.8) + 32);
        }
    }
}
