Public Class Home

    Private Sub LaundryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaundryToolStripMenuItem.Click
        Laundry.ShowDialog()
    End Sub

    Private Sub PriceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceToolStripMenuItem.Click
        Price.ShowDialog()
    End Sub

    Private Sub NewMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMemberToolStripMenuItem.Click
        NewMember.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Front.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        Report.ShowDialog()
    End Sub
End Class