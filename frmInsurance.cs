using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorInsuranceCalculationProgram
{
    public partial class frmInsurance : Form
    {
        DateTime startDate;
        int youngestDriverAge;
        int claimsWithin1Year;
        int claimsOutside1Year;
        List<Driver> driver = new List<Driver>();

        public frmInsurance()
        {
            InitializeComponent();
        }

        private void frmInsurance_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            frmDriver DriverForm = new frmDriver();
            DriverForm.Show();
        }

        private void btnCalculatePremium_Click(object sender, EventArgs e)
        {

        }
    }
}
