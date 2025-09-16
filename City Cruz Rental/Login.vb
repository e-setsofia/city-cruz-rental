Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Login
    Dim db As New DatabaseHelper()

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            btnShowPassword.Image = City_Cruz_Rental.My.Resources.eye_close
        Else
            txtPassword.UseSystemPasswordChar = True
            btnShowPassword.Image = City_Cruz_Rental.My.Resources.eye_open
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Use parameterized query to avoid SQL injection
        Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"

        Dim result As New DataTable()
        Using connection As New MySqlConnection(My.Resources.conn)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                'cmd.Parameters.AddWithValue("@username", username) ' TODO Update evans and admin1234 to username and password respectively
                'cmd.Parameters.AddWithValue("@password", password)

                cmd.Parameters.AddWithValue("@username", "asafo") ' TODO Update evans and admin1234 to username and password respectively
                cmd.Parameters.AddWithValue("@password", "wor1234")

                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(result)

                If result.Rows.Count > 0 Then
                    With result.Rows(0)
                        UserSession.Id = .Item("id")
                        UserSession.Fname = .Item("fname").ToString()
                        UserSession.Lname = .Item("lname").ToString()
                        UserSession.Username = .Item("username").ToString()
                        UserSession.Gender = .Item("gender").ToString()
                        UserSession.Role = .Item("role").ToString()
                        UserSession.Status = .Item("status").ToString()
                        UserSession.Phone = .Item("phone").ToString()
                        UserSession.Email = .Item("email").ToString()
                        UserSession.Dob = Convert.ToDateTime(.Item("dob"))
                        UserSession.JobTitle = .Item("job_title").ToString()
                    End With

                    If Not UserSession.Status = "active" Then
                        MsgBox($"Hello, {UserSession.Fname}. Your account is not active. Kindly contact the Administrator.", MsgBoxStyle.Exclamation)
                    Else
                        frmMain.Show()
                        Me.Close()
                    End If


                Else
                        MessageBox.Show("User not found or invalid credentials.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function extractText(textBox As Guna2TextBox)
        Return textBox.Text.ToLower
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim conn As MySqlConnection
        conn = New MySqlConnection(My.Settings.remoteConn)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()
    End Sub
End Class