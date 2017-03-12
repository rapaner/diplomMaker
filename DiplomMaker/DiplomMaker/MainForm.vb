Public Class MainForm

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub СверитьБазуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СверитьБазуToolStripMenuItem.Click
        Dim checkBase As New CheckBase
        checkBase.ShowDialog()
    End Sub

End Class
