Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Laundry
    Dim myconn As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader
    Dim rd As MySqlDataReader
    Dim a, b, c, d, ee, f, g, h, i, j, k As Integer
    Dim l, m, n, o, p, q, r, s, t, pewangi, delivery As Integer
    Dim total As Integer
    Dim nama As String
    Dim bc As Integer
    Sub konek()
        myconn = New MySqlConnection("server='localhost';user id='root';password='';database='project'")
        myconn.Open()
    End Sub
    Sub clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox19.Text = ""
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        Button3.Visible = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
    Sub ttl()
        If TextBox9.Text = "" And TextBox10.Text = "" And TextBox11.Text = "" And TextBox12.Text = "" And TextBox13.Text = "" And TextBox14.Text = "" And TextBox15.Text = "" And TextBox19.Text = "" Then
            TextBox9.Focus()
        Else
            Dim a, b, c, d, ee, f, g, h As Integer
            a = TextBox9.Text
            b = TextBox10.Text
            c = TextBox11.Text
            d = TextBox12.Text
            ee = TextBox13.Text
            f = TextBox14.Text
            g = TextBox15.Text
            h = TextBox19.Text
            delivery = CheckBox23.Checked
            pewangi = CheckBox24.Checked
            total = a + b + c + d + ee + f + g + h + delivery + pewangi
            TextBox6.Text = total
        End If
    End Sub
    Sub member()
        ComboBox1.Items.Clear()
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM member", myconn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            ComboBox1.Items.Add(rdr("Full_name"))
        End While
    End Sub
    Sub showtable()
        Dim myadapter As New MySqlDataAdapter("select * from nota", myconn)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Anda berhasil logout!")
        Front.Show()
        Me.Hide()
    End Sub

    Private Sub NewMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewMember.Show()
        Me.Hide()
    End Sub

    Private Sub PriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Price.Show()
        Me.Hide()
    End Sub

    Private Sub LaundryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Laundry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()
        showtable()
        member()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ttl()
        If RadioButton1.Checked = True Then
            nama = TextBox2.Text
        Else
            nama = ComboBox1.Text
        End If
        Call konek()
        Dim Sqltambah As String = "INSERT INTO nota(tanggal,Nama,Alamat,telp,kilo,Total_harga) values ('" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & nama & "', '" & TextBox3.Text & "','" & TextBox4.Text & "', '" & total & "','" & TextBox6.Text & "')"
        mycommand = New MySqlCommand(Sqltambah, myconn)
        mycommand.ExecuteNonQuery()
        MsgBox("Your data has been saved", MsgBoxStyle.OkOnly)
        showtable()
        clear()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then
            TextBox9.Text = 0
        Else
            a = 20000 * TextBox9.Text
        End If


    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "" Then
            TextBox10.Text = 0
        Else
            b = 25000 * TextBox10.Text
        End If


    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        If TextBox11.Text = "" Then
            TextBox11.Text = 0
        Else
            c = 10000 * TextBox11.Text
        End If
        
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        If TextBox12.Text = "" Then
            TextBox12.Text = 0
        Else
            d = 15000 * TextBox12.Text
        End If

    End Sub


    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        If TextBox13.Text = "" Then
            TextBox13.Text = 0
        Else
            ee = 20000 * TextBox13.Text
        End If
        
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        If TextBox14.Text = "" Then
            TextBox14.Text = 0
        Else
            f = 10000 * TextBox14.Text
        End If
        
    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        If TextBox15.Text = "" Then
            TextBox15.Text = 0
        Else
            g = 15000 * TextBox15.Text
        End If
        
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked Then
            pewangi = 10000
        Else

        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked Then
            delivery = 20000
        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.Visible = True
        ComboBox1.Visible = False
        Button3.Visible = False
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.Visible = False
        ComboBox1.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        konek()
        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        cmd = New MySqlCommand("SELECT * FROM member where Full_name='" & ComboBox1.Text & "'", myconn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            TextBox3.Text = rdr("Address")
            TextBox4.Text = rdr("Phone")
        End While
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dis, dis2 As Integer
        dis = (TextBox6.Text * 10) / 100
        dis2 = TextBox6.Text - dis
        TextBox6.Text = dis2
    End Sub
    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        If TextBox19.Text = "" Then
            TextBox19.Text = 0
        Else
            h = 30000 * TextBox19.Text
        End If

    End Sub


End Class