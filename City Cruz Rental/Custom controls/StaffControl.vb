Imports MySql.Data.MySqlClient

Public Class StaffControl

    Public Sub loadStaffData()

        Using conn As New MySqlConnection(My.Resources.conn)
            conn.Open()

            ' Query to get active staff (not deleted)
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
                  "CASE WHEN dob = '0000-00-00' THEN NULL ELSE dob END AS 'Date Of Birth', " &
                  "job_title AS 'Job Title' " &
                  "FROM users WHERE status != 'deleted'"

            ' Query to count deleted users
            Dim deletedQuery As String = "SELECT COUNT(*) FROM users WHERE status = 'deleted';"

            ' Load staff data into DataGridView
            Using adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dvgStaffdetails.DataSource = dt
            End Using

            ' Execute deleted count query
            Using cmd As New MySqlCommand(deletedQuery, conn)
                Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblDeletedStaff.Text = deletedCount.ToString()
                If deletedCount = 0 Then
                    lblDeletedStaff.Visible = False
                End If
            End Using
        End Using


    End Sub


    Private Sub StaffControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStaff.Text = Queries.CountUsers()
        loadStaffData()
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' For editing
        Dim dialog As New AddStaffDialog()
        If dialog.ShowDialog() = DialogResult.OK Then
            loadStaffData()
        End If
    End Sub

    Private Sub DvgStaffdetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgStaffdetails.CellClick
        ' Ignore header clicks
        If e.RowIndex < 0 Then Exit Sub

        ' Get the ID from the selected row
        Dim selectedRow As DataGridViewRow = dvgStaffdetails.Rows(e.RowIndex)
        Dim staffId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

        ' Open the dialog with the selected staff ID
        Dim dialog As New AddStaffDialog()
        dialog.InitializeForm(staffId) ' Pass the selected ID

        If dialog.ShowDialog() = DialogResult.OK Then
            loadStaffData()
        End If
    End Sub
End Class

