Imports MySql.Data.MySqlClient
Public Class AddStaffDialog

    Private isEditMode As Boolean = False
    Private editUserId As Integer = -1

    Public Sub InitializeForm(Optional userId As Integer = -1)
        If userId <> -1 Then
            isEditMode = True
            editUserId = userId
            btnAdd.Text = "Update"
            btnDelete.Text = "Delete"
            PopulateUserDetails(userId)
            lblFormName.Text = $"Update {txtFirstName.Text}'s Details"
        Else
            isEditMode = False
            editUserId = -1
        End If
    End Sub

    Private Sub PopulateComboboxes()
        Try
            'Setting the default values of the comboboxes
            ' Gender ComboBox with value/display
            cmbGender.Items.Clear()

            Utils.AddItemToComboBox(cmbGender, "m", "Male")
            Utils.AddItemToComboBox(cmbGender, "f", "Female")

            cmbGender.SelectedIndex = 0 'This will make sure the first item is selected.

            ' Role ComboBox with value/display
            cmbRole.Items.Clear()
            ' Add roles dynamically
            Utils.AddItemToComboBox(cmbRole, "admin", "Admin")
            Utils.AddItemToComboBox(cmbRole, "recep", "Receptionist")
            Utils.AddItemToComboBox(cmbRole, "atten", "Attendant")
            cmbRole.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim query As String

            If isEditMode Then
                ' UPDATE mode
                query = "UPDATE users SET fname=@fname, lname=@lname, username=@username, gender=@gender, role=@role, " &
                    "status=@status, phone=@phone, email=@email, dob=@dob, job_title=@job_title, password=@password " &
                    "WHERE id=@id"
            Else
                ' INSERT mode
                query = "INSERT INTO users (fname, lname, username, gender, role, status, phone, email, dob, job_title, password) " &
                    "VALUES (@fname, @lname, @username, @gender, @role, @status, @phone, @email, @dob, @job_title, @password)"
            End If

            Using conn As New MySqlConnection(My.Resources.conn)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedValue.ToString())
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedValue.ToString())
                    cmd.Parameters.AddWithValue("@status", "Active")
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@dob", tmpDOB.Value.Date)
                    cmd.Parameters.AddWithValue("@job_title", txtJobTitle.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                    If isEditMode Then
                        cmd.Parameters.AddWithValue("@id", editUserId)
                    End If

                    cmd.ExecuteNonQuery()

                    If isEditMode Then
                        MessageBox.Show("User updated successfully!")
                    Else
                        MessageBox.Show("User added successfully!")
                    End If
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub PopulateUserDetails(userId As Integer)
        Try
            Dim query As String = "SELECT * FROM users WHERE id = @id"

            Using conn As New MySqlConnection(My.Resources.conn)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", userId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFirstName.Text = reader("fname").ToString()
                            txtLastName.Text = reader("lname").ToString()
                            txtUsername.Text = reader("username").ToString()

                            ' Check and set gender combo 
                            cmbGender.SelectedValue = reader("gender").ToString.ToLower

                            ' Check and set role combo
                            cmbRole.SelectedValue = reader("role").ToString.ToLower


                            txtPhone.Text = reader("phone").ToString()
                            txtEmail.Text = reader("email").ToString()

                            ' Parse and set Date of Birth
                            If Not IsDBNull(reader("dob")) Then
                                tmpDOB.Value = Convert.ToDateTime(reader("dob"))
                            End If

                            txtJobTitle.Text = reader("job_title").ToString()

                            ' Passwords typically shouldn't be displayed for security, but here it is:
                            txtPassword.Text = reader("password").ToString()
                        Else
                            MessageBox.Show("User not found.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user: " & ex.Message)
        End Try
    End Sub


    Private Sub AddStaffDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Panel4.Enter
        PopulateComboboxes()
        populateDateTimePicker()

        ' Set the default value of the buttons.
        btnAdd.Text = "Add"
        btnDelete.Text = "Cancel"
    End Sub
    Private Sub populateDateTimePicker()
        ' Calculate date limits
        Dim today As Date = Date.Today
        Dim maxDate As Date = today.AddYears(-18)  ' 18 years ago
        Dim minDate As Date = today.AddYears(-80)  ' 80 `years ago

        ' Apply to DateTimePicker
        tmpDOB.MaxDate = maxDate
        tmpDOB.MinDate = minDate
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If Not isEditMode Then
            If MsgBox($"Are you sure you want don't want to save this new user?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            If MsgBox($"Are you sure you want to delete {txtFirstName.Text} from the system?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query = $"UPDATE users SET status='deleted' WHERE id={editUserId}"
                Try
                    Using conn As New MySqlConnection(My.Resources.conn)
                        conn.Open()
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show($"{txtFirstName.Text} deleted successfully!")
                            Me.DialogResult = DialogResult.OK
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading user: " & ex.Message)
                End Try
            End If
        End If



    End Sub

    ' This is a custom function to set the value of the combobox based on its key.
    Private Sub SetSelectedItemByValue(cmb As ComboBox, valueToSelect As String)
        For Each item As KeyValuePair(Of String, String) In cmb.Items
            If item.Key = valueToSelect.ToLower Then
                cmb.SelectedItem = item
                Exit Sub
            End If
        Next
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Dim originalText As String = txtFirstName.Text
        Dim filteredText As String = ""

        For Each ch As Char In originalText
            If Char.IsLetter(ch) Then
                filteredText &= ch
            End If
        Next

        If txtFirstName.Text <> filteredText Then
            Dim cursorPos As Integer = txtFirstName.SelectionStart
            txtFirstName.Text = filteredText
            txtFirstName.SelectionStart = Math.Min(cursorPos, filteredText.Length)
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim originalText As String = txtLastName.Text
        Dim filteredText As String = ""

        For Each ch As Char In originalText
            If Char.IsLetter(ch) Then
                filteredText &= ch
            End If
        Next

        If txtLastName.Text <> filteredText Then
            Dim cursorPos As Integer = txtLastName.SelectionStart
            txtLastName.Text = filteredText
            txtLastName.SelectionStart = Math.Min(cursorPos, filteredText.Length)
        End If
    End Sub

End Class