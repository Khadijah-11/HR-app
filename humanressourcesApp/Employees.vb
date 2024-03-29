﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Employees

    Dim Con As New SqlConnection("Data Source=DESKTOP-Q8ABRTT;Initial Catalog=HRapp;Integrated Security=True")
    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load, empstatus.SelectionChangeCommitted
        'TODO: This line of code loads data into the 'HRappDataSet.employee' table. You can move, or remove it, as needed.
        ' Me.EmployeeTableAdapter.Fill(Me.HRappDataSet.employee)
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from employee"
        Dim adapter = New SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        employeeDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If (empname.Text = "" Or emplname.Text = "" Or empage.Text = "" Or epmgander.Text = "" Or empdob.Text = "" Or empnatio.Text = "" Or epmcin.Text = "" Or empphone.Text = "" Or empemail.Text = "" Or empadd.Text = "" Or empstatus.Text = "" Or empcnss.Text = "" Or empposition.Text = "" Or empcomp.Text = "" Or emphiring.Text = "") Then
            MsgBox("Please enter all the infos needed")
        Else
            Con.Open()
            Dim Query As String
            Query = "insert into employee values('" & empname.Text & "', '" & emplname.Text & "', '" & empage.Text & "', '" & epmgander.SelectedItem.ToString() & "', '" & empdob.Value & "', '" & empnatio.Text & "', '" & epmcin.Text & "', '" & empphone.Text & "', '" & empemail.Text & "', '" & empadd.Text & "', '" & empstatus.SelectedItem.ToString() & "', '" & empcnss.Text & "', '" & empposition.SelectedItem.ToString() & "', '" & empcomp.Text & "', '" & emphiring.Value & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()

            MsgBox("Registration done")
            Con.Close()
            Populate()
            clear()
        End If




    End Sub
    Dim key = 0
    Private Sub clear()
        key = 0
        empname.Text = ""
        emplname.Text = ""
        empage.Text = ""
        epmgander.Text = ""
        empdob.Text = ""
        empnatio.Text = ""
        epmcin.Text = ""
        empphone.Text = ""
        empemail.Text = ""
        empadd.Text = ""
        empstatus.Text = ""
        empcnss.Text = ""
        empposition.Text = ""
        empcomp.Text = ""
        emphiring.Text = ""
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("do you really want to delete this employee?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Close()
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from employee where employee_id = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted Successfully")
                Con.Close()
                Populate()
                clear()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If




    End Sub

    Private Sub employeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles employeeDGV.CellMouseClick
        Dim row As DataGridViewRow = employeeDGV.Rows(e.RowIndex)

        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        empname.Text = row.Cells(1).Value.ToString()
        emplname.Text = row.Cells(2).Value.ToString()
        empage.Text = row.Cells(3).Value.ToString()
        epmgander.SelectedItem = row.Cells(4).Value.ToString()
        empdob.Value = row.Cells(5).Value.ToString()
        empnatio.Text = row.Cells(6).Value.ToString()
        epmcin.Text = row.Cells(7).Value.ToString()
        empphone.Text = row.Cells(8).Value.ToString()
        empemail.Text = row.Cells(9).Value.ToString()
        empadd.Text = row.Cells(10).Value.ToString()
        empstatus.SelectedItem = row.Cells(11).Value.ToString()
        empcnss.Text = row.Cells(12).Value.ToString()
        empposition.SelectedItem = row.Cells(13).Value.ToString()
        empcomp.Text = row.Cells(14).Value.ToString()
        emphiring.Value = row.Cells(15).Value.ToString()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If empname.Text = "" Or emplname.Text = "" Or empphone.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "update employee set ename='" & empname.Text & "',  lastname='" & emplname.Text & "', age='" & empage.Text & "', sex='" & epmgander.SelectedItem.ToString() & "', dob='" & empdob.Value & "', nationality='" & empnatio.Text & "', cin='" & epmcin.Text & "', phone='" & empphone.Text & "', email='" & empemail.Text & "', address='" & empadd.Text & "', family_status='" & empstatus.SelectedItem.ToString() & "', cnss_id='" & empcnss.Text & "', position='" & empposition.SelectedItem.ToString() & "', company_name='" & empcomp.Text & "', hiring_date='" & emphiring.Value & "' where employee_id =" & key & ""
            Dim cmd As New SqlCommand(Query, Con)
            'cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated Successfully")
            Con.Close()
            Populate()
        End If





    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub epmgander_SelectedIndexChanged(sender As Object, e As EventArgs)
        'epmgander.DisplayMember = "sex"
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        ' FilterData(searchbox.Text)
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * from employee where concat(ename,lastname,position) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, Con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        employeeDGV.DataSource = table
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        FilterData(searchbox.Text)
    End Sub
End Class