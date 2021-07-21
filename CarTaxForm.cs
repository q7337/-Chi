using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTaxForm
{
    public partial class CarTaxForm : Form
    {
        public CarTaxForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            bool isLeapYear = (DateTime.IsLeapYear(DateTime.Now.Year) == true);
        }

       

    }
}
