Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DatabaseHelper
    Private connectionString As String = My.Resources.conn

    ''' <summary>
    ''' Executes an SQL command and returns the result as a DataTable.
    ''' </summary>
    ''' <param name="sqlQuery">The SQL command to execute.</param>
    ''' <returns>A DataTable containing the results of the query.</returns>
    Public Function ExecuteQuery(sqlQuery As String) As DataTable
        Dim dt As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Create a command object
                Dim cmd As New MySqlCommand(sqlQuery, connection)

                ' Create a DataAdapter to fill the DataTable
                Dim adapter As New MySqlDataAdapter(cmd)

                ' Fill the DataTable with the result of the query
                adapter.Fill(dt)

            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function
End Class
