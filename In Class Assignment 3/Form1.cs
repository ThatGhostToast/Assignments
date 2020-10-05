using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClassAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Define variables
            //Input value for weight on Earth
            decimal earthWeight = 0;
            decimal earthMass = 0;
            decimal gravAccEarth = Convert.ToDecimal(9.81);
            decimal gravAccMars = Convert.ToDecimal(3.71);
            //Read in the Earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            //Find mass on earth
            earthMass = earthWeight * gravAccEarth;
            //Find weight on mars
            txtMarsWeight.Text = ((earthMass * gravAccMars)/100).ToString();

        }
    }
}
