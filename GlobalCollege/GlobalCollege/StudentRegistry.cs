using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlobalCollege
{
    public partial class StudentRegistry : Form
    {
        public StudentRegistry()
        {
            InitializeComponent();
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm loginForm = new AuthForm();
            loginForm.Show();
        }

        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked ? "Male" : "Female";
            using (var connection = DBManager.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@mobilePhone", int.Parse(txtMobilePhone.Text));
                    command.Parameters.AddWithValue("@homePhone", int.Parse(txtHomePhone.Text));
                    command.Parameters.AddWithValue("@parentName", txtParentName.Text);
                    command.Parameters.AddWithValue("@nic", txtNIC.Text);
                    command.Parameters.AddWithValue("@contactNo", int.Parse(txtParentContact.Text));
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadRegNumbers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = radMale.Checked ? "Male" : "Female";
            using (var connection = DBManager.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Registration SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, gender = @gender, address = @address, email = @email, mobilePhone = @mobilePhone, homePhone = @homePhone, parentName = @parentName, nic = @nic, contactNo = @contactNo WHERE regNo = @regNo";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@mobilePhone", int.Parse(txtMobilePhone.Text));
                    command.Parameters.AddWithValue("@homePhone", int.Parse(txtHomePhone.Text));
                    command.Parameters.AddWithValue("@parentName", txtParentName.Text);
                    command.Parameters.AddWithValue("@nic", txtNIC.Text);
                    command.Parameters.AddWithValue("@contactNo", int.Parse(txtParentContact.Text));
                    command.Parameters.AddWithValue("@regNo", int.Parse(cboRegNo.Text));
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadRegNumbers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (var connection = DBManager.GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", int.Parse(cboRegNo.Text));
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadRegNumbers();
            }
        }

        private void ClearForm()
        {
            cboRegNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpDOB.Value = DateTime.Now;
            radMale.Checked = true;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobilePhone.Text = "";
            txtHomePhone.Text = "";
            txtParentName.Text = "";
            txtNIC.Text = "";
            txtParentContact.Text = "";
        }

        private void LoadRegNumbers()
        {
            cboRegNo.Items.Clear();
            using (var connection = DBManager.GetConnection())
            {
                connection.Open();
                string query = "SELECT regNo FROM Registration";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboRegNo.Items.Add(reader["regNo"].ToString());
                        }
                    }
                }
            }
        }

        private void StudentRegistry_Load(object sender, EventArgs e)
        {
            LoadRegNumbers();
        }

        private void regNoComboBox_SelectionChanged(object sender, EventArgs e)
        {
            using (var connection = DBManager.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@regNo", int.Parse(cboRegNo.Text));
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["firstName"].ToString();
                            txtLastName.Text = reader["lastName"].ToString();
                            dtpDOB.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                            if (reader["gender"].ToString() == "Male")
                            {
                                radMale.Checked = true;
                            }
                            else
                            {
                                radFemale.Checked = true;
                            }
                            txtAddress.Text = reader["address"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtMobilePhone.Text = reader["mobilePhone"].ToString();
                            txtHomePhone.Text = reader["homePhone"].ToString();
                            txtParentName.Text = reader["parentName"].ToString();
                            txtNIC.Text = reader["nic"].ToString();
                            txtParentContact.Text = reader["contactNo"].ToString();
                        }
                    }
                }
            }
        }
    }
}
