Imports MongoDB.Driver

Module ManagerControllers
    Public Sub AddLessorDataRow(Lessor_Account As Lessor_Account, table As Guna.UI2.WinForms.Guna2DataGridView)
        Dim newRow As DataGridViewRow = table.Rows(table.Rows.Add())
        newRow.Cells("ID").Value = Lessor_Account.ID
        newRow.Cells("FullName").Value = Lessor_Account.fullname
        newRow.Cells("CGender").Value = Lessor_Account.gender
        newRow.Cells("Email").Value = Lessor_Account.email
        newRow.Cells("Password").Value = Lessor_Account.password
    End Sub

    Public Function GetLessorData(table As Guna.UI2.WinForms.Guna2DataGridView) As List(Of Lessor_Account)
        Dim lessorCollection = GetLessorCollection()
        Dim lessorCursor = lessorCollection.Find(FilterDefinition(Of Lessor_Account).Empty)
        Dim lessor = lessorCursor.ToList()

        For Each Lessor_Account As Lessor_Account In lessor
            AddLessorDataRow(Lessor_Account, table)
        Next

        Return lessor
    End Function

End Module
