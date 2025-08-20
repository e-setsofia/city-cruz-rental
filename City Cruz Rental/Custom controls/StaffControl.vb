Imports MySql.Data.MySqlClient

Public Class StaffControl
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim query As String = "INSERT INTO users (fname, lname, username, gender, role, status, phone, email, dob, job_title, password) " &
                          "VALUES (@fname, @lname, @username, @gender, @role, @status, @phone, @email, @dob, @job_title, @password)"

            Using conn As New MySqlConnection(My.Resources.conn)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@status", "Active") ' or use a status dropdown if available
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@dob", tmpDOB.Value.Date)
                    cmd.Parameters.AddWithValue("@job_title", txtStaffID.Text) ' assuming Staff ID maps to job_title
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text) ' consider hashing this

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User saved successfully!")
                End Using
                ' Refresh the DataGridView
                loadStaffData()


            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
    Public Sub loadStaffData()
        Try
            Using conn As New MySqlConnection(My.Resources.conn)
                conn.Open()

                Dim query As String = "SELECT " &
                                  "id AS 'ID', " &
                                  "fname AS 'First Name', " &
                                  "lname AS 'Last Name', " &
                                  "username AS 'Username', " &
                                  "gender AS 'Gender', " &
                                  "role AS 'Role', " &
                                  "status AS 'Status', " &
                                  "phone AS 'Phone', " &
                                  "email AS 'Email', " &
                                  "dob AS 'Date Of Birth', " &
                                  "job_title AS 'Job Title' " &
                                  "FROM users"

                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dvgStaffdetails.DataSource = table

                    ' Apply date formatting AFTER binding
                    If dvgStaffdetails.Columns.Contains("Date Of Birth") Then
                        dvgStaffdetails.Columns("Date Of Birth").DefaultCellStyle.Format = "dd-MM-yyyy"
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub


    Private Sub StaffControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStaffData()
    End Sub
End Class

