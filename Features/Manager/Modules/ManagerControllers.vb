Imports MongoDB.Driver

Module ManagerController
    Public Sub AddManagerDataRow(ManagerAccount As Accounts, table As Guna.UI2.WinForms.Guna2DataGridView)
        Dim newRow As DataGridViewRow = table.Rows(table.Rows.Add())
        newRow.Cells("ID").Value = ManagerAccount.ID
        newRow.Cells("FullName").Value = ManagerAccount.fullname
        newRow.Cells("CGender").Value = ManagerAccount.gender
        newRow.Cells("Email").Value = ManagerAccount.email
        newRow.Cells("Password").Value = ManagerAccount.password
    End Sub

    Public Function GetManagerData(table As Guna.UI2.WinForms.Guna2DataGridView) As List(Of Accounts)
        Dim managerCollection = GetMangerCollection()
        Dim managerCursor = managerCollection.Find(FilterDefinition(Of Accounts).Empty)
        Dim manager = managerCursor.ToList()

        For Each managerAccounts As Accounts In manager
            AddManagerDataRow(managerAccounts, table)
        Next

        Return manager
    End Function

End Module
