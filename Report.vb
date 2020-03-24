Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Report
    Dim myconn As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader
    Dim rd As MySqlDataReader
    Sub konek()
        myconn = New MySqlConnection("server='localhost';user id='root';password='';database='project'")
        myconn.Open()
    End Sub
    Sub tampil()
        Dim myadapter As New MySqlDataAdapter("select * from nota", myconn)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
    End Sub
    Sub jml()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            subtot += Val(DataGridView1.Rows(I).Cells(6).Value)
                TextBox1.Text = subtot

        Next
    End Sub
    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        tampil()
        jml()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampil()
        jml()
        ComboBox1.Text = "-- Pilih Bulan --"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim bulan As Integer
        Try
            Select Case ComboBox1.Text
                Case "Januari"
                    bulan = 1
                Case "Februari"
                    bulan = 2
                Case "Maret"
                    bulan = 3
                Case "April"
                    bulan = 4
                Case "Mei"
                    bulan = 5
                Case "Juni"
                    bulan = 6
                Case "Juli"
                    bulan = 7
                Case "Agustus"
                    bulan = 8
                Case "September"
                    bulan = 9
                Case "Oktober"
                    bulan = 10
                Case "November"
                    bulan = 11
                Case "Desember"
                    bulan = 12

            End Select
            If ComboBox1.Text = "" Then
                MsgBox("Pilih Bulan Terlebih Dahulu")
            Else
                Dim myadapter As New MySqlDataAdapter("select * from nota where Month(tanggal)='" & bulan & "'", myconn)
                Dim mydata As New DataTable
                myadapter.Fill(mydata)
                DataGridView1.DataSource = mydata
            End If
            jml()
        Catch ex As Exception

        End Try
    End Sub
End Class