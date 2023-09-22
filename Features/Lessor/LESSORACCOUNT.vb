Imports MetroFramework.Controls
Imports MongoDB.Driver

Public Class LESSORACCOUNT
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Private columnsName As List(Of String)
    Private data As List(Of MetroTextBox)
    Private gender As List(Of MetroComboBox)

    Private ReadOnly _database As IMongoDatabase

    Public Sub New()
        InitializeComponent()
        _database = Connection.GetMongoDatabase()
    End Sub

    Private Sub LESSORACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gender = New List(Of MetroComboBox) From {txtgender}
        data = New List(Of MetroTextBox) From {txtid, txtname, txtemail, txtpassword}

        GetLessorData(TableLessor)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTextBox(data)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyLessee(data, gender, validData)

        If (TableLessor.Rows.Count > 0) Then
            If (validData) Then
                Dim selectedRowIndex As Integer = TableLessor.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso TableLessor.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = TableLessor.Rows(selectedRowIndex)

                    Dim lessorID As String = selectedRow.Cells("ID").Value.ToString()

                    Dim lessorCollection = Connection.GetLessorCollection()

                    Dim filter = Builders(Of Lessor_Account).Filter.Eq(Function(a) a.ID, lessorID)
                    Dim existingLessor = lessorCollection.Find(filter).FirstOrDefault()

                    If existingLessor IsNot Nothing Then
                        existingLessor.fullname = txtname.Text
                        existingLessor.gender = txtgender.Text
                        existingLessor.email = txtemail.Text
                        existingLessor.password = txtpassword.Text

                        lessorCollection.ReplaceOne(filter, existingLessor)

                        MessageBox.Show("Lessor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        TableLessor.Rows.Clear()
                        GetLessorData(TableLessor)
                    Else
                        MessageBox.Show("Lessor not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TableLessor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableLessor.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < TableLessor.Rows.Count Then
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = TableLessor.Rows(e.RowIndex)
            txtid.Text = selectedRow.Cells("ID").Value.ToString()
            txtname.Text = selectedRow.Cells("FullName").Value.ToString()
            txtgender.Text = selectedRow.Cells("CGender").Value.ToString()
            txtemail.Text = selectedRow.Cells("Email").Value.ToString()
            txtpassword.Text = selectedRow.Cells("Password").Value.ToString()
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim id As String = txtid.Text

        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                Dim selectedRowIndex As Integer = TableLessor.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso TableLessor.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = TableLessor.Rows(selectedRowIndex)

                    Dim lessorID As String = selectedRow.Cells("ID").Value.ToString()


                    Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this lessee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmationResult = DialogResult.Yes Then

                        Dim lessorCollection = Connection.GetLessorCollection()


                        Dim filter = Builders(Of Lessor_Account).Filter.Eq(Function(a) a.ID, lessorID)
                        Dim deleteResult = lessorCollection.DeleteOne(filter)

                        If deleteResult.DeletedCount > 0 Then
                            MessageBox.Show("Lessor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            TableLessor.Rows.Clear()
                            GetLessorData(TableLessor)
                            ClearTextBox(data)
                        Else
                            MessageBox.Show("Lessor not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while removing the Lessor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class