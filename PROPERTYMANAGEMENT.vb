Imports CLPMS.ADMINREGISISTRATION
Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes
Imports MongoDB.Driver

Public Class PROPERTYMANAGEMENT


    Private ReadOnly _database As IMongoDatabase
    Private Sub PROPERTYMANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DataGridView1.DataSource = GetPropertiesData()
    End Sub


    Public Sub New()
        InitializeComponent()
        _database = Connection1.GetMongoDatabase()
        'columnsName = New List(Of String) From {"ID", "Name", "Age", "Email", "Contact", "Address", "Username", "Password"}
        ' If Connection1.IsConnected() Then
        'MessageBox.Show("Connected to MongoDB successfully!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Else
        'MessageBox.Show("Failed to connect to MongoDB.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Public Class PropertyM
        <BsonId>
        <BsonRepresentation(BsonType.ObjectId)>
        Public Property ID As String
        Public Property SquareMeter As Integer
        Public Property Amenities As Integer
        Public Property Description As String
        Public Property Permit As String
        Public Property EstablishDate As Date
    End Class

    Public Function GetPropertiesData() As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("ID", GetType(String))
        dataTable.Columns.Add("Square Meter", GetType(String))
        dataTable.Columns.Add("Amenities", GetType(Integer))
        dataTable.Columns.Add("Description", GetType(String))
        dataTable.Columns.Add("Permit", GetType(String))
        dataTable.Columns.Add("Date", GetType(String))

        Dim propertiesCollection = Connection1.GetPropertiesCollection()
        Dim propertiesCursor = propertiesCollection.Find(FilterDefinition(Of PropertyM).Empty)
        Dim properties = propertiesCursor.ToList()

        For Each propertyM As PropertyM In properties
            dataTable.Rows.Add(propertyM.ID, propertyM.SquareMeter, propertyM.Amenities, propertyM.Description, propertyM.Permit, propertyM.EstablishDate)
        Next

        Return dataTable
    End Function

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If MetroComboBox1.Text = "Available Properties" Then
            Guna2Button1.Visible = True
            Guna2Button3.Visible = True
            ' Guna2Button5.Visible = False
        ElseIf MetroComboBox1.Text = "Occupied Properties" Then
            Guna2Button1.Visible = False
            Guna2Button3.Visible = False
            ' Guna2Button5.Visible = True
        End If
    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PROPERTYMANAGEMENTADD.Show()
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < Guna2DataGridView1.Rows.Count Then
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            square_meter.Text = selectedRow.Cells("Square Meter").Value.ToString()
            Amenities.Text = selectedRow.Cells("Amenities").Value.ToString()
            txtdescription.Text = selectedRow.Cells("Description").Value.ToString()
            txtpermit.Text = selectedRow.Cells("Permit").Value.ToString()
            txtdate.Text = selectedRow.Cells("Date").Value.ToString()
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Try
            Dim selectedRowIndex As Integer = Guna2DataGridView1.CurrentCell.RowIndex

            If selectedRowIndex >= 0 AndAlso Guna2DataGridView1.Rows.Count > selectedRowIndex Then
                Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(selectedRowIndex)

                ' Make sure the column name "ID" matches the actual column name in your Guna2DataGridView
                Dim propertyId As String = selectedRow.Cells("ID").Value.ToString()

                Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this property?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim propertiesCollection = Connection1.GetPropertiesCollection()

                    Dim filter = Builders(Of PROPERTYMANAGEMENT.PropertyM).Filter.Eq(Function(a) a.ID, propertyId)
                    Dim deleteResult = propertiesCollection.DeleteOne(filter)

                    If deleteResult.DeletedCount > 0 Then
                        MessageBox.Show("Property deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Guna2DataGridView1.DataSource = GetPropertiesData()
                        ClearData()
                    Else
                        MessageBox.Show("Propery not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                MessageBox.Show("Please select a valid row to delete.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while removing the property: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ClearData()
        square_meter.Clear()
        Amenities.Clear()
        txtdescription.Clear()
        txtpermit.Clear()
        txtdate.ResetText()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyAdmin(Data, validData)

        Dim selectedRowIndex As Integer = Guna2DataGridView1.CurrentCell.RowIndex

        If selectedRowIndex >= 0 AndAlso Guna2DataGridView1.Rows.Count > selectedRowIndex Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(selectedRowIndex)

            ' Get the ID of the selected admin from the first cell of the row
            Dim adminID As String = selectedRow.Cells("ID").Value.ToString()

            ' Retrieve the existing admin data from MongoDB
            Dim adminsCollection = Connection1.GetAdminsCollection()

            ' Use the adminID as a string directly in the lambda expression
            Dim filter = Builders(Of Admin).Filter.Eq(Function(a) a.ID, adminID)
            Dim existingAdmin = adminsCollection.Find(filter).FirstOrDefault()

            If existingAdmin IsNot Nothing Then
                ' Update the Admin object with the data from the textboxes
                existingAdmin.Name = txtname.Text
                existingAdmin.Age = Integer.Parse(txtage.Text)
                existingAdmin.Email = txtemail.Text
                existingAdmin.Contact = txtcontact.Text
                existingAdmin.Address = txtaddress.Text
                existingAdmin.Username = txtusername.Text
                existingAdmin.Password = txtpassword.Text

                ' Update the admin data in the MongoDB collection
                adminsCollection.ReplaceOne(filter, existingAdmin)

                MessageBox.Show("Admin updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView with the latest data
                Guna2DataGridView1.DataSource = GetAdminsData()
            Else
                MessageBox.Show("Admin not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class