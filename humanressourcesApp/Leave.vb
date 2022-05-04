Imports System.Data.SqlClient

Public Class Leave
    Dim Con As New SqlConnection("Data Source=DESKTOP-Q8ABRTT;Initial Catalog=HRMS;Integrated Security=True")
    Private Sub Leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from empleave"
        Dim adapter = New SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        leaveDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Con.Open()
        Dim Query As String
        Query = "insert into empleave values('" & empid.Text & "', '" & empname.Text & "', '" & emplname.Text & "', '" & cin.Text & "', '" & type.SelectedItem.ToString() & "', '" & reqdate.Value & "', '" & startdate.Value & "', '" & enddate.Value & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()

        MsgBox("Leave saved")
        Con.Close()
        Populate()
    End Sub
    Dim key = 0

    Private Sub leaveDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles leaveDGV.CellContentClick
        Dim row As DataGridViewRow = leaveDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        empid.Text = row.Cells(1).Value.ToString()
        empname.Text = row.Cells(2).Value.ToString()
        emplname.Text = row.Cells(3).Value.ToString()
        cin.Text = row.Cells(4).Value.ToString()
        type.SelectedItem = row.Cells(5).Value.ToString()
        reqdate.Value = row.Cells(6).Value.ToString()
        startdate.Value = row.Cells(7).Value.ToString()
        enddate.Value = row.Cells(8).Value.ToString()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Dim cer = New Employee_Certificate
        cer.Show()
    End Sub
End Class