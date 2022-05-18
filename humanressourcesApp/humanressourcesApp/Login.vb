Imports System.Data
Imports System.Data.SqlClient

Public Class Login

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Dim sps = New Splash
        sps.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpass.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles log.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-Q8ABRTT;Initial Catalog=HRapp;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from dbo_admin where admin='" + txtadmin.Text + "' and password='" + txtpass.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class