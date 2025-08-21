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

    Public Function ExecuteScalar(sqlQuery As String) As String
        Dim result As String
        Try
            Using conn As New MySqlConnection(My.Resources.conn)
                Using cmd As New MySqlCommand(sqlQuery, conn)
                    result = cmd.ExecuteScalar()
                End Using
            End Using
            Return result
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Function


    ''' <summary>
    ''' Executes an SQL command that does not return any data (e.g., INSERT, UPDATE, DELETE).
    ''' </summary>
    ''' <param name="sqlQuery">The SQL command to execute.</param>
    ''' <param name="parameters">List of parameters for the command.</param>
    ''' <returns>Number of affected rows.</returns>
    Public Function ExecuteNonQuery(sqlQuery As String, parameters As List(Of MySqlParameter)) As Integer
        Dim rowsAffected As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(sqlQuery, connection)
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters.ToArray())
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Return rowsAffected
    End Function

End Class
