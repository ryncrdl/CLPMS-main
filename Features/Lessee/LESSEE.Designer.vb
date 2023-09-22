<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LESSEE
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
        Me.txtemail = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpassword = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtid = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.BtnViewProperty = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDlt = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdt = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtgender = New MetroFramework.Controls.MetroComboBox()
        Me.TableLessee = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TableLessee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtemail
        '
        '
        '
        '
        Me.txtemail.CustomButton.Image = Nothing
        Me.txtemail.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtemail.CustomButton.Name = ""
        Me.txtemail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtemail.CustomButton.TabIndex = 1
        Me.txtemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtemail.CustomButton.UseSelectable = True
        Me.txtemail.CustomButton.Visible = False
        Me.txtemail.Lines = New String(-1) {}
        Me.txtemail.Location = New System.Drawing.Point(133, 222)
        Me.txtemail.MaxLength = 32767
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtemail.SelectedText = ""
        Me.txtemail.SelectionLength = 0
        Me.txtemail.SelectionStart = 0
        Me.txtemail.ShortcutsEnabled = True
        Me.txtemail.Size = New System.Drawing.Size(280, 30)
        Me.txtemail.TabIndex = 132
        Me.txtemail.UseSelectable = True
        Me.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtemail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Gender"
        '
        'txtname
        '
        '
        '
        '
        Me.txtname.CustomButton.Image = Nothing
        Me.txtname.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtname.CustomButton.Name = ""
        Me.txtname.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtname.CustomButton.TabIndex = 1
        Me.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtname.CustomButton.UseSelectable = True
        Me.txtname.CustomButton.Visible = False
        Me.txtname.Lines = New String(-1) {}
        Me.txtname.Location = New System.Drawing.Point(133, 151)
        Me.txtname.MaxLength = 32767
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtname.SelectedText = ""
        Me.txtname.SelectionLength = 0
        Me.txtname.SelectionStart = 0
        Me.txtname.ShortcutsEnabled = True
        Me.txtname.Size = New System.Drawing.Size(280, 30)
        Me.txtname.TabIndex = 128
        Me.txtname.UseSelectable = True
        Me.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox1
        '
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
        Me.MetroTextBox1.TabIndex = 126
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
        Me.Label3.Location = New System.Drawing.Point(48, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Name"
        '
        'txtpassword
        '
        '
        '
        '
        Me.txtpassword.CustomButton.Image = Nothing
        Me.txtpassword.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtpassword.CustomButton.Name = ""
        Me.txtpassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpassword.CustomButton.TabIndex = 1
        Me.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpassword.CustomButton.UseSelectable = True
        Me.txtpassword.CustomButton.Visible = False
        Me.txtpassword.Lines = New String(-1) {}
        Me.txtpassword.Location = New System.Drawing.Point(133, 258)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.SelectionLength = 0
        Me.txtpassword.SelectionStart = 0
        Me.txtpassword.ShortcutsEnabled = True
        Me.txtpassword.Size = New System.Drawing.Size(280, 30)
        Me.txtpassword.TabIndex = 149
        Me.txtpassword.UseSelectable = True
        Me.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Password"
        '
        'txtid
        '
        '
        '
        '
        Me.txtid.CustomButton.Image = Nothing
        Me.txtid.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtid.CustomButton.Name = ""
        Me.txtid.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtid.CustomButton.TabIndex = 1
        Me.txtid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtid.CustomButton.UseSelectable = True
        Me.txtid.CustomButton.Visible = False
        Me.txtid.Lines = New String(-1) {}
        Me.txtid.Location = New System.Drawing.Point(133, 115)
        Me.txtid.MaxLength = 32767
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.ReadOnly = True
        Me.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtid.SelectedText = ""
        Me.txtid.SelectionLength = 0
        Me.txtid.SelectionStart = 0
        Me.txtid.ShortcutsEnabled = True
        Me.txtid.Size = New System.Drawing.Size(280, 30)
        Me.txtid.TabIndex = 151
        Me.txtid.UseSelectable = True
        Me.txtid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 16)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(112, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "Lessee"
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
        Me.Guna2Shapes1.TabIndex = 219
        Me.Guna2Shapes1.Text = "asdasdasd"
        Me.Guna2Shapes1.Zoom = 80
        '
        'BtnViewProperty
        '
        Me.BtnViewProperty.BorderRadius = 20
        Me.BtnViewProperty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnViewProperty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnViewProperty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnViewProperty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnViewProperty.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnViewProperty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnViewProperty.ForeColor = System.Drawing.Color.White
        Me.BtnViewProperty.Location = New System.Drawing.Point(486, 522)
        Me.BtnViewProperty.Name = "BtnViewProperty"
        Me.BtnViewProperty.Size = New System.Drawing.Size(185, 40)
        Me.BtnViewProperty.TabIndex = 224
        Me.BtnViewProperty.Text = "View Leased Property"
        '
        'BtnDlt
        '
        Me.BtnDlt.BorderRadius = 20
        Me.BtnDlt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDlt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDlt.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnDlt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDlt.ForeColor = System.Drawing.Color.White
        Me.BtnDlt.Location = New System.Drawing.Point(270, 522)
        Me.BtnDlt.Name = "BtnDlt"
        Me.BtnDlt.Size = New System.Drawing.Size(185, 40)
        Me.BtnDlt.TabIndex = 223
        Me.BtnDlt.Text = "Delete"
        '
        'BtnUpdt
        '
        Me.BtnUpdt.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdt.BorderRadius = 20
        Me.BtnUpdt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdt.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUpdt.ForeColor = System.Drawing.Color.White
        Me.BtnUpdt.Location = New System.Drawing.Point(50, 522)
        Me.BtnUpdt.Name = "BtnUpdt"
        Me.BtnUpdt.Size = New System.Drawing.Size(185, 40)
        Me.BtnUpdt.TabIndex = 222
        Me.BtnUpdt.Text = "Update"
        Me.BtnUpdt.UseTransparentBackground = True
        '
        'BtnClear
        '
        Me.BtnClear.BorderRadius = 20
        Me.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(705, 522)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(185, 40)
        Me.BtnClear.TabIndex = 221
        Me.BtnClear.Text = "Clear"
        '
        'txtgender
        '
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.ItemHeight = 23
        Me.txtgender.Items.AddRange(New Object() {"male", "female"})
        Me.txtgender.Location = New System.Drawing.Point(133, 187)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.PromptText = "Select Gender"
        Me.txtgender.Size = New System.Drawing.Size(280, 29)
        Me.txtgender.TabIndex = 226
        Me.txtgender.UseSelectable = True
        '
        'TableLessee
        '
        Me.TableLessee.AllowUserToAddRows = False
        Me.TableLessee.AllowUserToDeleteRows = False
        Me.TableLessee.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.TableLessee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TableLessee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableLessee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TableLessee.ColumnHeadersHeight = 30
        Me.TableLessee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FullName, Me.CGender, Me.Email, Me.Password})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TableLessee.DefaultCellStyle = DataGridViewCellStyle3
        Me.TableLessee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TableLessee.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLessee.Location = New System.Drawing.Point(441, 85)
        Me.TableLessee.Name = "TableLessee"
        Me.TableLessee.ReadOnly = True
        Me.TableLessee.RowHeadersVisible = False
        Me.TableLessee.ShowEditingIcon = False
        Me.TableLessee.Size = New System.Drawing.Size(449, 366)
        Me.TableLessee.TabIndex = 227
        Me.TableLessee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.TableLessee.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.TableLessee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.TableLessee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.TableLessee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.TableLessee.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.TableLessee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLessee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLessee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TableLessee.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLessee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TableLessee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TableLessee.ThemeStyle.HeaderStyle.Height = 30
        Me.TableLessee.ThemeStyle.ReadOnly = True
        Me.TableLessee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.TableLessee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TableLessee.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLessee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TableLessee.ThemeStyle.RowsStyle.Height = 22
        Me.TableLessee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLessee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 41
        '
        'FullName
        '
        Me.FullName.HeaderText = "Full Name"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        Me.FullName.Width = 71
        '
        'CGender
        '
        Me.CGender.HeaderText = "Gender"
        Me.CGender.Name = "CGender"
        Me.CGender.ReadOnly = True
        Me.CGender.Width = 65
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 55
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Width = 76
        '
        'LESSEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 665)
        Me.Controls.Add(Me.TableLessee)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.BtnViewProperty)
        Me.Controls.Add(Me.BtnDlt)
        Me.Controls.Add(Me.BtnUpdt)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LESSEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LESSEE"
        CType(Me.TableLessee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtemail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents BtnViewProperty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDlt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtgender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TableLessee As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents CGender As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
End Class
