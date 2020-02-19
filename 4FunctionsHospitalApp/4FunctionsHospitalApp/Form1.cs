using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4FunctionsHospitalApp
{
    public partial class HospitalLocator : Form
    {
        public HospitalLocator()
        {
            InitializeComponent();
        }

        private void HospitalLocator_Load(object sender, EventArgs e)
        {

        }

        private void txtCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("Hospital.csv"))
            {

            }
        }
    }
}
