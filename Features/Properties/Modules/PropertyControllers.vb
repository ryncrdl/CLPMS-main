Imports MongoDB.Driver

Module LesseeControllers
    Public Sub AddPropertyDataRow(properties As properties, table As Guna.UI2.WinForms.Guna2DataGridView)
        Dim newRow As DataGridViewRow = table.Rows(table.Rows.Add())
        newRow.Cells("ID").Value = properties.ID
        newRow.Cells("PropertyName").Value = properties.propertyname
        newRow.Cells("Lessor").Value = properties.lessor
        newRow.Cells("Floors").Value = properties.floors
        newRow.Cells("FloorOccu").Value = properties.floorOcu
        newRow.Cells("Image").Value = properties.userImage
    End Sub

    Public Function GetPropertiesData(table As Guna.UI2.WinForms.Guna2DataGridView) As List(Of properties)
        Dim propertiesCollection = GetPropertiesCollection()
        Dim propertiesCursor = propertiesCollection.Find(FilterDefinition(Of properties).Empty)
        Dim properties = propertiesCursor.ToList()

        For Each propertyM As properties In properties
            AddPropertyDataRow(propertyM, table)
        Next

        Return properties
    End Function


End Module
