Imports System.Net
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports CLPMS.Validation1
Imports CLPMS.SwitchingPanels
Imports MetroFramework.Controls
Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes
Imports MongoDB.Driver
Imports CLPMS.ADMINREGISISTRATION

Public Class LESSEE
    Private MetroTextBox As MetroFramework.Controls.MetroTextBox
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Private data As List(Of MetroTextBox)
    Private gender As List(Of MetroComboBox)
    Private columnsName As List(Of String)

    Private ReadOnly _database As IMongoDatabase

    Public Sub New()
        InitializeComponent()
        _database = Connection.GetMongoDatabase()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs)
        ValidateFieldsNotEmpty(data)
    End Sub

    Private Sub LESSEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gender = New List(Of MetroComboBox) From {txtgender}
        data = New List(Of MetroTextBox) From {txtid, txtname, txtemail, txtpassword}

        GetLesseeData(TableLessee)
    End Sub


    Private Sub BtnRemove_Click(sender As Object, e As EventArgs)
        DeleteData(txtid, data)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        ClearTextBox(data)
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs)
        SwitchPanel(DASHBOARD.Panel2, PROPERTYMANAGEMENT)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnUpdt.Click
        Dim validData As Boolean = True
        ValidateFieldsNotEmptyLessee(data, gender, validData)

        If (TableLessee.Rows.Count > 0) Then
            If (validData) Then
                Dim selectedRowIndex As Integer = TableLessee.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso TableLessee.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = TableLessee.Rows(selectedRowIndex)

                    Dim lesseeID As String = selectedRow.Cells("ID").Value.ToString()

                    Dim lesseeCollection = Connection.GetLesseeCollection()

                    Dim filter = Builders(Of Lessee_Account).Filter.Eq(Function(a) a.ID, lesseeID)
                    Dim existingLessee = lesseeCollection.Find(filter).FirstOrDefault()

                    If existingLessee IsNot Nothing Then
                        existingLessee.fullname = txtname.Text
                        existingLessee.gender = txtgender.Text
                        existingLessee.email = txtemail.Text
                        existingLessee.password = txtpassword.Text

                        lesseeCollection.ReplaceOne(filter, existingLessee)

                        MessageBox.Show("Lessee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        TableLessee.Rows.Clear()
                        GetLesseeData(TableLessee)
                    Else
                        MessageBox.Show("Lessee not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        Dim id As String = txtid.Text

        If String.IsNullOrEmpty(id) Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                Dim selectedRowIndex As Integer = TableLessee.CurrentCell.RowIndex

                If selectedRowIndex >= 0 AndAlso TableLessee.Rows.Count > selectedRowIndex Then
                    Dim selectedRow As DataGridViewRow = TableLessee.Rows(selectedRowIndex)

                    Dim lesseeID As String = selectedRow.Cells("ID").Value.ToString()


                    Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this lessee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmationResult = DialogResult.Yes Then

                        Dim leseeCollection = Connection.GetLesseeCollection()


                        Dim filter = Builders(Of Lessee_Account).Filter.Eq(Function(a) a.ID, lesseeID)
                        Dim deleteResult = leseeCollection.DeleteOne(filter)

                        If deleteResult.DeletedCount > 0 Then
                            MessageBox.Show("Lessee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            TableLessee.Rows.Clear()
                            GetLesseeData(TableLessee)
                            ClearTextBox(data)
                        Else
                            MessageBox.Show("Lessee not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while removing the Lessee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTextBox(data)
    End Sub

    Private Sub BtnViewProperty_Click(sender As Object, e As EventArgs) Handles BtnViewProperty.Click
        SwitchPanel(DASHBOARD.Panel2, PROPERTYMANAGEMENT)
    End Sub

    Private Sub TableLessee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableLessee.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < TableLessee.Rows.Count Then
            ' Get the selected row's data
            Dim selectedRow As DataGridViewRow = TableLessee.Rows(e.RowIndex)
            txtid.Text = selectedRow.Cells("ID").Value.ToString()
            txtname.Text = selectedRow.Cells("FullName").Value.ToString()
            txtgender.Text = selectedRow.Cells("CGender").Value.ToString()
            txtemail.Text = selectedRow.Cells("Email").Value.ToString()
            txtpassword.Text = selectedRow.Cells("Password").Value.ToString()
        End If
    End Sub

End Class