Imports MetroFramework.Controls
Imports MongoDB.Driver

Public Class PROPERTYMANAGEMENT
    Private data As List(Of MetroTextBox)
    Dim properySet As New PropertyM()
    Private ReadOnly _database As IMongoDatabase
    Private Sub PROPERTYMANAGEMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TableProperty.DataSource = GetPropertiesData()
        data = New List(Of MetroTextBox) From {square_meter, Amenities, txtdescription, txtpermit}
        ' AddPropertyDataRow(properySet, TableProperty)

        GetPropertiesData(TableProperty)
    End Sub
    Public Sub New()
        InitializeComponent()
        _database = Connection.GetMongoDatabase()
    End Sub

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
        PROPERTYMANAGEMENTADD.ShowDialog()
    End Sub

    Private Sub TablePropery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableProperty.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < TableProperty.Rows.Count Then
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = TableProperty.Rows(e.RowIndex)
            square_meter.Text = selectedRow.Cells("SquareMeter").Value.ToString()
            Amenities.Text = selectedRow.Cells("Camenities").Value.ToString()
            txtdescription.Text = selectedRow.Cells("Description").Value.ToString()
            txtpermit.Text = selectedRow.Cells("Permit").Value.ToString()
            txtdate.Text = selectedRow.Cells("clDate").Value.ToString()
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Try
            Dim selectedRowIndex As Integer = TableProperty.CurrentCell.RowIndex

            If selectedRowIndex >= 0 AndAlso TableProperty.Rows.Count > selectedRowIndex Then
                Dim selectedRow As DataGridViewRow = TableProperty.Rows(selectedRowIndex)

                ' Make sure the column name "ID" matches the actual column name in your Guna2DataGridView
                Dim propertyId As String = selectedRow.Cells("ID").Value.ToString()

                Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this property?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim propertiesCollection = Connection.GetPropertiesCollection()

                    Dim filter = Builders(Of PropertyM).Filter.Eq(Function(a) a.ID, propertyId)
                    Dim deleteResult = propertiesCollection.DeleteOne(filter)

                    If deleteResult.DeletedCount > 0 Then
                        MessageBox.Show("Property deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        TableProperty.Rows.Clear()
                        GetPropertiesData(TableProperty)
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
        ValidatePropertyData(data, validData)

        If (validData) Then
            Dim selectedRowIndex As Integer = TableProperty.CurrentCell.RowIndex

            If selectedRowIndex >= 0 AndAlso TableProperty.Rows.Count > selectedRowIndex Then
                Dim selectedRow As DataGridViewRow = TableProperty.Rows(selectedRowIndex)

                ' Get the ID of the selected admin from the first cell of the row
                Dim propertyId As String = selectedRow.Cells("ID").Value.ToString()

                ' Retrieve the existing admin data from MongoDB
                Dim propertiesCollection = Connection.GetPropertiesCollection()

                ' Use the adminID as a string directly in the lambda expression
                Dim filter = Builders(Of PropertyM).Filter.Eq(Function(a) a.ID, propertyId)
                Dim existingProperty = propertiesCollection.Find(filter).FirstOrDefault()

                If existingProperty IsNot Nothing Then
                    ' Update the Admin object with the data from the textboxes
                    existingProperty.SquareMeter = square_meter.Text
                    existingProperty.Amenities = Amenities.Text
                    existingProperty.Description = txtdescription.Text
                    existingProperty.Permit = txtpermit.Text
                    existingProperty.EstablishDate = txtdate.Value

                    ' Update the admin data in the MongoDB collection
                    propertiesCollection.ReplaceOne(filter, existingProperty)

                    MessageBox.Show("Property updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    TableProperty.Rows.Clear()
                    GetPropertiesData(TableProperty)
                    ClearData()
                Else
                    MessageBox.Show("Property not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


    End Sub
End Class