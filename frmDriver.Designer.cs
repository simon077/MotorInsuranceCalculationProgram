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
            this.pnlDriverDetails = new System.Windows.Forms.Panel();
            this.btnEditDriver5 = new System.Windows.Forms.Button();
            this.btnEditDriver4 = new System.Windows.Forms.Button();
            this.btnEditDriver3 = new System.Windows.Forms.Button();
            this.btnEditDriver2 = new System.Windows.Forms.Button();
            this.btnEditDriver1 = new System.Windows.Forms.Button();
            this.btnDeleteDriver5 = new System.Windows.Forms.Button();
            this.btnDeleteDriver4 = new System.Windows.Forms.Button();
            this.btnDeleteDriver3 = new System.Windows.Forms.Button();
            this.btnDeleteDriver2 = new System.Windows.Forms.Button();
            this.btnDeleteDriver1 = new System.Windows.Forms.Button();
            this.pnlDriverDetails.SuspendLayout();
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
            this.lblDriverOccupation.Location = new System.Drawing.Point(11, 73);
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
            this.lblDriverClaims.Location = new System.Drawing.Point(11, 113);
            this.lblDriverClaims.Name = "lblDriverClaims";
            this.lblDriverClaims.Size = new System.Drawing.Size(394, 20);
            this.lblDriverClaims.TabIndex = 3;
            this.lblDriverClaims.Text = "Has this driver made any claims within the last 5 years?";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(130, 40);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(185, 26);
            this.txtFullName.TabIndex = 4;
            // 
            // cboOccupation
            // 
            this.cboOccupation.FormattingEnabled = true;
            this.cboOccupation.Items.AddRange(new object[] {
            "Chauffeur",
            "Accountant"});
            this.cboOccupation.Location = new System.Drawing.Point(130, 70);
            this.cboOccupation.Name = "cboOccupation";
            this.cboOccupation.Size = new System.Drawing.Size(185, 28);
            this.cboOccupation.TabIndex = 5;
            // 
            // chkYes
            // 
            this.chkYes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkYes.Location = new System.Drawing.Point(15, 136);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(96, 32);
            this.chkYes.TabIndex = 8;
            this.chkYes.Text = "Yes";
            this.chkYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // chkNo
            // 
            this.chkNo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNo.Location = new System.Drawing.Point(130, 136);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(96, 32);
            this.chkNo.TabIndex = 9;
            this.chkNo.Text = "No";
            this.chkNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // pnlDriverDetails
            // 
            this.pnlDriverDetails.AutoScroll = true;
            this.pnlDriverDetails.Controls.Add(this.btnDeleteDriver5);
            this.pnlDriverDetails.Controls.Add(this.btnDeleteDriver4);
            this.pnlDriverDetails.Controls.Add(this.btnDeleteDriver3);
            this.pnlDriverDetails.Controls.Add(this.btnDeleteDriver2);
            this.pnlDriverDetails.Controls.Add(this.btnDeleteDriver1);
            this.pnlDriverDetails.Controls.Add(this.btnEditDriver5);
            this.pnlDriverDetails.Controls.Add(this.btnEditDriver4);
            this.pnlDriverDetails.Controls.Add(this.btnEditDriver3);
            this.pnlDriverDetails.Controls.Add(this.btnEditDriver2);
            this.pnlDriverDetails.Controls.Add(this.btnEditDriver1);
            this.pnlDriverDetails.Location = new System.Drawing.Point(12, 208);
            this.pnlDriverDetails.Name = "pnlDriverDetails";
            this.pnlDriverDetails.Size = new System.Drawing.Size(355, 114);
            this.pnlDriverDetails.TabIndex = 10;
            // 
            // btnEditDriver5
            // 
            this.btnEditDriver5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDriver5.Location = new System.Drawing.Point(3, 155);
            this.btnEditDriver5.Name = "btnEditDriver5";
            this.btnEditDriver5.Size = new System.Drawing.Size(290, 32);
            this.btnEditDriver5.TabIndex = 6;
            this.btnEditDriver5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDriver5.UseVisualStyleBackColor = true;
            // 
            // btnEditDriver4
            // 
            this.btnEditDriver4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDriver4.Location = new System.Drawing.Point(3, 117);
            this.btnEditDriver4.Name = "btnEditDriver4";
            this.btnEditDriver4.Size = new System.Drawing.Size(290, 32);
            this.btnEditDriver4.TabIndex = 5;
            this.btnEditDriver4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDriver4.UseVisualStyleBackColor = true;
            // 
            // btnEditDriver3
            // 
            this.btnEditDriver3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDriver3.Location = new System.Drawing.Point(3, 79);
            this.btnEditDriver3.Name = "btnEditDriver3";
            this.btnEditDriver3.Size = new System.Drawing.Size(290, 32);
            this.btnEditDriver3.TabIndex = 4;
            this.btnEditDriver3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDriver3.UseVisualStyleBackColor = true;
            // 
            // btnEditDriver2
            // 
            this.btnEditDriver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDriver2.Location = new System.Drawing.Point(3, 41);
            this.btnEditDriver2.Name = "btnEditDriver2";
            this.btnEditDriver2.Size = new System.Drawing.Size(290, 32);
            this.btnEditDriver2.TabIndex = 3;
            this.btnEditDriver2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDriver2.UseVisualStyleBackColor = true;
            // 
            // btnEditDriver1
            // 
            this.btnEditDriver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDriver1.Location = new System.Drawing.Point(3, 3);
            this.btnEditDriver1.Name = "btnEditDriver1";
            this.btnEditDriver1.Size = new System.Drawing.Size(290, 32);
            this.btnEditDriver1.TabIndex = 2;
            this.btnEditDriver1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDriver1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDriver5
            // 
            this.btnDeleteDriver5.FlatAppearance.BorderSize = 0;
            this.btnDeleteDriver5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDriver5.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_32x32;
            this.btnDeleteDriver5.Location = new System.Drawing.Point(299, 155);
            this.btnDeleteDriver5.Name = "btnDeleteDriver5";
            this.btnDeleteDriver5.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteDriver5.TabIndex = 11;
            this.btnDeleteDriver5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDriver5.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDriver4
            // 
            this.btnDeleteDriver4.FlatAppearance.BorderSize = 0;
            this.btnDeleteDriver4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDriver4.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_32x32;
            this.btnDeleteDriver4.Location = new System.Drawing.Point(299, 117);
            this.btnDeleteDriver4.Name = "btnDeleteDriver4";
            this.btnDeleteDriver4.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteDriver4.TabIndex = 10;
            this.btnDeleteDriver4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDriver4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDriver3
            // 
            this.btnDeleteDriver3.FlatAppearance.BorderSize = 0;
            this.btnDeleteDriver3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDriver3.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_32x32;
            this.btnDeleteDriver3.Location = new System.Drawing.Point(299, 79);
            this.btnDeleteDriver3.Name = "btnDeleteDriver3";
            this.btnDeleteDriver3.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteDriver3.TabIndex = 9;
            this.btnDeleteDriver3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDriver3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDriver2
            // 
            this.btnDeleteDriver2.FlatAppearance.BorderSize = 0;
            this.btnDeleteDriver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDriver2.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_32x32;
            this.btnDeleteDriver2.Location = new System.Drawing.Point(299, 41);
            this.btnDeleteDriver2.Name = "btnDeleteDriver2";
            this.btnDeleteDriver2.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteDriver2.TabIndex = 8;
            this.btnDeleteDriver2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDriver2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDriver1
            // 
            this.btnDeleteDriver1.FlatAppearance.BorderSize = 0;
            this.btnDeleteDriver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDriver1.Image = global::MotorInsuranceCalculationProgram.Properties.Resources.Red_Cross_32x32;
            this.btnDeleteDriver1.Location = new System.Drawing.Point(299, 3);
            this.btnDeleteDriver1.Name = "btnDeleteDriver1";
            this.btnDeleteDriver1.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteDriver1.TabIndex = 7;
            this.btnDeleteDriver1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDriver1.UseVisualStyleBackColor = true;
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.pnlDriverDetails);
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
            this.pnlDriverDetails.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlDriverDetails;
        private System.Windows.Forms.Button btnDeleteDriver5;
        private System.Windows.Forms.Button btnDeleteDriver4;
        private System.Windows.Forms.Button btnDeleteDriver3;
        private System.Windows.Forms.Button btnDeleteDriver2;
        private System.Windows.Forms.Button btnDeleteDriver1;
        private System.Windows.Forms.Button btnEditDriver5;
        private System.Windows.Forms.Button btnEditDriver4;
        private System.Windows.Forms.Button btnEditDriver3;
        private System.Windows.Forms.Button btnEditDriver2;
        private System.Windows.Forms.Button btnEditDriver1;
    }
}