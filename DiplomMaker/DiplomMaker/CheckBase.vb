Public Class CheckBase
    Public excelClass As ExcelClass
    Private Sub CheckBase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        excelClass = New ExcelClass()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

    End Sub

    Private Sub ВыбратьБазуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыбратьБазуToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Книга Excel|*.xlsx"
        openFileDialog1.Title = "Выберите файл с результатами олимпиады"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            excelClass.path = openFileDialog1.SafeFileName
        End If
        lbSelectedBase.Text = "Выбранная база: " + excelClass.path
    End Sub
End Class