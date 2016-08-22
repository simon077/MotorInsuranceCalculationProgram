using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace MotorInsuranceCalculationProgram
{
    public partial class frmDriver : Form
    {
        Boolean saveClicked;
        Boolean editState, addState;
        int numberOfClaims = 0;
        List<DateTime> claimDate = new List<DateTime>();

        public frmDriver()
        {
            InitializeComponent();
        }
        public frmDriver(Boolean editState, Boolean addState)
        {
            this.editState = editState;
            this.addState = addState;
        }

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYes.Checked == true)
            {
                chkNo.Checked = false;
                btnAddClaim.Show();
            }
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked == true)
            {
                chkYes.Checked = false;
            }
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            if (numberOfClaims < 5)
            {
                numberOfClaims++;
                if (numberOfClaims == 1) lblDateOfClaims.Show();
                pnlClaimDetails.Controls["dtpClaim" + numberOfClaims].Show();

            }
            else
                MessageBox.Show("You can not add more than 5 claims per driver", "Error!");
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveClicked = true;
            if (addState == true)
            {
                // Save claims to List
                if (numberOfClaims >= 1) claimDate.Add(dtpClaim1.Value);
                if (numberOfClaims >= 2) claimDate.Add(dtpClaim2.Value);
                if (numberOfClaims >= 3) claimDate.Add(dtpClaim3.Value);
                if (numberOfClaims >= 4) claimDate.Add(dtpClaim4.Value);
                if (numberOfClaims >= 5) claimDate.Add(dtpClaim5.Value);

                // Add driver then add it to the driverList on frmInsurance
                Driver driver = new Driver(txtFullName.Text, dtpDateOfBirth.Value, cboOccupation.Text, numberOfClaims, claimDate);
                frmInsurance.driverList.Add(driver);

                // Checking to see dates are being stored
                for (int a = 0; a < numberOfClaims; a++)
                {
                    MessageBox.Show(driver.ClaimDate[a] + "  ");
                }
                MessageBox.Show(driver.FullName + " " + driver.Occupation);
                frmInsuranceRefresh();

                
            }
        }
   
    }
}
