Imports MetroFramework.Controls
Public Class PROPERTYMANAGEMENTADD
    Private data As List(Of MetroTextBox)
    Private newMetroId As New MetroTextBox
    Dim properySet As New properties()

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim validData As Boolean = True
        Validation2.ValidatePropertyData(data, validData)

        Try
            If (validData) Then
                Dim sq As Integer
                If Not Integer.TryParse(txtproperty.Text, sq) Or sq <= 0 Then
                    MessageBox.Show("Please enter a valid square meter.", "Invalid Square Meter", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim propertyName As String = txtproperty.Text
                    Dim lessor As String = txtlessor.Text
                    Dim floors As String = txtfloors.Text
                    Dim floorsOccu As String = txtfloorsOcc.Text
                    Dim imageName As String = txtimage.Text


                    Dim properties As New properties With {
                    .propertyname = propertyName,
                    .lessor = lessor,
                    .floors = floors,
                    .floorOcu = floorsOccu,
                    .userImage = imageName
                }

                    Dim propertiesCollection = Connection.GetPropertiesCollection()
                        propertiesCollection.InsertOne(properties)

                        MessageBox.Show("Property added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearTextBox(data)
                        Me.Close()
                        ' Refresh the DataGridView with the latest data               
                        AddPropertyDataRow(properties, PROPERTYMANAGEMENT.TableProperty)

                    'GetPropertiesData(PROPERTYMANAGEMENT.TableProperty)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        ClearTextBox(data)
    End Sub

    Private Sub PROPERTYMANAGEMENTADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newMetroId.Text = "ID"
        data = New List(Of MetroTextBox) From {newMetroId, txtproperty, txtlessor, txtfloors, txtfloorsOcc, txtimage}
    End Sub
End Class