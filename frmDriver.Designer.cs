namespace MotorInsuranceCalculationProgram
{
    partial class frmDriver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDriverFullName = new System.Windows.Forms.Label();
            this.lblDriverOccupation = new System.Windows.Forms.Label();
            this.lblDriverDetails = new System.Windows.Forms.Label();
            this.lblDriverClaims = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cboOccupation = new System.Windows.Forms.ComboBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.pnlClaimDetails = new System.Windows.Forms.Panel();
            this.dtpClaim1 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteClaim1 = new System.Windows.Forms.Button();
            this.btnDeleteClaim2 = new System.Windows.Forms.Button();
            this.btnDeleteClaim3 = new System.Windows.Forms.Button();
            this.btnDeleteClaim4 = new System.Windows.Forms.Button();
            this.btnDeleteClaim5 = new System.Windows.Forms.Button();
            this.dtpClaim2 = new System.Windows.Forms.DateTimePicker();
            this.dtpClaim3 = new System.Windows.Forms.DateTimePicker();
            this.dtpClaim4 = new System.Windows.Forms.DateTimePicker();
            this.dtpClaim5 = new System.Windows.Forms.DateTimePicker();
            this.btnAddClaim = new System.Windows.Forms.Button();
            this.lblDateOfClaims = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.pnlClaimDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDriverFullName
            // 
            this.lblDriverFullName.AutoSize = true;
            this.lblDriverFullName.Location = new System.Drawing.Point(11, 43);
            this.lblDriverFullName.Name = "lblDriverFullName";
            this.lblDriverFullName.Size = new System.Drawing.Size(84, 20);
            this.lblDriverFullName.TabIndex = 0;
            this.lblDriverFullName.Text = "Full Name:";
            // 
            // lblDriverOccupation
            // 
            this.lblDriverOccupation.AutoSize = true;
            this.lblDriverOccupation.Location = new System.Drawing.Point(11, 104);
            this.lblDriverOccupation.Name = "lblDriverOccupation";
            this.lblDriverOccupation.Size = new System.Drawing.Size(94, 20);
            this.lblDriverOccupation.TabIndex = 1;
            this.lblDriverOccupation.Text = "Occupation:";
            // 
            // lblDriverDetails
            // 
            this.lblDriverDetails.AutoSize = true;
            this.lblDriverDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDriverDetails.Location = new System.Drawing.Point(11, 13);
            this.lblDriverDetails.Name = "lblDriverDetails";
            this.lblDriverDetails.Size = new System.Drawing.Size(117, 20);
            this.lblDriverDetails.TabIndex = 2;
            this.lblDriverDetails.Text = "Driver Details";
            // 
            // lblDriverClaims
            // 
            this.lblDriverClaims.AutoSize = true;
            this.lblDriverClaims.Location = new System.Drawing.Point(11, 153);
            this.lblDriverClaims.Name = "lblDriverClaims";
            this.lblDriverClaims.Size = new System.Drawing.Size(394, 20);
            this.lblDriverClaims.TabIndex = 3;
            this.lblDriverClaims.Text = "Has this driver made any claims within the last 5 years?";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(130, 40);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(144, 26);
            this.txtFullName.TabIndex = 4;
            // 
            // cboOccupation
            // 
            this.cboOccupation.FormattingEnabled = true;
            this.cboOccupation.Items.AddRange(new object[] {
            "Chauffeur",
            "Accountant"});
            this.cboOccupation.Location = new System.Drawing.Point(130, 100);
            this.cboOccupation.Name = "cboOccupation";
            this.cboOccupation.Size = new System.Drawing.Size(144, 28);
            this.cboOccupation.TabIndex = 5;
            // 
            // chkYes
            // 
            this.chkYes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkYes.Location = new System.Drawing.Point(15, 176);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(96, 32);
            this.chkYes.TabIndex = 8;
            this.chkYes.Text = "Yes";
            this.chkYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNo.Location = new System.Drawing.Point(125, 176);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(96, 32);
            this.chkNo.TabIndex = 9;
            this.chkNo.Text = "No";
            this.chkNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
            // 
            // pnlClaimDetails
            // 
            this.pnlClaimDetails.AutoScroll = true;
            this.pnlClaimDetails.Controls.Add(this.lblDateOfClaims);
            this.pnlClaimDetails.Controls.Add(this.dtpClaim5);
            this.pnlClaimDetails.Controls.Add(this.dtpClaim4);
            this.pnlClaimDetails.Controls.Add(this.dtpClaim3);
            this.pnlClaimDetails.Controls.Add(this.dtpClaim2);
            this.pnlClaimDetails.Controls.Add(this.btnDeleteClaim5);
            this.pnlClaimDetails.Controls.Add(this.btnDeleteClaim4);
            this.pnlClaimDetails.Controls.Add(this.btnDeleteClaim3);
            this.pnlClaimDetails.Controls.Add(this.btnDeleteClaim2);
            this.pnlClaimDetails.Controls.Add(this.btnDeleteClaim1);
            this.pnlClaimDetails.Controls.Add(this.dtpClaim1);
            this.pnlClaimDetails.Location = new System.Drawing.Point(15, 252);
            this.pnlClaimDetails.Name = "pnlClaimDetails";
            this.pnlClaimDetails.Size = new System.Drawing.Size(362, 159);
            this.pnlClaimDetails.TabIndex = 10;
            // 
            // dtpClaim1
            // 
            this.dtpClaim1.CustomFormat = "dd MMM yyyy";
            this.dtpClaim1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaim1.Location = new System.Drawing.Point(135, 3);
            this.dtpClaim1.Name = "dtpClaim1";
            this.dtpClaim1.Size = new System.Drawing.Size(144, 26);
            this.dtpClaim1.TabIndex = 12;
            this.dtpClaim1.Visible = false;
            // 
            // btnDeleteClaim1
            // 
            this.btnDeleteClaim1.FlatAppearance.BorderSize = 0;
            this.btnDeleteClaim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClaim1.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_24x24;
            this.btnDeleteClaim1.Location = new System.Drawing.Point(285, 1);
            this.btnDeleteClaim1.Name = "btnDeleteClaim1";
            this.btnDeleteClaim1.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteClaim1.TabIndex = 13;
            this.btnDeleteClaim1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClaim1.UseVisualStyleBackColor = true;
            this.btnDeleteClaim1.Visible = false;
            // 
            // btnDeleteClaim2
            // 
            this.btnDeleteClaim2.FlatAppearance.BorderSize = 0;
            this.btnDeleteClaim2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClaim2.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_24x24;
            this.btnDeleteClaim2.Location = new System.Drawing.Point(285, 33);
            this.btnDeleteClaim2.Name = "btnDeleteClaim2";
            this.btnDeleteClaim2.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteClaim2.TabIndex = 14;
            this.btnDeleteClaim2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClaim2.UseVisualStyleBackColor = true;
            this.btnDeleteClaim2.Visible = false;
            // 
            // btnDeleteClaim3
            // 
            this.btnDeleteClaim3.FlatAppearance.BorderSize = 0;
            this.btnDeleteClaim3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClaim3.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_24x24;
            this.btnDeleteClaim3.Location = new System.Drawing.Point(285, 65);
            this.btnDeleteClaim3.Name = "btnDeleteClaim3";
            this.btnDeleteClaim3.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteClaim3.TabIndex = 15;
            this.btnDeleteClaim3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClaim3.UseVisualStyleBackColor = true;
            this.btnDeleteClaim3.Visible = false;
            // 
            // btnDeleteClaim4
            // 
            this.btnDeleteClaim4.FlatAppearance.BorderSize = 0;
            this.btnDeleteClaim4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClaim4.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_24x24;
            this.btnDeleteClaim4.Location = new System.Drawing.Point(285, 97);
            this.btnDeleteClaim4.Name = "btnDeleteClaim4";
            this.btnDeleteClaim4.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteClaim4.TabIndex = 16;
            this.btnDeleteClaim4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClaim4.UseVisualStyleBackColor = true;
            this.btnDeleteClaim4.Visible = false;
            // 
            // btnDeleteClaim5
            // 
            this.btnDeleteClaim5.FlatAppearance.BorderSize = 0;
            this.btnDeleteClaim5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClaim5.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_24x24;
            this.btnDeleteClaim5.Location = new System.Drawing.Point(285, 129);
            this.btnDeleteClaim5.Name = "btnDeleteClaim5";
            this.btnDeleteClaim5.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteClaim5.TabIndex = 17;
            this.btnDeleteClaim5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClaim5.UseVisualStyleBackColor = true;
            this.btnDeleteClaim5.Visible = false;
            // 
            // dtpClaim2
            // 
            this.dtpClaim2.CustomFormat = "dd MMM yyyy";
            this.dtpClaim2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaim2.Location = new System.Drawing.Point(135, 35);
            this.dtpClaim2.Name = "dtpClaim2";
            this.dtpClaim2.Size = new System.Drawing.Size(144, 26);
            this.dtpClaim2.TabIndex = 18;
            this.dtpClaim2.Visible = false;
            // 
            // dtpClaim3
            // 
            this.dtpClaim3.CustomFormat = "dd MMM yyyy";
            this.dtpClaim3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaim3.Location = new System.Drawing.Point(135, 67);
            this.dtpClaim3.Name = "dtpClaim3";
            this.dtpClaim3.Size = new System.Drawing.Size(144, 26);
            this.dtpClaim3.TabIndex = 19;
            this.dtpClaim3.Visible = false;
            // 
            // dtpClaim4
            // 
            this.dtpClaim4.CustomFormat = "dd MMM yyyy";
            this.dtpClaim4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaim4.Location = new System.Drawing.Point(135, 99);
            this.dtpClaim4.Name = "dtpClaim4";
            this.dtpClaim4.Size = new System.Drawing.Size(144, 26);
            this.dtpClaim4.TabIndex = 20;
            this.dtpClaim4.Visible = false;
            // 
            // dtpClaim5
            // 
            this.dtpClaim5.CustomFormat = "dd MMM yyyy";
            this.dtpClaim5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaim5.Location = new System.Drawing.Point(135, 130);
            this.dtpClaim5.Name = "dtpClaim5";
            this.dtpClaim5.Size = new System.Drawing.Size(144, 26);
            this.dtpClaim5.TabIndex = 21;
            this.dtpClaim5.Visible = false;
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.Location = new System.Drawing.Point(15, 214);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(112, 32);
            this.btnAddClaim.TabIndex = 11;
            this.btnAddClaim.Text = "Add Claim";
            this.btnAddClaim.UseVisualStyleBackColor = true;
            this.btnAddClaim.Visible = false;
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // lblDateOfClaims
            // 
            this.lblDateOfClaims.AutoSize = true;
            this.lblDateOfClaims.Location = new System.Drawing.Point(3, 5);
            this.lblDateOfClaims.Name = "lblDateOfClaims";
            this.lblDateOfClaims.Size = new System.Drawing.Size(127, 20);
            this.lblDateOfClaims.TabIndex = 22;
            this.lblDateOfClaims.Text = "Date of Claim(s):";
            this.lblDateOfClaims.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(11, 73);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(103, 20);
            this.lblDateOfBirth.TabIndex = 14;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd MMM yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(130, 70);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(144, 26);
            this.dtpDateOfBirth.TabIndex = 15;
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 471);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddClaim);
            this.Controls.Add(this.pnlClaimDetails);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.cboOccupation);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblDriverClaims);
            this.Controls.Add(this.lblDriverDetails);
            this.Controls.Add(this.lblDriverOccupation);
            this.Controls.Add(this.lblDriverFullName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDriver";
            this.Text = "Add/Edit Driver";
            this.pnlClaimDetails.ResumeLayout(false);
            this.pnlClaimDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverFullName;
        private System.Windows.Forms.Label lblDriverOccupation;
        private System.Windows.Forms.Label lblDriverDetails;
        private System.Windows.Forms.Label lblDriverClaims;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cboOccupation;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.Panel pnlClaimDetails;
        private System.Windows.Forms.DateTimePicker dtpClaim1;
        private System.Windows.Forms.DateTimePicker dtpClaim5;
        private System.Windows.Forms.DateTimePicker dtpClaim4;
        private System.Windows.Forms.DateTimePicker dtpClaim3;
        private System.Windows.Forms.DateTimePicker dtpClaim2;
        private System.Windows.Forms.Button btnDeleteClaim5;
        private System.Windows.Forms.Button btnDeleteClaim4;
        private System.Windows.Forms.Button btnDeleteClaim3;
        private System.Windows.Forms.Button btnDeleteClaim2;
        private System.Windows.Forms.Button btnDeleteClaim1;
        private System.Windows.Forms.Button btnAddClaim;
        private System.Windows.Forms.Label lblDateOfClaims;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}