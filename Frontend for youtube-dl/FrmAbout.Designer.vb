<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TcList = New System.Windows.Forms.TabControl()
        Me.tpDefault = New System.Windows.Forms.TabPage()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.TbAbout = New System.Windows.Forms.TextBox()
        Me.TcList.SuspendLayout()
        Me.TlpLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'TcList
        '
        Me.TlpLayout.SetColumnSpan(Me.TcList, 2)
        Me.TcList.Controls.Add(Me.tpDefault)
        Me.TcList.Dock = System.Windows.Forms.DockStyle.Top
        Me.TcList.Location = New System.Drawing.Point(3, 3)
        Me.TcList.Name = "TcList"
        Me.TcList.SelectedIndex = 0
        Me.TcList.Size = New System.Drawing.Size(278, 20)
        Me.TcList.TabIndex = 0
        '
        'tpDefault
        '
        Me.tpDefault.Location = New System.Drawing.Point(4, 22)
        Me.tpDefault.Name = "tpDefault"
        Me.tpDefault.Size = New System.Drawing.Size(270, 0)
        Me.tpDefault.TabIndex = 0
        Me.tpDefault.Text = "Name"
        Me.tpDefault.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(206, 235)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "S&chließen"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TlpLayout
        '
        Me.TlpLayout.ColumnCount = 2
        Me.TlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpLayout.Controls.Add(Me.TcList, 0, 0)
        Me.TlpLayout.Controls.Add(Me.LblVersion, 0, 1)
        Me.TlpLayout.Controls.Add(Me.TbAbout, 0, 2)
        Me.TlpLayout.Controls.Add(Me.BtnClose, 1, 3)
        Me.TlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.TlpLayout.Name = "TlpLayout"
        Me.TlpLayout.RowCount = 4
        Me.TlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpLayout.Size = New System.Drawing.Size(284, 261)
        Me.TlpLayout.TabIndex = 3
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.TlpLayout.SetColumnSpan(Me.LblVersion, 2)
        Me.LblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(3, 26)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(278, 13)
        Me.LblVersion.TabIndex = 2
        Me.LblVersion.Text = "LblVersion"
        '
        'TbAbout
        '
        Me.TlpLayout.SetColumnSpan(Me.TbAbout, 2)
        Me.TbAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbAbout.Location = New System.Drawing.Point(3, 42)
        Me.TbAbout.Multiline = True
        Me.TbAbout.Name = "TbAbout"
        Me.TbAbout.ReadOnly = True
        Me.TbAbout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TbAbout.Size = New System.Drawing.Size(278, 187)
        Me.TbAbout.TabIndex = 3
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TlpLayout)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Über Frontend for youtube-dl"
        Me.TcList.ResumeLayout(False)
        Me.TlpLayout.ResumeLayout(False)
        Me.TlpLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TcList As TabControl
    Friend WithEvents TlpLayout As TableLayoutPanel
    Friend WithEvents LblVersion As Label
    Friend WithEvents TbAbout As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents tpDefault As TabPage
End Class
