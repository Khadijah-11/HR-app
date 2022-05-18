<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees_List
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lastname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Age = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CIN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CNSSNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Hiring_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Ename, Me.Lastname, Me.Age, Me.CIN, Me.CNSSNum, Me.Position, Me.Hiring_date})
        Me.ListView1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(746, 426)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 70
        '
        'Ename
        '
        Me.Ename.Text = "Ename"
        Me.Ename.Width = 93
        '
        'Lastname
        '
        Me.Lastname.Text = "Lastname"
        Me.Lastname.Width = 97
        '
        'Age
        '
        Me.Age.Text = "Age"
        Me.Age.Width = 70
        '
        'CIN
        '
        Me.CIN.Text = "CIN"
        Me.CIN.Width = 97
        '
        'CNSSNum
        '
        Me.CNSSNum.Text = "CNSSNum"
        Me.CNSSNum.Width = 86
        '
        'Hiring_date
        '
        Me.Hiring_date.DisplayIndex = 6
        Me.Hiring_date.Text = "Hiring_date"
        Me.Hiring_date.Width = 112
        '
        'Position
        '
        Me.Position.DisplayIndex = 7
        Me.Position.Text = "Position"
        Me.Position.Width = 187
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(535, 444)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(223, 34)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Load"
        '
        'Employees_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Employees_List"
        Me.Text = "Employees_List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Ename As ColumnHeader
    Friend WithEvents Lastname As ColumnHeader
    Friend WithEvents Age As ColumnHeader
    Friend WithEvents CIN As ColumnHeader
    Friend WithEvents CNSSNum As ColumnHeader
    Friend WithEvents Hiring_date As ColumnHeader
    Friend WithEvents Position As ColumnHeader
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
