<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PROPERTYMANAGEMENT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.txtfloors = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlessor = New MetroFramework.Controls.MetroTextBox()
        Me.txtproperty = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfloorocc = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableProperty = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lessor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Floors = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorOccu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.BtnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtimage = New MetroFramework.Controls.MetroTextBox()
        Me.txtid = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TableProperty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.BackColor = System.Drawing.Color.LightGreen
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(220, 2)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(642, 22)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "Search..."
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(248, 30)
        Me.MetroTextBox1.TabIndex = 106
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Search..."
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, -9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 105
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Available Properties", "Occupied Properties"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(54, 91)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(203, 29)
        Me.MetroComboBox1.TabIndex = 120
        Me.MetroComboBox1.UseSelectable = True
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
        Me.txtfloors.Location = New System.Drawing.Point(55, 344)
        Me.txtfloors.MaxLength = 32767
        Me.txtfloors.Name = "txtfloors"
        Me.txtfloors.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfloors.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfloors.SelectedText = ""
        Me.txtfloors.SelectionLength = 0
        Me.txtfloors.SelectionStart = 0
        Me.txtfloors.ShortcutsEnabled = True
        Me.txtfloors.Size = New System.Drawing.Size(335, 30)
        Me.txtfloors.TabIndex = 132
        Me.txtfloors.UseSelectable = True
        Me.txtfloors.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfloors.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Floors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 129
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
        Me.txtlessor.Location = New System.Drawing.Point(55, 284)
        Me.txtlessor.MaxLength = 32767
        Me.txtlessor.Name = "txtlessor"
        Me.txtlessor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlessor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtlessor.SelectedText = ""
        Me.txtlessor.SelectionLength = 0
        Me.txtlessor.SelectionStart = 0
        Me.txtlessor.ShortcutsEnabled = True
        Me.txtlessor.Size = New System.Drawing.Size(335, 30)
        Me.txtlessor.TabIndex = 130
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
        Me.txtproperty.Location = New System.Drawing.Point(55, 222)
        Me.txtproperty.MaxLength = 32767
        Me.txtproperty.Name = "txtproperty"
        Me.txtproperty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproperty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtproperty.SelectedText = ""
        Me.txtproperty.SelectionLength = 0
        Me.txtproperty.SelectionStart = 0
        Me.txtproperty.ShortcutsEnabled = True
        Me.txtproperty.Size = New System.Drawing.Size(335, 30)
        Me.txtproperty.TabIndex = 128
        Me.txtproperty.UseSelectable = True
        Me.txtproperty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtproperty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "Property Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Image File Name"
        '
        'txtfloorocc
        '
        '
        '
        '
        Me.txtfloorocc.CustomButton.Image = Nothing
        Me.txtfloorocc.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtfloorocc.CustomButton.Name = ""
        Me.txtfloorocc.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtfloorocc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtfloorocc.CustomButton.TabIndex = 1
        Me.txtfloorocc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtfloorocc.CustomButton.UseSelectable = True
        Me.txtfloorocc.CustomButton.Visible = False
        Me.txtfloorocc.Lines = New String(-1) {}
        Me.txtfloorocc.Location = New System.Drawing.Point(55, 403)
        Me.txtfloorocc.MaxLength = 32767
        Me.txtfloorocc.Name = "txtfloorocc"
        Me.txtfloorocc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfloorocc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtfloorocc.SelectedText = ""
        Me.txtfloorocc.SelectionLength = 0
        Me.txtfloorocc.SelectionStart = 0
        Me.txtfloorocc.ShortcutsEnabled = True
        Me.txtfloorocc.Size = New System.Drawing.Size(335, 30)
        Me.txtfloorocc.TabIndex = 134
        Me.txtfloorocc.UseSelectable = True
        Me.txtfloorocc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtfloorocc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 16)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Floor Occupation"
        '
        'TableProperty
        '
        Me.TableProperty.AllowUserToAddRows = False
        Me.TableProperty.AllowUserToDeleteRows = False
        Me.TableProperty.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.TableProperty.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TableProperty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableProperty.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TableProperty.ColumnHeadersHeight = 30
        Me.TableProperty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.PropertyName, Me.Lessor, Me.Floors, Me.FloorOccu, Me.Image})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableProperty.DefaultCellStyle = DataGridViewCellStyle6
        Me.TableProperty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TableProperty.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableProperty.Location = New System.Drawing.Point(441, 58)
        Me.TableProperty.Name = "TableProperty"
        Me.TableProperty.ReadOnly = True
        Me.TableProperty.RowHeadersVisible = False
        Me.TableProperty.ShowEditingIcon = False
        Me.TableProperty.Size = New System.Drawing.Size(449, 366)
        Me.TableProperty.TabIndex = 213
        Me.TableProperty.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TableProperty.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TableProperty.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TableProperty.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TableProperty.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TableProperty.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TableProperty.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableProperty.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableProperty.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TableProperty.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableProperty.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TableProperty.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TableProperty.ThemeStyle.HeaderStyle.Height = 30
        Me.TableProperty.ThemeStyle.ReadOnly = True
        Me.TableProperty.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TableProperty.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TableProperty.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableProperty.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TableProperty.ThemeStyle.RowsStyle.Height = 22
        Me.TableProperty.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableProperty.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 41
        '
        'PropertyName
        '
        Me.PropertyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PropertyName.HeaderText = "Property Name"
        Me.PropertyName.Name = "PropertyName"
        Me.PropertyName.ReadOnly = True
        '
        'Lessor
        '
        Me.Lessor.HeaderText = "Lessor"
        Me.Lessor.Name = "Lessor"
        Me.Lessor.ReadOnly = True
        Me.Lessor.Width = 61
        '
        'Floors
        '
        Me.Floors.HeaderText = "Floors"
        Me.Floors.Name = "Floors"
        Me.Floors.ReadOnly = True
        Me.Floors.Width = 58
        '
        'FloorOccu
        '
        Me.FloorOccu.HeaderText = "Floor Occupation"
        Me.FloorOccu.Name = "FloorOccu"
        Me.FloorOccu.ReadOnly = True
        Me.FloorOccu.Width = 102
        '
        'Image
        '
        Me.Image.HeaderText = "Image"
        Me.Image.Name = "Image"
        Me.Image.ReadOnly = True
        Me.Image.Width = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(50, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Property Management"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderThickness = 0
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.SkyBlue
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-58, 13)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(410, 56)
        Me.Guna2Shapes1.TabIndex = 248
        Me.Guna2Shapes1.Text = "asdasdasd"
        Me.Guna2Shapes1.Zoom = 80
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.Transparent
        Me.BtnRemove.BorderRadius = 20
        Me.BtnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRemove.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.Location = New System.Drawing.Point(267, 522)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(185, 40)
        Me.BtnRemove.TabIndex = 255
        Me.BtnRemove.Text = "Remove List"
        Me.BtnRemove.UseTransparentBackground = True
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 20
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(483, 522)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(185, 40)
        Me.Guna2Button3.TabIndex = 254
        Me.Guna2Button3.Text = "View Lessor"
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.BorderRadius = 20
        Me.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(50, 522)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(185, 40)
        Me.BtnUpdate.TabIndex = 253
        Me.BtnUpdate.Text = "Update List"
        Me.BtnUpdate.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(705, 522)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(185, 40)
        Me.Guna2Button1.TabIndex = 252
        Me.Guna2Button1.Text = "Add List"
        Me.Guna2Button1.UseTransparentBackground = True
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
        Me.txtimage.Location = New System.Drawing.Point(55, 458)
        Me.txtimage.MaxLength = 32767
        Me.txtimage.Name = "txtimage"
        Me.txtimage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtimage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtimage.SelectedText = ""
        Me.txtimage.SelectionLength = 0
        Me.txtimage.SelectionStart = 0
        Me.txtimage.ShortcutsEnabled = True
        Me.txtimage.Size = New System.Drawing.Size(335, 30)
        Me.txtimage.TabIndex = 256
        Me.txtimage.UseSelectable = True
        Me.txtimage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtimage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtid
        '
        '
        '
        '
        Me.txtid.CustomButton.Image = Nothing
        Me.txtid.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtid.CustomButton.Name = ""
        Me.txtid.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtid.CustomButton.TabIndex = 1
        Me.txtid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtid.CustomButton.UseSelectable = True
        Me.txtid.CustomButton.Visible = False
        Me.txtid.Enabled = False
        Me.txtid.Lines = New String(-1) {}
        Me.txtid.Location = New System.Drawing.Point(56, 161)
        Me.txtid.MaxLength = 32767
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtid.SelectedText = ""
        Me.txtid.SelectionLength = 0
        Me.txtid.SelectionStart = 0
        Me.txtid.ShortcutsEnabled = True
        Me.txtid.Size = New System.Drawing.Size(335, 30)
        Me.txtid.TabIndex = 258
        Me.txtid.UseSelectable = True
        Me.txtid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "ID"
        '
        'PROPERTYMANAGEMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 665)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtimage)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Controls.Add(Me.TableProperty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfloorocc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtfloors)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlessor)
        Me.Controls.Add(Me.txtproperty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "PROPERTYMANAGEMENT"
        Me.Text = "PROPERTYMANAGEMENT"
        CType(Me.TableProperty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtfloors As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlessor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtproperty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfloorocc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableProperty As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents BtnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtimage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents PropertyName As DataGridViewTextBoxColumn
    Friend WithEvents Lessor As DataGridViewTextBoxColumn
    Friend WithEvents Floors As DataGridViewTextBoxColumn
    Friend WithEvents FloorOccu As DataGridViewTextBoxColumn
    Friend WithEvents Image As DataGridViewTextBoxColumn
    Friend WithEvents txtid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
End Class
