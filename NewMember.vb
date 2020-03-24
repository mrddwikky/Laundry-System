Imports MySql.Data.MySqlClient
Imports System.Data
Public Class NewMember
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
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Anda berhasil logout!")
        Front.Show()
        Me.Close()
    End Sub

    Private Sub NewMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Show()
    End Sub

    Private Sub PriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Price.Show()
        Me.Show()
    End Sub

    Private Sub LaundryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Laundry.Show()
        Me.Close()
    End Sub

    Private Sub NewMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        Call clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call konek()
        mycommand = New MySqlCommand("insert into member values('" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')", myconn)
        mycommand.ExecuteNonQuery()

        Call clear()
        MsgBox("Your data has been saved", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class