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
        public static List<Driver> driverList = new List<Driver>();
        
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

        public void frmInsuranceRefresh()
        {
            if (driverList.Count() >= 1)
            {
                btnEditDriver1.Text = driverList[0].FullName + " - " + driverList[0].NumberOfClaims + " claims";
            }
            if (driverList.Count() >= 2)
            {
                btnEditDriver1.Text = driverList[1].FullName + " - " + driverList[1].NumberOfClaims + " claims";
            }
        }


    }
}
