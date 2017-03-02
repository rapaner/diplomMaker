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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СверитьБазуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СформироватьГрамотыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СформироватьДипломыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СправкаToolStripMenuItem, Me.ВыходToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СверитьБазуToolStripMenuItem, Me.СформироватьГрамотыToolStripMenuItem, Me.СформироватьДипломыToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СверитьБазуToolStripMenuItem
        '
        Me.СверитьБазуToolStripMenuItem.Name = "СверитьБазуToolStripMenuItem"
        Me.СверитьБазуToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.СверитьБазуToolStripMenuItem.Text = "Сверить базу"
        '
        'СформироватьГрамотыToolStripMenuItem
        '
        Me.СформироватьГрамотыToolStripMenuItem.Name = "СформироватьГрамотыToolStripMenuItem"
        Me.СформироватьГрамотыToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.СформироватьГрамотыToolStripMenuItem.Text = "Сформировать грамоты"
        '
        'СформироватьДипломыToolStripMenuItem
        '
        Me.СформироватьДипломыToolStripMenuItem.Name = "СформироватьДипломыToolStripMenuItem"
        Me.СформироватьДипломыToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.СформироватьДипломыToolStripMenuItem.Text = "Сформировать дипломы"
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 344)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "DiplomMaker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СверитьБазуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СформироватьГрамотыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СформироватьДипломыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
