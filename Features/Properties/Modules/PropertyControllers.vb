Imports MongoDB.Driver

Module PropertyControllers
    Public Sub AddPropertyDataRow(propertyM As PropertyM, table As Guna.UI2.WinForms.Guna2DataGridView)
        Dim newRow As DataGridViewRow = table.Rows(table.Rows.Add())
        newRow.Cells("ID").Value = propertyM.ID
        newRow.Cells("SquareMeter").Value = propertyM.SquareMeter
        newRow.Cells("Camenities").Value = propertyM.Amenities
        newRow.Cells("Description").Value = propertyM.Description
        newRow.Cells("Permit").Value = propertyM.Permit
        newRow.Cells("clDate").Value = propertyM.EstablishDate
    End Sub

    Public Function GetPropertiesData(table As Guna.UI2.WinForms.Guna2DataGridView) As List(Of PropertyM)
        Dim propertiesCollection = GetPropertiesCollection()
        Dim propertiesCursor = propertiesCollection.Find(FilterDefinition(Of PropertyM).Empty)
        Dim properties = propertiesCursor.ToList()

        For Each propertyM As PropertyM In properties
            AddPropertyDataRow(propertyM, table)
        Next

        Return properties
    End Function


End Module
