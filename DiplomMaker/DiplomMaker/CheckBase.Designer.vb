<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBase
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
        Me.ВыбратьБазуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbSelectedBase = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(477, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыбратьБазуToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ВыбратьБазуToolStripMenuItem
        '
        Me.ВыбратьБазуToolStripMenuItem.Name = "ВыбратьБазуToolStripMenuItem"
        Me.ВыбратьБазуToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ВыбратьБазуToolStripMenuItem.Text = "Выбрать базу"
        '
        'lbSelectedBase
        '
        Me.lbSelectedBase.AutoSize = True
        Me.lbSelectedBase.Location = New System.Drawing.Point(17, 38)
        Me.lbSelectedBase.Name = "lbSelectedBase"
        Me.lbSelectedBase.Size = New System.Drawing.Size(97, 13)
        Me.lbSelectedBase.TabIndex = 1
        Me.lbSelectedBase.Text = "Выбранная база: "
        '
        'btnCheck
        '
        Me.btnCheck.AutoSize = True
        Me.btnCheck.Location = New System.Drawing.Point(20, 55)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(85, 23)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Сверить базу"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'CheckBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 165)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lbSelectedBase)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CheckBase"
        Me.Text = "Сверить базу"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыбратьБазуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents lbSelectedBase As System.Windows.Forms.Label
    Public WithEvents btnCheck As System.Windows.Forms.Button
End Class
