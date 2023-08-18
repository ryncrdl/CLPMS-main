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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.txtdescription = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Amenities = New MetroFramework.Controls.MetroTextBox()
        Me.square_meter = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpermit = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdate = New MetroFramework.Controls.MetroDateTime()
        Me.TableProperty = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SquareMeter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Camenities = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.BtnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
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
        'txtdescription
        '
        '
        '
        '
        Me.txtdescription.CustomButton.Image = Nothing
        Me.txtdescription.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtdescription.CustomButton.Name = ""
        Me.txtdescription.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtdescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdescription.CustomButton.TabIndex = 1
        Me.txtdescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdescription.CustomButton.UseSelectable = True
        Me.txtdescription.CustomButton.Visible = False
        Me.txtdescription.Lines = New String(-1) {}
        Me.txtdescription.Location = New System.Drawing.Point(55, 281)
        Me.txtdescription.MaxLength = 32767
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdescription.SelectedText = ""
        Me.txtdescription.SelectionLength = 0
        Me.txtdescription.SelectionStart = 0
        Me.txtdescription.ShortcutsEnabled = True
        Me.txtdescription.Size = New System.Drawing.Size(335, 30)
        Me.txtdescription.TabIndex = 132
        Me.txtdescription.UseSelectable = True
        Me.txtdescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Amenities"
        '
        'Amenities
        '
        '
        '
        '
        Me.Amenities.CustomButton.Image = Nothing
        Me.Amenities.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.Amenities.CustomButton.Name = ""
        Me.Amenities.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Amenities.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Amenities.CustomButton.TabIndex = 1
        Me.Amenities.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Amenities.CustomButton.UseSelectable = True
        Me.Amenities.CustomButton.Visible = False
        Me.Amenities.Lines = New String(-1) {}
        Me.Amenities.Location = New System.Drawing.Point(55, 221)
        Me.Amenities.MaxLength = 32767
        Me.Amenities.Name = "Amenities"
        Me.Amenities.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Amenities.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Amenities.SelectedText = ""
        Me.Amenities.SelectionLength = 0
        Me.Amenities.SelectionStart = 0
        Me.Amenities.ShortcutsEnabled = True
        Me.Amenities.Size = New System.Drawing.Size(335, 30)
        Me.Amenities.TabIndex = 130
        Me.Amenities.UseSelectable = True
        Me.Amenities.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Amenities.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'square_meter
        '
        '
        '
        '
        Me.square_meter.CustomButton.Image = Nothing
        Me.square_meter.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.square_meter.CustomButton.Name = ""
        Me.square_meter.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.square_meter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.square_meter.CustomButton.TabIndex = 1
        Me.square_meter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.square_meter.CustomButton.UseSelectable = True
        Me.square_meter.CustomButton.Visible = False
        Me.square_meter.Lines = New String(-1) {}
        Me.square_meter.Location = New System.Drawing.Point(55, 159)
        Me.square_meter.MaxLength = 32767
        Me.square_meter.Name = "square_meter"
        Me.square_meter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.square_meter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.square_meter.SelectedText = ""
        Me.square_meter.SelectionLength = 0
        Me.square_meter.SelectionStart = 0
        Me.square_meter.ShortcutsEnabled = True
        Me.square_meter.Size = New System.Drawing.Size(335, 30)
        Me.square_meter.TabIndex = 128
        Me.square_meter.UseSelectable = True
        Me.square_meter.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.square_meter.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "Square meter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Date of Establish"
        '
        'txtpermit
        '
        '
        '
        '
        Me.txtpermit.CustomButton.Image = Nothing
        Me.txtpermit.CustomButton.Location = New System.Drawing.Point(307, 2)
        Me.txtpermit.CustomButton.Name = ""
        Me.txtpermit.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtpermit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpermit.CustomButton.TabIndex = 1
        Me.txtpermit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpermit.CustomButton.UseSelectable = True
        Me.txtpermit.CustomButton.Visible = False
        Me.txtpermit.Lines = New String(-1) {}
        Me.txtpermit.Location = New System.Drawing.Point(55, 340)
        Me.txtpermit.MaxLength = 32767
        Me.txtpermit.Name = "txtpermit"
        Me.txtpermit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpermit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpermit.SelectedText = ""
        Me.txtpermit.SelectionLength = 0
        Me.txtpermit.SelectionStart = 0
        Me.txtpermit.ShortcutsEnabled = True
        Me.txtpermit.Size = New System.Drawing.Size(335, 30)
        Me.txtpermit.TabIndex = 134
        Me.txtpermit.UseSelectable = True
        Me.txtpermit.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpermit.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Permit"
        '
        'txtdate
        '
        Me.txtdate.CustomFormat = "dd/MM/yyyy"
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(52, 395)
        Me.txtdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(338, 29)
        Me.txtdate.TabIndex = 146
        '
        'TableProperty
        '
        Me.TableProperty.AllowUserToAddRows = False
        Me.TableProperty.AllowUserToDeleteRows = False
        Me.TableProperty.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TableProperty.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TableProperty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableProperty.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TableProperty.ColumnHeadersHeight = 30
        Me.TableProperty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.SquareMeter, Me.Camenities, Me.Description, Me.Permit, Me.clDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableProperty.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.ID.Width = 41
        '
        'SquareMeter
        '
        Me.SquareMeter.HeaderText = "Square Meter"
        Me.SquareMeter.Name = "SquareMeter"
        Me.SquareMeter.ReadOnly = True
        Me.SquareMeter.Width = 86
        '
        'Camenities
        '
        Me.Camenities.HeaderText = "Amenities"
        Me.Camenities.Name = "Camenities"
        Me.Camenities.ReadOnly = True
        Me.Camenities.Width = 75
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 83
        '
        'Permit
        '
        Me.Permit.HeaderText = "Permit"
        Me.Permit.Name = "Permit"
        Me.Permit.ReadOnly = True
        Me.Permit.Width = 59
        '
        'clDate
        '
        Me.clDate.HeaderText = "Date"
        Me.clDate.Name = "clDate"
        Me.clDate.ReadOnly = True
        Me.clDate.Width = 53
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
        'PROPERTYMANAGEMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 665)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Controls.Add(Me.TableProperty)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpermit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Amenities)
        Me.Controls.Add(Me.square_meter)
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
    Friend WithEvents txtdescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Amenities As MetroFramework.Controls.MetroTextBox
    Friend WithEvents square_meter As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpermit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TableProperty As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents BtnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents SquareMeter As DataGridViewTextBoxColumn
    Friend WithEvents Camenities As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Permit As DataGridViewTextBoxColumn
    Friend WithEvents clDate As DataGridViewTextBoxColumn
End Class
