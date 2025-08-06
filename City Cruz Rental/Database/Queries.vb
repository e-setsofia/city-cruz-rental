Public Class Queries
    Private Shared db As New DatabaseHelper()
    Public Shared Function CountUsers() As Integer

        Dim query As String = "SELECT COUNT(*) AS total_users FROM users"
        Dim result As DataTable = db.ExecuteQuery(query)

        Return Convert.ToInt32(result.Rows(0)("total_users"))
    End Function
    Public Shared Function CountVehicles() As Integer

        Dim query As String = "SELECT COUNT(*) AS total_vehicles FROM vehicles"
        Dim result As DataTable = db.ExecuteQuery(query)

        Return Convert.ToInt32(result.Rows(0)("total_vehicles"))
    End Function
    Public Shared Function CountVehiclesRented() As Integer

        Dim query As String = "SELECT COUNT(*) AS total_vehicles FROM vehicles WHERE state = 'Rented'"
        Dim result As DataTable = db.ExecuteQuery(query)

        ' Added text

        Return Convert.ToInt32(result.Rows(0)("total_vehicles"))
    End Function

    Public Shared Function ListVehicles() As DataTable
        Dim db As New DatabaseHelper()
        Dim query As String = "
            SELECT 
                v.id, 
                v.name, 
                v.brand_id, 
                b.name AS brand_name, 
                v.model, 
                v.rental_price, 
                v.state, 
                v.rating, 
                v.category_id, 
                c.name AS category_name
            FROM 
                vehicles v
            JOIN 
                brands b ON v.brand_id = b.id
            JOIN 
                categories c ON v.category_id = c.id"

        Dim result As DataTable = db.ExecuteQuery(query)

        ' Example: loop through and display results
        For Each row As DataRow In result.Rows
            Dim vehicleInfo As String = "ID: " & row("id") &
                ", Name: " & row("name") &
                ", Brand: " & row("brand_name") &
                ", Model: " & row("model") &
                ", Price: " & row("rental_price") &
                ", State: " & row("state") &
                ", Rating: " & row("rating") &
                ", Category: " & row("category_name")

            Console.WriteLine(vehicleInfo) ' Or bind to DataGridView
        Next
        Return result
    End Function

End Class
