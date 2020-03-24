Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Signup
    Dim myconn As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader

    Sub konek()
        myconn = New MySqlConnection("server='localhost';user id='root';password='';database='laundry'")
        myconn.Open()
    End Sub

    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call konek()
        mycommand = New MySqlCommand("insert into operator values('""', '""', '" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox2.Text & "')", myconn)
        mycommand.ExecuteNonQuery()
        mycommand = New MySqlCommand("insert into login values('""', '""', '" & TextBox4.Text & "', '" & TextBox5.Text & "')", myconn)
        mycommand.ExecuteNonQuery()
        Call clear()
        MsgBox("Your data has been saved", MsgBoxStyle.OkOnly)
        Laundry.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call clear()
    End Sub
End Class