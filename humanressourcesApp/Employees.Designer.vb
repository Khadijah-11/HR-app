<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.epmcin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.empnatio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.emplname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.employeeDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.emphiring = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.empstatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.empposition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.empdob = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.epmgander = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.HRappDataSet = New humanressourcesApp.HRappDataSet()
        Me.empadd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.empcnss = New Guna.UI2.WinForms.Guna2TextBox()
        Me.empemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.empphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.empage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.empname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New humanressourcesApp.HRappDataSetTableAdapters.employeeTableAdapter()
        Me.empcomp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.employeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRappDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Guna2Panel1.Controls.Add(Me.Label17)
        Me.Guna2Panel1.Controls.Add(Me.searchbox)
        Me.Guna2Panel1.Controls.Add(Me.empcomp)
        Me.Guna2Panel1.Controls.Add(Me.epmcin)
        Me.Guna2Panel1.Controls.Add(Me.Label16)
        Me.Guna2Panel1.Controls.Add(Me.empnatio)
        Me.Guna2Panel1.Controls.Add(Me.emplname)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.employeeDGV)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.emphiring)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Controls.Add(Me.empstatus)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.Label11)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.empposition)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.empdob)
        Me.Guna2Panel1.Controls.Add(Me.epmgander)
        Me.Guna2Panel1.Controls.Add(Me.empadd)
        Me.Guna2Panel1.Controls.Add(Me.empcnss)
        Me.Guna2Panel1.Controls.Add(Me.empemail)
        Me.Guna2Panel1.Controls.Add(Me.empphone)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.empage)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.empname)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, 77)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1375, 548)
        Me.Guna2Panel1.TabIndex = 0
        '
        'epmcin
        '
        Me.epmcin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.epmcin.DefaultText = ""
        Me.epmcin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.epmcin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.epmcin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.epmcin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.epmcin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.epmcin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.epmcin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.epmcin.Location = New System.Drawing.Point(0, 328)
        Me.epmcin.Name = "epmcin"
        Me.epmcin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.epmcin.PlaceholderText = ""
        Me.epmcin.SelectedText = ""
        Me.epmcin.Size = New System.Drawing.Size(219, 36)
        Me.epmcin.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 290)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 35)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "CIN"
        '
        'empnatio
        '
        Me.empnatio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empnatio.DefaultText = ""
        Me.empnatio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empnatio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empnatio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empnatio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empnatio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empnatio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empnatio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empnatio.Location = New System.Drawing.Point(0, 234)
        Me.empnatio.Name = "empnatio"
        Me.empnatio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empnatio.PlaceholderText = ""
        Me.empnatio.SelectedText = ""
        Me.empnatio.Size = New System.Drawing.Size(219, 36)
        Me.empnatio.TabIndex = 31
        '
        'emplname
        '
        Me.emplname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emplname.DefaultText = ""
        Me.emplname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.emplname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.emplname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emplname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emplname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emplname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.emplname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emplname.Location = New System.Drawing.Point(225, 54)
        Me.emplname.Name = "emplname"
        Me.emplname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emplname.PlaceholderText = ""
        Me.emplname.SelectedText = ""
        Me.emplname.Size = New System.Drawing.Size(195, 36)
        Me.emplname.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(242, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(190, 35)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Employee Lastname"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 35)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Nationality"
        '
        'employeeDGV
        '
        Me.employeeDGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(1)
        Me.employeeDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.employeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.employeeDGV.BackgroundColor = System.Drawing.Color.LightGreen
        Me.employeeDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.employeeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.employeeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Centaur", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Centaur", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employeeDGV.DefaultCellStyle = DataGridViewCellStyle18
        Me.employeeDGV.EnableHeadersVisualStyles = False
        Me.employeeDGV.GridColor = System.Drawing.Color.SeaGreen
        Me.employeeDGV.Location = New System.Drawing.Point(620, 54)
        Me.employeeDGV.Name = "employeeDGV"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Centaur", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.employeeDGV.RowHeadersVisible = False
        DataGridViewCellStyle20.Padding = New System.Windows.Forms.Padding(1)
        Me.employeeDGV.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.employeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.employeeDGV.Size = New System.Drawing.Size(752, 423)
        Me.employeeDGV.TabIndex = 27
        Me.employeeDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.employeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.employeeDGV.ThemeStyle.BackColor = System.Drawing.Color.LightGreen
        Me.employeeDGV.ThemeStyle.GridColor = System.Drawing.Color.SeaGreen
        Me.employeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.employeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.employeeDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.employeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.employeeDGV.ThemeStyle.HeaderStyle.Height = 23
        Me.employeeDGV.ThemeStyle.ReadOnly = False
        Me.employeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.employeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.employeeDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.employeeDGV.ThemeStyle.RowsStyle.Height = 22
        Me.employeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MintCream
        Me.employeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(568, 500)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button3.TabIndex = 26
        Me.Guna2Button3.Text = "Delete"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(289, 500)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button2.TabIndex = 25
        Me.Guna2Button2.Text = "Modify"
        '
        'emphiring
        '
        Me.emphiring.Checked = True
        Me.emphiring.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.emphiring.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.emphiring.Location = New System.Drawing.Point(434, 328)
        Me.emphiring.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.emphiring.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.emphiring.Name = "emphiring"
        Me.emphiring.Size = New System.Drawing.Size(180, 36)
        Me.emphiring.TabIndex = 24
        Me.emphiring.Value = New Date(2022, 4, 21, 11, 21, 18, 498)
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(461, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 35)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Hiring Date"
        '
        'empstatus
        '
        Me.empstatus.AutoRoundedCorners = True
        Me.empstatus.BackColor = System.Drawing.Color.Transparent
        Me.empstatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.empstatus.BorderRadius = 17
        Me.empstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.empstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empstatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empstatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.empstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.empstatus.ItemHeight = 30
        Me.empstatus.Items.AddRange(New Object() {"Single", "Married", "Divorced"})
        Me.empstatus.Location = New System.Drawing.Point(225, 328)
        Me.empstatus.Name = "empstatus"
        Me.empstatus.Size = New System.Drawing.Size(197, 36)
        Me.empstatus.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(242, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 35)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Family Status"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(451, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 35)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Company name"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(474, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 35)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "CNSS ID"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 35)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Address"
        '
        'empposition
        '
        Me.empposition.AutoRoundedCorners = True
        Me.empposition.BackColor = System.Drawing.Color.Transparent
        Me.empposition.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.empposition.BorderRadius = 17
        Me.empposition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.empposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empposition.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empposition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empposition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.empposition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.empposition.ItemHeight = 30
        Me.empposition.Items.AddRange(New Object() {"Receptionist", "Reception manager", "House keeping manager", "Bar manager", "Barman", "Waiter", "Vendor", "Shop manager", "IT manager", "Technicien", "Spa manager", "Beautician", "Security man"})
        Me.empposition.Location = New System.Drawing.Point(426, 149)
        Me.empposition.Name = "empposition"
        Me.empposition.Size = New System.Drawing.Size(181, 36)
        Me.empposition.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(451, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 35)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Employee Position"
        '
        'empdob
        '
        Me.empdob.Checked = True
        Me.empdob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empdob.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.empdob.Location = New System.Drawing.Point(193, 410)
        Me.empdob.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.empdob.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.empdob.Name = "empdob"
        Me.empdob.Size = New System.Drawing.Size(200, 36)
        Me.empdob.TabIndex = 14
        Me.empdob.Value = New Date(2022, 4, 22, 9, 50, 0, 432)
        '
        'epmgander
        '
        Me.epmgander.AutoRoundedCorners = True
        Me.epmgander.BackColor = System.Drawing.Color.Transparent
        Me.epmgander.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.epmgander.BorderRadius = 17
        Me.epmgander.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.epmgander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.epmgander.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.epmgander.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.epmgander.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.epmgander.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.epmgander.ItemHeight = 30
        Me.epmgander.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.epmgander.Location = New System.Drawing.Point(0, 410)
        Me.epmgander.Name = "epmgander"
        Me.epmgander.Size = New System.Drawing.Size(140, 36)
        Me.epmgander.TabIndex = 13
        '
        'HRappDataSet
        '
        Me.HRappDataSet.DataSetName = "HRappDataSet"
        Me.HRappDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'empadd
        '
        Me.empadd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empadd.DefaultText = ""
        Me.empadd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empadd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empadd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empadd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empadd.Location = New System.Drawing.Point(400, 410)
        Me.empadd.Name = "empadd"
        Me.empadd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empadd.PlaceholderText = ""
        Me.empadd.SelectedText = ""
        Me.empadd.Size = New System.Drawing.Size(207, 36)
        Me.empadd.TabIndex = 12
        '
        'empcnss
        '
        Me.empcnss.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empcnss.DefaultText = ""
        Me.empcnss.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empcnss.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empcnss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empcnss.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empcnss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empcnss.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empcnss.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empcnss.Location = New System.Drawing.Point(426, 54)
        Me.empcnss.Name = "empcnss"
        Me.empcnss.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empcnss.PlaceholderText = ""
        Me.empcnss.SelectedText = ""
        Me.empcnss.Size = New System.Drawing.Size(173, 36)
        Me.empcnss.TabIndex = 11
        '
        'empemail
        '
        Me.empemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empemail.DefaultText = ""
        Me.empemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empemail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empemail.Location = New System.Drawing.Point(225, 234)
        Me.empemail.Name = "empemail"
        Me.empemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empemail.PlaceholderText = ""
        Me.empemail.SelectedText = ""
        Me.empemail.Size = New System.Drawing.Size(201, 36)
        Me.empemail.TabIndex = 10
        '
        'empphone
        '
        Me.empphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empphone.DefaultText = ""
        Me.empphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empphone.Location = New System.Drawing.Point(225, 149)
        Me.empphone.Name = "empphone"
        Me.empphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empphone.PlaceholderText = ""
        Me.empphone.SelectedText = ""
        Me.empphone.Size = New System.Drawing.Size(195, 36)
        Me.empphone.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(242, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 35)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Employee Email"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 35)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Employee Phone"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(189, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 35)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Employee Birthday"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 35)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Employee Gender"
        '
        'empage
        '
        Me.empage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empage.DefaultText = ""
        Me.empage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empage.Location = New System.Drawing.Point(0, 149)
        Me.empage.Name = "empage"
        Me.empage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empage.PlaceholderText = ""
        Me.empage.SelectedText = ""
        Me.empage.Size = New System.Drawing.Size(219, 36)
        Me.empage.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee Age"
        '
        'empname
        '
        Me.empname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empname.DefaultText = ""
        Me.empname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.empname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empname.Location = New System.Drawing.Point(3, 54)
        Me.empname.Name = "empname"
        Me.empname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empname.PlaceholderText = ""
        Me.empname.SelectedText = ""
        Me.empname.Size = New System.Drawing.Size(216, 36)
        Me.empname.TabIndex = 2
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(17, 500)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Add employee"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manage employees"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.HRappDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'empcomp
        '
        Me.empcomp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empcomp.DefaultText = "O.B Hospitality"
        Me.empcomp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.empcomp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.empcomp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empcomp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.empcomp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empcomp.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empcomp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.empcomp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.empcomp.Location = New System.Drawing.Point(440, 230)
        Me.empcomp.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.empcomp.Name = "empcomp"
        Me.empcomp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.empcomp.PlaceholderText = ""
        Me.empcomp.SelectedText = ""
        Me.empcomp.Size = New System.Drawing.Size(159, 40)
        Me.empcomp.TabIndex = 34
        '
        'searchbox
        '
        Me.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchbox.DefaultText = ""
        Me.searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchbox.Location = New System.Drawing.Point(763, 16)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchbox.PlaceholderText = ""
        Me.searchbox.SelectedText = ""
        Me.searchbox.Size = New System.Drawing.Size(173, 31)
        Me.searchbox.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(668, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 31)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Search"
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1370, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Employees"
        Me.Text = "Employees"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.employeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRappDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents employeeDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents emphiring As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents empstatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents empposition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents empdob As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents epmgander As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents empadd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents empcnss As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents empemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents empphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents empage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents empname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents emplname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents empnatio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents epmcin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents HRappDataSet As HRappDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As HRappDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents empcomp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
End Class
