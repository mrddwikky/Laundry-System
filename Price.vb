Public Class Price

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
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub LaundryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Laundry.Show()
        Me.Hide()
    End Sub

    Private Sub Price_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class