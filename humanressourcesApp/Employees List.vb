Imports System.Data.SqlClient

Public Class Employees_List
    Dim con As SqlConnection
    Dim adp As SqlDataAdapter
    Private Sub Employees_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con = New SqlConnection("Data Source=DESKTOP-Q8ABRTT;Initial Catalog=HRapp;Integrated Security=True")
        con.Open()
        adp = New SqlDataAdapter("SELECT employee_id, ename, lastname, age, cin, cnss_id, position, hiring_date from employee order by ename ASC", con)
        Dim dt As New DataTable
        adp.Fill(dt)
        ListView1.Items.Clear()

        For Each drow As DataRow In dt.Rows
            'drow(0) += 1
            ListView1.Items.Add(drow(0).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(4).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(5).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(6).ToString())
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(drow(7).ToString())

        Next

        con.Close()
    End Sub
End Class