Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Login
    Dim myconn As New MySqlConnection

    Sub konek()
        myconn = New MySqlConnection("server='localhost';user id='root';password='';database='laundry'")
        myconn.Open()
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Signup.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call konek()
        Dim adp As New MySqlDataAdapter("select * from login where username = '" & TextBox1.Text & "'", myconn)
        Dim tbl As New DataTable
        adp.Fill(tbl)
        MsgBox("Anda Berhasil Login....")
        If tbl.Rows.Count > 0 Then
            If tbl.Rows(0)("password") = TextBox2.Text Then
                Home.ShowDialog()
                Me.Close()

            End If
        Else
            MsgBox("Your username or password is wrong", MsgBoxStyle.Information)
            TextBox1.Focus()
            Call clear()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
