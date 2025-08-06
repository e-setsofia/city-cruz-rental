Public Class CustomerControl



    Private Sub LoadData()
        dtgCustomers.DataSource = Queries.GetAllCustomers

        ' Set the column headers
        dtgCustomers.Columns("fullName").HeaderText = "Full name"
        dtgCustomers.Columns("email").HeaderText = "Email"
        dtgCustomers.Columns("phone_number").HeaderText = "Phone"
        dtgCustomers.Columns("address").HeaderText = "Address"
        dtgCustomers.Columns("city").HeaderText = "City"
        dtgCustomers.Columns("created_at").HeaderText = "Date joined"


        ' Hidden data
        dtgCustomers.Columns("customer_id").Visible = False
        dtgCustomers.Columns("fName").Visible = False
        dtgCustomers.Columns("lName").Visible = False
        dtgCustomers.Columns("driver_license_number").Visible = False
        dtgCustomers.Columns("license_expiry_date").Visible = False
        dtgCustomers.Columns("date_of_birth").Visible = False
        dtgCustomers.Columns("status").Visible = False
        dtgCustomers.Columns("country").Visible = False
        dtgCustomers.Columns("postal_code").Visible = False
        dtgCustomers.Columns("updated_at").Visible = False
    End Sub

    Private Sub CustomerControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class
