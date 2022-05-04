Imports System.Data.SqlClient
Public Class Employee_Certificate

    Dim Con As New SqlConnection("Data Source=DESKTOP-Q8ABRTT;Initial Catalog=HRMS;Integrated Security=True")
    'Dim key = 0
    Private Sub fetchdata()
        If empid.Text = "" Then
            MsgBox("Enter the employee ID")
        Else
            Con.Open()
            Dim Query = "select * from empleave where employee_id=" & empid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                ID.Text = dr(1).ToString()
                ename.Text = dr(2).ToString()
                lastname.Text = dr(3).ToString()
                cin.Text = dr(4).ToString()
                ltype.Text = dr(5).ToString()
                start.Text = dr(6).ToString()
                lend.Text = dr(7).ToString()
                ID.Visible = True
                ename.Visible = True
                lastname.Visible = True
                cin.Visible = True
                ltype.Visible = True
                start.Visible = True
                lend.Visible = True
            Next
            Con.Close()
        End If


    End Sub


    Private Sub Employee_Certificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        fetchdata()
    End Sub
End Class