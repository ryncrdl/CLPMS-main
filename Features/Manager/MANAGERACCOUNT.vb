Imports MetroFramework.Controls
Imports MongoDB.Driver

Public Class MANAGERACCOUNT
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Private columnsName As List(Of String)
    Private data As List(Of MetroTextBox)
    Private gender As List(Of MetroComboBox)

    Private ReadOnly _database As IMongoDatabase

    Public Sub New()
        InitializeComponent()
        _database = Connection.GetMongoDatabase()
    End Sub
    Private Sub MANAGERACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gender = New List(Of MetroComboBox) From {txtgender}
        data = New List(Of MetroTextBox) From {txtid, txtname, txtemail, txtpassword}

        GetManagerData(TableManager)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTextBox(data)
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim id As String = txtid.Text

        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                Dim selectedRowIndex As Integer = TableManager.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso TableManager.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = TableManager.Rows(selectedRowIndex)

                    Dim managerID As String = selectedRow.Cells("ID").Value.ToString()


                    Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this lessee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmationResult = DialogResult.Yes Then

                        Dim managerCollection = Connection.GetMangerCollection()


                        Dim filter = Builders(Of Accounts).Filter.Eq(Function(a) a.ID, managerID)
                        Dim deleteResult = managerCollection.DeleteOne(filter)

                        If deleteResult.DeletedCount > 0 Then
                            MessageBox.Show("Lessor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            TableManager.Rows.Clear()
                            GetManagerData(TableManager)
                            ClearTextBox(data)
                        Else
                            MessageBox.Show("Manager not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while removing the Manager: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnUpdateManager_Click(sender As Object, e As EventArgs) Handles BtnUpdateManager.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyLessee(data, gender, validData)

        If (TableManager.Rows.Count > 0) Then
            If (validData) Then
                Dim selectedRowIndex As Integer = TableManager.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso TableManager.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = TableManager.Rows(selectedRowIndex)

                    Dim managerID As String = selectedRow.Cells("ID").Value.ToString()

                    Dim managerCollection = Connection.GetMangerCollection()

                    Dim filter = Builders(Of Accounts).Filter.Eq(Function(a) a.ID, managerID)
                    Dim existingManager = managerCollection.Find(filter).FirstOrDefault()

                    If existingManager IsNot Nothing Then
                        existingManager.fullname = txtname.Text
                        existingManager.gender = txtgender.Text
                        existingManager.email = txtemail.Text
                        existingManager.password = txtpassword.Text

                        managerCollection.ReplaceOne(filter, existingManager)

                        MessageBox.Show("Manager updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        TableManager.Rows.Clear()
                        GetManagerData(TableManager)
                    Else
                        MessageBox.Show("Manager not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TableManager_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableManager.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < TableManager.Rows.Count Then
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = TableManager.Rows(e.RowIndex)
            txtid.Text = selectedRow.Cells("ID").Value.ToString()
            txtname.Text = selectedRow.Cells("FullName").Value.ToString()
            txtgender.Text = selectedRow.Cells("CGender").Value.ToString()
            txtemail.Text = selectedRow.Cells("Email").Value.ToString()
            txtpassword.Text = selectedRow.Cells("Password").Value.ToString()
        End If
    End Sub
End Class