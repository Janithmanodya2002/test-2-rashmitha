namespace GlobalCollege
{
    partial class StudentRegistry
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpStudentReg = new System.Windows.Forms.GroupBox();
            this.grpBasicDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpParentDetails = new System.Windows.Forms.GroupBox();
            this.txtParentContact = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentContact = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkExit = new System.Windows.Forms.LinkLabel();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.cboRegNo = new System.Windows.Forms.ComboBox();
            this.grpStudentReg.SuspendLayout();
            this.grpBasicDetails.SuspendLayout();
            this.grpContactDetails.SuspendLayout();
            this.grpParentDetails.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Skills International";
            //
            // grpStudentReg
            //
            this.grpStudentReg.Controls.Add(this.cboRegNo);
            this.grpStudentReg.Controls.Add(this.lblRegNo);
            this.grpStudentReg.Controls.Add(this.grpParentDetails);
            this.grpStudentReg.Controls.Add(this.grpContactDetails);
            this.grpStudentReg.Controls.Add(this.grpBasicDetails);
            this.grpStudentReg.Location = new System.Drawing.Point(18, 48);
            this.grpStudentReg.Name = "grpStudentReg";
            this.grpStudentReg.Size = new System.Drawing.Size(754, 501);
            this.grpStudentReg.TabIndex = 2;
            this.grpStudentReg.TabStop = false;
            this.grpStudentReg.Text = "Student Registration";
            //
            // grpBasicDetails
            //
            this.grpBasicDetails.Controls.Add(this.dtpDOB);
            this.grpBasicDetails.Controls.Add(this.radFemale);
            this.grpBasicDetails.Controls.Add(this.radMale);
            this.grpBasicDetails.Controls.Add(this.txtLastName);
            this.grpBasicDetails.Controls.Add(this.txtFirstName);
            this.grpBasicDetails.Controls.Add(this.lblGender);
            this.grpBasicDetails.Controls.Add(this.lblDOB);
            this.grpBasicDetails.Controls.Add(this.lblLastName);
            this.grpBasicDetails.Controls.Add(this.lblFirstName);
            this.grpBasicDetails.Location = new System.Drawing.Point(19, 78);
            this.grpBasicDetails.Name = "grpBasicDetails";
            this.grpBasicDetails.Size = new System.Drawing.Size(350, 200);
            this.grpBasicDetails.TabIndex = 0;
            this.grpBasicDetails.TabStop = false;
            this.grpBasicDetails.Text = "Basic Details";
            //
            // dtpDOB
            //
            this.dtpDOB.Location = new System.Drawing.Point(120, 110);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 26);
            this.dtpDOB.TabIndex = 8;
            //
            // radFemale
            //
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(219, 154);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(80, 24);
            this.radFemale.TabIndex = 7;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            //
            // radMale
            //
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(120, 154);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(61, 24);
            this.radMale.TabIndex = 6;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            //
            // txtLastName
            //
            this.txtLastName.Location = new System.Drawing.Point(120, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.TabIndex = 5;
            //
            // txtFirstName
            //
            this.txtFirstName.Location = new System.Drawing.Point(120, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.TabIndex = 4;
            //
            // lblGender
            //
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 156);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            //
            // lblDOB
            //
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 115);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(99, 20);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth";
            //
            // lblLastName
            //
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            //
            // lblFirstName
            //
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            //
            // grpContactDetails
            //
            this.grpContactDetails.Controls.Add(this.txtHomePhone);
            this.grpContactDetails.Controls.Add(this.txtMobilePhone);
            this.grpContactDetails.Controls.Add(this.txtEmail);
            this.grpContactDetails.Controls.Add(this.txtAddress);
            this.grpContactDetails.Controls.Add(this.lblHomePhone);
            this.grpContactDetails.Controls.Add(this.lblMobilePhone);
            this.grpContactDetails.Controls.Add(this.lblEmail);
            this.grpContactDetails.Controls.Add(this.lblAddress);
            this.grpContactDetails.Location = new System.Drawing.Point(389, 78);
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Size = new System.Drawing.Size(350, 200);
            this.grpContactDetails.TabIndex = 1;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Details";
            //
            // txtHomePhone
            //
            this.txtHomePhone.Location = new System.Drawing.Point(120, 153);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(200, 26);
            this.txtHomePhone.TabIndex = 7;
            //
            // txtMobilePhone
            //
            this.txtMobilePhone.Location = new System.Drawing.Point(120, 112);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(200, 26);
            this.txtMobilePhone.TabIndex = 6;
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(120, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 5;
            //
            // txtAddress
            //
            this.txtAddress.Location = new System.Drawing.Point(120, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 26);
            this.txtAddress.TabIndex = 4;
            //
            // lblHomePhone
            //
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(20, 156);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(99, 20);
            this.lblHomePhone.TabIndex = 3;
            this.lblHomePhone.Text = "Home Phone";
            //
            // lblMobilePhone
            //
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(20, 115);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(105, 20);
            this.lblMobilePhone.TabIndex = 2;
            this.lblMobilePhone.Text = "Mobile Phone";
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            //
            // lblAddress
            //
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 33);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            //
            // grpParentDetails
            //
            this.grpParentDetails.Controls.Add(this.txtParentContact);
            this.grpParentDetails.Controls.Add(this.txtNIC);
            this.grpParentDetails.Controls.Add(this.txtParentName);
            this.grpParentDetails.Controls.Add(this.lblParentContact);
            this.grpParentDetails.Controls.Add(this.lblNIC);
            this.grpParentDetails.Controls.Add(this.lblParentName);
            this.grpParentDetails.Location = new System.Drawing.Point(19, 298);
            this.grpParentDetails.Name = "grpParentDetails";
            this.grpParentDetails.Size = new System.Drawing.Size(720, 120);
            this.grpParentDetails.TabIndex = 2;
            this.grpParentDetails.TabStop = false;
            this.grpParentDetails.Text = "Parent Details";
            //
            // txtParentContact
            //
            this.txtParentContact.Location = new System.Drawing.Point(490, 70);
            this.txtParentContact.Name = "txtParentContact";
            this.txtParentContact.Size = new System.Drawing.Size(200, 26);
            this.txtParentContact.TabIndex = 5;
            //
            // txtNIC
            //
            this.txtNIC.Location = new System.Drawing.Point(120, 70);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(200, 26);
            this.txtNIC.TabIndex = 4;
            //
            // txtParentName
            //
            this.txtParentName.Location = new System.Drawing.Point(120, 30);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(570, 26);
            this.txtParentName.TabIndex = 3;
            //
            // lblParentContact
            //
            this.lblParentContact.AutoSize = true;
            this.lblParentContact.Location = new System.Drawing.Point(385, 73);
            this.lblParentContact.Name = "lblParentContact";
            this.lblParentContact.Size = new System.Drawing.Size(89, 20);
            this.lblParentContact.TabIndex = 2;
            this.lblParentContact.Text = "Contact No";
            //
            // lblNIC
            //
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(20, 73);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(36, 20);
            this.lblNIC.TabIndex = 1;
            this.lblNIC.Text = "NIC";
            //
            // lblParentName
            //
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(20, 33);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(102, 20);
            this.lblParentName.TabIndex = 0;
            this.lblParentName.Text = "Parent Name";
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(18, 565);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 35);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(130, 565);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(242, 565);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(354, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // lnkLogout
            //
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(14, 610);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(59, 20);
            this.lnkLogout.TabIndex = 7;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            //
            // lnkExit
            //
            this.lnkExit.AutoSize = true;
            this.lnkExit.Location = new System.Drawing.Point(733, 610);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new System.Drawing.Size(37, 20);
            this.lnkExit.TabIndex = 8;
            this.lnkExit.TabStop = true;
            this.lnkExit.Text = "Exit";
            this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);
            //
            // lblRegNo
            //
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(39, 39);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(63, 20);
            this.lblRegNo.TabIndex = 3;
            this.lblRegNo.Text = "Reg No";
            //
            // cboRegNo
            //
            this.cboRegNo.FormattingEnabled = true;
            this.cboRegNo.Location = new System.Drawing.Point(139, 36);
            this.cboRegNo.Name = "cboRegNo";
            this.cboRegNo.Size = new System.Drawing.Size(200, 28);
            this.cboRegNo.TabIndex = 4;
            this.cboRegNo.SelectedIndexChanged += new System.EventHandler(this.cboRegNo_SelectedIndexChanged);
            //
            // RegistrationForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 641);
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpStudentReg);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StudentRegistry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Global College";
            this.Load += new System.EventHandler(this.StudentRegistry_Load);
            this.grpStudentReg.ResumeLayout(false);
            this.grpStudentReg.PerformLayout();
            this.grpBasicDetails.ResumeLayout(false);
            this.grpBasicDetails.PerformLayout();
            this.grpContactDetails.ResumeLayout(false);
            this.grpContactDetails.PerformLayout();
            this.grpParentDetails.ResumeLayout(false);
            this.grpParentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStudentReg;
        private System.Windows.Forms.GroupBox grpParentDetails;
        private System.Windows.Forms.GroupBox grpContactDetails;
        private System.Windows.Forms.GroupBox grpBasicDetails;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtParentContact;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblParentContact;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkExit;
        private System.Windows.Forms.ComboBox cboRegNo;
        private System.Windows.Forms.Label lblRegNo;
    }
}
