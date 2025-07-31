# Final Project - Assessment Sheet

**Programme:** L3 - Diploma in Information Technology
**Unit:** Final Project
**Project Title:** Student Registration System
**Student’s Name:** [Your Name]
**Student’s Registration No:** [Your Registration No]
**Submission Date:** [Date]

---

## 1. Login Form

### Screenshot

![Login Form](https://i.imgur.com/7g3o4Y4.png)

### Code Snippet

```csharp
// AuthForm.cs

private void btnLogin_Click(object sender, EventArgs e)
{
    if (txtUsername.Text == "Admin" && txtPassword.Text == "Skills@123")
    {
        this.Hide();
        StudentRegistry registrationForm = new StudentRegistry();
        registrationForm.Show();
    }
    else
    {
        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

private void btnClear_Click(object sender, EventArgs e)
{
    txtUsername.Text = "";
    txtPassword.Text = "";
    txtUsername.Focus();
}

private void btnExit_Click(object sender, EventArgs e)
{
    DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    if (result == DialogResult.Yes)
    {
        Application.Exit();
    }
}
```

---

## 2. Registration Form

### Screenshot

![Registration Form](https://i.imgur.com/gK6jH8p.png)

### Code Snippets

```csharp
// StudentRegistry.cs

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

private void cboRegNo_SelectedIndexChanged(object sender, EventArgs e)
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
```

---

## 3. Database Schema

```sql
CREATE TABLE IF NOT EXISTS Registration (
    regNo INTEGER PRIMARY KEY AUTOINCREMENT,
    firstName VARCHAR(50),
    lastName VARCHAR(50),
    dateOfBirth DATETIME,
    gender VARCHAR(50),
    address VARCHAR(50),
    email VARCHAR(50),
    mobilePhone INTEGER,
    homePhone INTEGER,
    parentName VARCHAR(50),
    nic VARCHAR(50),
    contactNo INTEGER
)
```
