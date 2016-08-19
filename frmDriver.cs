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
        Boolean editState;
        int numberOfClaims = 0;
        List<DateTime> claimDate = new List<DateTime>();

        public frmDriver()
        {
            InitializeComponent();
        }
        public frmDriver(Boolean editState)
        {
            this.editState = editState;
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
            if (editState == false)
            {
                for(int a = 1; a<=numberOfClaims; a++)
                {
                    
                }
            }


        }
    }
}
