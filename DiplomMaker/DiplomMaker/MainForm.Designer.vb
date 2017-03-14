<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.НастройкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEnterResults = New System.Windows.Forms.Button()
        Me.btnExportResults = New System.Windows.Forms.Button()
        Me.btnEditDB = New System.Windows.Forms.Button()
        Me.btnReviewResults = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НастройкаToolStripMenuItem, Me.СправкаToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'НастройкаToolStripMenuItem
        '
        Me.НастройкаToolStripMenuItem.Name = "НастройкаToolStripMenuItem"
        Me.НастройкаToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.НастройкаToolStripMenuItem.Text = "Настройка"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'btnEnterResults
        '
        Me.btnEnterResults.Location = New System.Drawing.Point(165, 47)
        Me.btnEnterResults.Name = "btnEnterResults"
        Me.btnEnterResults.Size = New System.Drawing.Size(194, 56)
        Me.btnEnterResults.TabIndex = 1
        Me.btnEnterResults.Text = "Ввести результаты"
        Me.btnEnterResults.UseVisualStyleBackColor = True
        '
        'btnExportResults
        '
        Me.btnExportResults.Location = New System.Drawing.Point(165, 171)
        Me.btnExportResults.Name = "btnExportResults"
        Me.btnExportResults.Size = New System.Drawing.Size(194, 56)
        Me.btnExportResults.TabIndex = 2
        Me.btnExportResults.Text = "Экспорт в xlsx"
        Me.btnExportResults.UseVisualStyleBackColor = True
        '
        'btnEditDB
        '
        Me.btnEditDB.Location = New System.Drawing.Point(165, 233)
        Me.btnEditDB.Name = "btnEditDB"
        Me.btnEditDB.Size = New System.Drawing.Size(194, 56)
        Me.btnEditDB.TabIndex = 3
        Me.btnEditDB.Text = "Редактировать базы данных"
        Me.btnEditDB.UseVisualStyleBackColor = True
        '
        'btnReviewResults
        '
        Me.btnReviewResults.Location = New System.Drawing.Point(165, 109)
        Me.btnReviewResults.Name = "btnReviewResults"
        Me.btnReviewResults.Size = New System.Drawing.Size(194, 56)
        Me.btnReviewResults.TabIndex = 4
        Me.btnReviewResults.Text = "Просмотр результатов"
        Me.btnReviewResults.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 314)
        Me.Controls.Add(Me.btnReviewResults)
        Me.Controls.Add(Me.btnEditDB)
        Me.Controls.Add(Me.btnExportResults)
        Me.Controls.Add(Me.btnEnterResults)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "DiplomaMaker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents НастройкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnterResults As Button
    Friend WithEvents ВыходToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnExportResults As Button
    Friend WithEvents btnEditDB As Button
    Friend WithEvents btnReviewResults As Button
End Class
