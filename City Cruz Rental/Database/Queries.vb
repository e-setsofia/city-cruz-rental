Imports MySql.Data.MySqlClient

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
                v.number_plate,
                v.rental_price, 
                v.state, 
                v.rating,
                v.image,
                v.category_id, 
                c.name AS category_name
            FROM 
                vehicles v
            JOIN 
                brands b ON v.brand_id = b.id
            JOIN 
                categories c ON v.category_id = c.id
            WHERE state != 'Deleted'
"

        Dim result As DataTable = db.ExecuteQuery(query)

        Return result
    End Function


    Public Shared Function ListBookedVehicles() As DataTable
        Dim db As New DatabaseHelper()
        Dim query As String = "
           SELECT 
                r.id AS rental_id,
                v.name AS vehicle_name,
                v.model AS vehicle_model,
                v.rental_price,
                c.fName AS customer_first_name,
                c.email AS customer_email,
                u.fname AS staff_first_name,
                r.start_date,
                r.end_date,
                r.status,
                r.return_date
            FROM 
                rentals r
            JOIN 
                vehicles v ON r.vehicle_id = v.id
            JOIN 
                customers c ON r.customer_id = c.customer_id
            LEFT JOIN 
                users u ON r.staff_user_id = u.id
            WHERE 
                r.return_date IS NULL
                OR r.status != 'Returned'
            ORDER BY 
                r.start_date DESC;
            "

        Dim result As DataTable = db.ExecuteQuery(query)

        Return result
    End Function


    ' CUSTOMER TABLE


    Public Shared Function InsertCustomer(
    fName As String,
    lName As String,
    email As String,
    phoneNumber As String,
    driverLicenseNumber As String,
    licenseExpiryDate As Date,
    dateOfBirth As Date,
    address As String,
    city As String,
    status As String,
    postalCode As String,
    country As String
) As Boolean

        Dim query As String = "
        INSERT INTO customers (
            fName, lName, email, phone_number, driver_license_number,
            license_expiry_date, date_of_birth, address, city, status,
            postal_code, country
        )
        VALUES (
            @fName, @lName, @Email, @PhoneNumber, @DriverLicenseNumber,
            @LicenseExpiryDate, @DateOfBirth, @Address, @City, @Status,
            @PostalCode, @Country
        )"

        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@fName", fName),
        New MySqlParameter("@lName", lName),
        New MySqlParameter("@Email", email),
        New MySqlParameter("@PhoneNumber", phoneNumber),
        New MySqlParameter("@DriverLicenseNumber", driverLicenseNumber),
        New MySqlParameter("@LicenseExpiryDate", licenseExpiryDate),
        New MySqlParameter("@DateOfBirth", dateOfBirth),
        New MySqlParameter("@Address", address),
        New MySqlParameter("@City", city),
        New MySqlParameter("@Status", status),
        New MySqlParameter("@PostalCode", postalCode),
        New MySqlParameter("@Country", country)
    }

        Try
            Dim rowsAffected As Integer = db.ExecuteNonQuery(query, parameters)
            Return rowsAffected > 0
        Catch ex As Exception
            ' Optional: log error
            Return False
        End Try

    End Function

    Public Shared Function GetAllCustomers() As DataTable
        Dim query As String = "SELECT customer_id, concat(fName, ' ', lName) as fullName, fName, lName,  email, phone_number, driver_license_number, license_expiry_date, date_of_birth, address, city, status, postal_code, country, created_at, updated_at 
            FROM customers ORDER BY customer_id"
        Dim result As DataTable = db.ExecuteQuery(query)
        Return result
    End Function



End Class
