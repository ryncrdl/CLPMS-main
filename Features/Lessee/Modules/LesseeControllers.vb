Imports MongoDB.Driver

Module LesseeController
    Public Sub AddLesseeDataRow(Lessee_Account As Lessee_Account, table As Guna.UI2.WinForms.Guna2DataGridView)
        Dim newRow As DataGridViewRow = table.Rows(table.Rows.Add())
        newRow.Cells("ID").Value = Lessee_Account.ID
        newRow.Cells("FullName").Value = Lessee_Account.fullname
        newRow.Cells("CGender").Value = Lessee_Account.gender
        newRow.Cells("Email").Value = Lessee_Account.email
        newRow.Cells("Password").Value = Lessee_Account.password
    End Sub

    Public Function GetLesseeData(table As Guna.UI2.WinForms.Guna2DataGridView) As List(Of Lessee_Account)
        Dim lesseeCollection = GetLesseeCollection()
        Dim lesseeCursor = lesseeCollection.Find(FilterDefinition(Of Lessee_Account).Empty)
        Dim lessee = lesseeCursor.ToList()

        For Each Lessee_Account As Lessee_Account In lessee
            AddLesseeDataRow(Lessee_Account, table)
        Next

        Return lessee
    End Function

End Module
