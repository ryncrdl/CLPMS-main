<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROPERTYMANAGEMENTADD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfloorsOcc = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfloors = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlessor = New MetroFramework.Controls.MetroTextBox()
        Me.txtproperty = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtimage = New MetroFramework.Controls.MetroTextBox()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(169, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Create Property"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.CadetBlue
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.LightSteelBlue
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(-37, -2)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(453, 47)
        Me.Guna2GradientPanel2.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Image FIle Name"
        '
        'txtfloorsOcc
        '
        '
        '
        '
        Me.txtfloorsOcc.CustomButton.Image = Nothing
        Me.txtfloorsOcc.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtfloorsOcc.CustomButton.Name = ""
        Me.txtfloorsOcc.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtfloorsOcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfloorsOcc.CustomButton.TabIndex = 1
        Me.txtfloorsOcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfloorsOcc.CustomButton.UseSelectable = True
        Me.txtfloorsOcc.CustomButton.Visible = False
        Me.txtfloorsOcc.Lines = New String(-1) {}
        Me.txtfloorsOcc.Location = New System.Drawing.Point(30, 270)
        Me.txtfloorsOcc.MaxLength = 32767
        Me.txtfloorsOcc.Name = "txtfloorsOcc"
        Me.txtfloorsOcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfloorsOcc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfloorsOcc.SelectedText = ""
        Me.txtfloorsOcc.SelectionLength = 0
        Me.txtfloorsOcc.SelectionStart = 0
        Me.txtfloorsOcc.ShortcutsEnabled = True
        Me.txtfloorsOcc.Size = New System.Drawing.Size(335, 30)
        Me.txtfloorsOcc.TabIndex = 162
        Me.txtfloorsOcc.UseSelectable = True
        Me.txtfloorsOcc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfloorsOcc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 16)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Floor Occupation"
        '
        'txtfloors
        '
        '
        '
        '
        Me.txtfloors.CustomButton.Image = Nothing
        Me.txtfloors.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtfloors.CustomButton.Name = ""
        Me.txtfloors.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtfloors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfloors.CustomButton.TabIndex = 1
        Me.txtfloors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfloors.CustomButton.UseSelectable = True
        Me.txtfloors.CustomButton.Visible = False
        Me.txtfloors.Lines = New String(-1) {}
        Me.txtfloors.Location = New System.Drawing.Point(30, 211)
        Me.txtfloors.MaxLength = 32767
        Me.txtfloors.Name = "txtfloors"
        Me.txtfloors.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfloors.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfloors.SelectedText = ""
        Me.txtfloors.SelectionLength = 0
        Me.txtfloors.SelectionStart = 0
        Me.txtfloors.ShortcutsEnabled = True
        Me.txtfloors.Size = New System.Drawing.Size(335, 30)
        Me.txtfloors.TabIndex = 160
        Me.txtfloors.UseSelectable = True
        Me.txtfloors.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfloors.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Floors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Lessor"
        '
        'txtlessor
        '
        '
        '
        '
        Me.txtlessor.CustomButton.Image = Nothing
        Me.txtlessor.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtlessor.CustomButton.Name = ""
        Me.txtlessor.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtlessor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtlessor.CustomButton.TabIndex = 1
        Me.txtlessor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtlessor.CustomButton.UseSelectable = True
        Me.txtlessor.CustomButton.Visible = False
        Me.txtlessor.Lines = New String(-1) {}
        Me.txtlessor.Location = New System.Drawing.Point(30, 151)
        Me.txtlessor.MaxLength = 32767
        Me.txtlessor.Name = "txtlessor"
        Me.txtlessor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlessor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlessor.SelectedText = ""
        Me.txtlessor.SelectionLength = 0
        Me.txtlessor.SelectionStart = 0
        Me.txtlessor.ShortcutsEnabled = True
        Me.txtlessor.Size = New System.Drawing.Size(335, 30)
        Me.txtlessor.TabIndex = 158
        Me.txtlessor.UseSelectable = True
        Me.txtlessor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtlessor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtproperty
        '
        '
        '
        '
        Me.txtproperty.CustomButton.Image = Nothing
        Me.txtproperty.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtproperty.CustomButton.Name = ""
        Me.txtproperty.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtproperty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtproperty.CustomButton.TabIndex = 1
        Me.txtproperty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtproperty.CustomButton.UseSelectable = True
        Me.txtproperty.CustomButton.Visible = False
        Me.txtproperty.Lines = New String(-1) {}
        Me.txtproperty.Location = New System.Drawing.Point(30, 89)
        Me.txtproperty.MaxLength = 32767
        Me.txtproperty.Name = "txtproperty"
        Me.txtproperty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproperty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtproperty.SelectedText = ""
        Me.txtproperty.SelectionLength = 0
        Me.txtproperty.SelectionStart = 0
        Me.txtproperty.ShortcutsEnabled = True
        Me.txtproperty.Size = New System.Drawing.Size(335, 30)
        Me.txtproperty.TabIndex = 156
        Me.txtproperty.UseSelectable = True
        Me.txtproperty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtproperty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Property Name"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancel.FillColor = System.Drawing.Color.DimGray
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(208, 389)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(157, 45)
        Me.BtnCancel.TabIndex = 151
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnAdd
        '
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.DimGray
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(30, 389)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(157, 45)
        Me.BtnAdd.TabIndex = 150
        Me.BtnAdd.Text = "Confirm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 146
        '
        'txtimage
        '
        '
        '
        '
        Me.txtimage.CustomButton.Image = Nothing
        Me.txtimage.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtimage.CustomButton.Name = ""
        Me.txtimage.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtimage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtimage.CustomButton.TabIndex = 1
        Me.txtimage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtimage.CustomButton.UseSelectable = True
        Me.txtimage.CustomButton.Visible = False
        Me.txtimage.Lines = New String(-1) {}
        Me.txtimage.Location = New System.Drawing.Point(30, 325)
        Me.txtimage.MaxLength = 32767
        Me.txtimage.Name = "txtimage"
        Me.txtimage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtimage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtimage.SelectedText = ""
        Me.txtimage.SelectionLength = 0
        Me.txtimage.SelectionStart = 0
        Me.txtimage.ShortcutsEnabled = True
        Me.txtimage.Size = New System.Drawing.Size(335, 30)
        Me.txtimage.TabIndex = 166
        Me.txtimage.UseSelectable = True
        Me.txtimage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtimage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PROPERTYMANAGEMENTADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 460)
        Me.Controls.Add(Me.txtimage)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfloorsOcc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtfloors)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlessor)
        Me.Controls.Add(Me.txtproperty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PROPERTYMANAGEMENTADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create new property"
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfloorsOcc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfloors As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlessor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtproperty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtimage As MetroFramework.Controls.MetroTextBox
End Class
