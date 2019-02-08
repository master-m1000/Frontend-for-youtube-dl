<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TlpMainOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.LblIds = New System.Windows.Forms.Label()
        Me.TbIds = New System.Windows.Forms.TextBox()
        Me.CbEmbedSubtitles = New System.Windows.Forms.CheckBox()
        Me.LblSubtitlesFormat = New System.Windows.Forms.Label()
        Me.CoBSubtitlesFormat = New System.Windows.Forms.ComboBox()
        Me.LblAudioFormat = New System.Windows.Forms.Label()
        Me.CobAudioFormat = New System.Windows.Forms.ComboBox()
        Me.LblSubtitles = New System.Windows.Forms.Label()
        Me.CbDownloadWholePlaylist = New System.Windows.Forms.CheckBox()
        Me.TbSubtitles = New System.Windows.Forms.TextBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.RdbAudio = New System.Windows.Forms.RadioButton()
        Me.RdbVideo = New System.Windows.Forms.RadioButton()
        Me.TlpAudioVideo = New System.Windows.Forms.TableLayoutPanel()
        Me.CbDownloadSubtitles = New System.Windows.Forms.CheckBox()
        Me.BtnCustomArguments = New System.Windows.Forms.Button()
        Me.TbCustomArguments = New System.Windows.Forms.TextBox()
        Me.LblCustomArguments = New System.Windows.Forms.Label()
        Me.LblSaveDirectory = New System.Windows.Forms.Label()
        Me.TbSaveDirectory = New System.Windows.Forms.TextBox()
        Me.BtnSaveDirectory = New System.Windows.Forms.Button()
        Me.TlpMainOptions.SuspendLayout()
        Me.TlpAudioVideo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpMainOptions
        '
        Me.TlpMainOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpMainOptions.ColumnCount = 2
        Me.TlpMainOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpMainOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMainOptions.Controls.Add(Me.LblIds, 0, 0)
        Me.TlpMainOptions.Controls.Add(Me.TbIds, 1, 0)
        Me.TlpMainOptions.Controls.Add(Me.CbEmbedSubtitles, 1, 2)
        Me.TlpMainOptions.Controls.Add(Me.LblSubtitlesFormat, 0, 3)
        Me.TlpMainOptions.Controls.Add(Me.CoBSubtitlesFormat, 1, 3)
        Me.TlpMainOptions.Controls.Add(Me.LblAudioFormat, 0, 4)
        Me.TlpMainOptions.Controls.Add(Me.CobAudioFormat, 1, 4)
        Me.TlpMainOptions.Controls.Add(Me.LblSubtitles, 0, 2)
        Me.TlpMainOptions.Controls.Add(Me.CbDownloadWholePlaylist, 0, 1)
        Me.TlpMainOptions.Controls.Add(Me.TbSubtitles, 1, 2)
        Me.TlpMainOptions.Location = New System.Drawing.Point(12, 64)
        Me.TlpMainOptions.Name = "TlpMainOptions"
        Me.TlpMainOptions.RowCount = 6
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpMainOptions.Size = New System.Drawing.Size(260, 246)
        Me.TlpMainOptions.TabIndex = 1
        '
        'LblIds
        '
        Me.LblIds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblIds.AutoSize = True
        Me.LblIds.Location = New System.Drawing.Point(3, 1)
        Me.LblIds.Name = "LblIds"
        Me.LblIds.Size = New System.Drawing.Size(118, 26)
        Me.LblIds.TabIndex = 0
        Me.LblIds.Text = "&IDs/URLs von Video(s)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/Playlist(en):"
        '
        'TbIds
        '
        Me.TbIds.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbIds.Location = New System.Drawing.Point(127, 3)
        Me.TbIds.Name = "TbIds"
        Me.TbIds.Size = New System.Drawing.Size(130, 22)
        Me.TbIds.TabIndex = 1
        '
        'CbEmbedSubtitles
        '
        Me.CbEmbedSubtitles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CbEmbedSubtitles.AutoSize = True
        Me.TlpMainOptions.SetColumnSpan(Me.CbEmbedSubtitles, 2)
        Me.CbEmbedSubtitles.Location = New System.Drawing.Point(3, 82)
        Me.CbEmbedSubtitles.Name = "CbEmbedSubtitles"
        Me.CbEmbedSubtitles.Size = New System.Drawing.Size(131, 17)
        Me.CbEmbedSubtitles.TabIndex = 4
        Me.CbEmbedSubtitles.Text = "Untertitel &einbinden"
        Me.CbEmbedSubtitles.UseVisualStyleBackColor = True
        '
        'LblSubtitlesFormat
        '
        Me.LblSubtitlesFormat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblSubtitlesFormat.AutoSize = True
        Me.LblSubtitlesFormat.Location = New System.Drawing.Point(3, 109)
        Me.LblSubtitlesFormat.Name = "LblSubtitlesFormat"
        Me.LblSubtitlesFormat.Size = New System.Drawing.Size(99, 13)
        Me.LblSubtitlesFormat.TabIndex = 5
        Me.LblSubtitlesFormat.Text = "Untertitel-&Format:"
        '
        'CoBSubtitlesFormat
        '
        Me.CoBSubtitlesFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.CoBSubtitlesFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBSubtitlesFormat.FormattingEnabled = True
        Me.CoBSubtitlesFormat.Items.AddRange(New Object() {"ASS", "SRT", "VTT"})
        Me.CoBSubtitlesFormat.Location = New System.Drawing.Point(127, 105)
        Me.CoBSubtitlesFormat.Name = "CoBSubtitlesFormat"
        Me.CoBSubtitlesFormat.Size = New System.Drawing.Size(130, 21)
        Me.CoBSubtitlesFormat.TabIndex = 6
        '
        'LblAudioFormat
        '
        Me.LblAudioFormat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblAudioFormat.AutoSize = True
        Me.LblAudioFormat.Location = New System.Drawing.Point(3, 181)
        Me.LblAudioFormat.Name = "LblAudioFormat"
        Me.LblAudioFormat.Size = New System.Drawing.Size(81, 13)
        Me.LblAudioFormat.TabIndex = 7
        Me.LblAudioFormat.Text = "Audio-&Format:"
        '
        'CobAudioFormat
        '
        Me.CobAudioFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.CobAudioFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CobAudioFormat.FormattingEnabled = True
        Me.CobAudioFormat.Items.AddRange(New Object() {"beste Qualität", "aac", "vorbis", "mp3", "m4a", "opus", "wav"})
        Me.CobAudioFormat.Location = New System.Drawing.Point(127, 132)
        Me.CobAudioFormat.Name = "CobAudioFormat"
        Me.CobAudioFormat.Size = New System.Drawing.Size(130, 21)
        Me.CobAudioFormat.TabIndex = 8
        '
        'LblSubtitles
        '
        Me.LblSubtitles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblSubtitles.AutoSize = True
        Me.LblSubtitles.Location = New System.Drawing.Point(3, 58)
        Me.LblSubtitles.Name = "LblSubtitles"
        Me.LblSubtitles.Size = New System.Drawing.Size(112, 13)
        Me.LblSubtitles.TabIndex = 2
        Me.LblSubtitles.Text = "Untertite&lsprache(n):"
        '
        'CbDownloadWholePlaylist
        '
        Me.CbDownloadWholePlaylist.AutoSize = True
        Me.TlpMainOptions.SetColumnSpan(Me.CbDownloadWholePlaylist, 2)
        Me.CbDownloadWholePlaylist.Location = New System.Drawing.Point(3, 31)
        Me.CbDownloadWholePlaylist.Name = "CbDownloadWholePlaylist"
        Me.CbDownloadWholePlaylist.Size = New System.Drawing.Size(140, 17)
        Me.CbDownloadWholePlaylist.TabIndex = 9
        Me.CbDownloadWholePlaylist.Text = "Gesamte Playlist laden"
        Me.CbDownloadWholePlaylist.UseVisualStyleBackColor = True
        '
        'TbSubtitles
        '
        Me.TbSubtitles.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbSubtitles.Location = New System.Drawing.Point(127, 54)
        Me.TbSubtitles.Name = "TbSubtitles"
        Me.TbSubtitles.Size = New System.Drawing.Size(130, 22)
        Me.TbSubtitles.TabIndex = 3
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStart.Location = New System.Drawing.Point(12, 316)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(260, 22)
        Me.BtnStart.TabIndex = 5
        Me.BtnStart.Text = "&Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'RdbAudio
        '
        Me.RdbAudio.AutoSize = True
        Me.RdbAudio.Location = New System.Drawing.Point(122, 3)
        Me.RdbAudio.Name = "RdbAudio"
        Me.RdbAudio.Size = New System.Drawing.Size(56, 17)
        Me.RdbAudio.TabIndex = 1
        Me.RdbAudio.Text = "&Audio"
        Me.RdbAudio.UseVisualStyleBackColor = True
        '
        'RdbVideo
        '
        Me.RdbVideo.AutoSize = True
        Me.RdbVideo.Checked = True
        Me.RdbVideo.Location = New System.Drawing.Point(3, 3)
        Me.RdbVideo.Name = "RdbVideo"
        Me.RdbVideo.Size = New System.Drawing.Size(55, 17)
        Me.RdbVideo.TabIndex = 0
        Me.RdbVideo.TabStop = True
        Me.RdbVideo.Text = "&Video"
        Me.RdbVideo.UseVisualStyleBackColor = True
        '
        'TlpAudioVideo
        '
        Me.TlpAudioVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpAudioVideo.AutoSize = True
        Me.TlpAudioVideo.ColumnCount = 3
        Me.TlpAudioVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpAudioVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpAudioVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TlpAudioVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpAudioVideo.Controls.Add(Me.RdbVideo, 0, 0)
        Me.TlpAudioVideo.Controls.Add(Me.RdbAudio, 1, 0)
        Me.TlpAudioVideo.Controls.Add(Me.CbDownloadSubtitles, 0, 1)
        Me.TlpAudioVideo.Controls.Add(Me.BtnCustomArguments, 2, 0)
        Me.TlpAudioVideo.Location = New System.Drawing.Point(12, 12)
        Me.TlpAudioVideo.Name = "TlpAudioVideo"
        Me.TlpAudioVideo.RowCount = 2
        Me.TlpAudioVideo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpAudioVideo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpAudioVideo.Size = New System.Drawing.Size(260, 46)
        Me.TlpAudioVideo.TabIndex = 0
        '
        'CbDownloadSubtitles
        '
        Me.CbDownloadSubtitles.AutoSize = True
        Me.TlpAudioVideo.SetColumnSpan(Me.CbDownloadSubtitles, 2)
        Me.CbDownloadSubtitles.Location = New System.Drawing.Point(3, 26)
        Me.CbDownloadSubtitles.Name = "CbDownloadSubtitles"
        Me.CbDownloadSubtitles.Size = New System.Drawing.Size(152, 17)
        Me.CbDownloadSubtitles.TabIndex = 2
        Me.CbDownloadSubtitles.Text = "&Untertitel herunterladen"
        Me.CbDownloadSubtitles.UseVisualStyleBackColor = True
        '
        'BtnCustomArguments
        '
        Me.BtnCustomArguments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCustomArguments.Location = New System.Drawing.Point(241, 3)
        Me.BtnCustomArguments.Name = "BtnCustomArguments"
        Me.TlpAudioVideo.SetRowSpan(Me.BtnCustomArguments, 2)
        Me.BtnCustomArguments.Size = New System.Drawing.Size(16, 40)
        Me.BtnCustomArguments.TabIndex = 3
        Me.BtnCustomArguments.Text = "*"
        Me.BtnCustomArguments.UseVisualStyleBackColor = True
        '
        'TbCustomArguments
        '
        Me.TbCustomArguments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbCustomArguments.Location = New System.Drawing.Point(12, 80)
        Me.TbCustomArguments.Multiline = True
        Me.TbCustomArguments.Name = "TbCustomArguments"
        Me.TbCustomArguments.Size = New System.Drawing.Size(260, 230)
        Me.TbCustomArguments.TabIndex = 4
        Me.TbCustomArguments.Visible = False
        '
        'LblCustomArguments
        '
        Me.LblCustomArguments.AutoSize = True
        Me.LblCustomArguments.Location = New System.Drawing.Point(12, 64)
        Me.LblCustomArguments.Name = "LblCustomArguments"
        Me.LblCustomArguments.Size = New System.Drawing.Size(253, 13)
        Me.LblCustomArguments.TabIndex = 3
        Me.LblCustomArguments.Text = "&Eigene Argumente: (hier für Bsp. doppelklicken)"
        Me.LblCustomArguments.Visible = False
        '
        'LblSaveDirectory
        '
        Me.LblSaveDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblSaveDirectory.AutoSize = True
        Me.LblSaveDirectory.Location = New System.Drawing.Point(15, 291)
        Me.LblSaveDirectory.Name = "LblSaveDirectory"
        Me.LblSaveDirectory.Size = New System.Drawing.Size(27, 13)
        Me.LblSaveDirectory.TabIndex = 2
        Me.LblSaveDirectory.Text = "&Ort:"
        '
        'TbSaveDirectory
        '
        Me.TbSaveDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbSaveDirectory.Location = New System.Drawing.Point(48, 288)
        Me.TbSaveDirectory.Name = "TbSaveDirectory"
        Me.TbSaveDirectory.Size = New System.Drawing.Size(194, 22)
        Me.TbSaveDirectory.TabIndex = 3
        '
        'BtnSaveDirectory
        '
        Me.BtnSaveDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveDirectory.Location = New System.Drawing.Point(248, 288)
        Me.BtnSaveDirectory.Name = "BtnSaveDirectory"
        Me.BtnSaveDirectory.Size = New System.Drawing.Size(24, 22)
        Me.BtnSaveDirectory.TabIndex = 4
        Me.BtnSaveDirectory.Text = "&..."
        Me.BtnSaveDirectory.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 350)
        Me.Controls.Add(Me.BtnSaveDirectory)
        Me.Controls.Add(Me.TbSaveDirectory)
        Me.Controls.Add(Me.LblSaveDirectory)
        Me.Controls.Add(Me.TlpMainOptions)
        Me.Controls.Add(Me.LblCustomArguments)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.TlpAudioVideo)
        Me.Controls.Add(Me.TbCustomArguments)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "Frontend for youtube-dl"
        Me.TlpMainOptions.ResumeLayout(False)
        Me.TlpMainOptions.PerformLayout()
        Me.TlpAudioVideo.ResumeLayout(False)
        Me.TlpAudioVideo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TlpMainOptions As TableLayoutPanel
    Friend WithEvents LblIds As Label
    Friend WithEvents TbIds As TextBox
    Friend WithEvents RdbAudio As RadioButton
    Friend WithEvents RdbVideo As RadioButton
    Friend WithEvents CbEmbedSubtitles As CheckBox
    Friend WithEvents LblSubtitlesFormat As Label
    Friend WithEvents CoBSubtitlesFormat As ComboBox
    Friend WithEvents LblSubtitles As Label
    Friend WithEvents LblAudioFormat As Label
    Friend WithEvents CobAudioFormat As ComboBox
    Friend WithEvents TlpAudioVideo As TableLayoutPanel
    Friend WithEvents CbDownloadSubtitles As CheckBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents CbDownloadWholePlaylist As CheckBox
    Friend WithEvents TbSubtitles As TextBox
    Friend WithEvents BtnCustomArguments As Button
    Friend WithEvents TbCustomArguments As TextBox
    Friend WithEvents LblCustomArguments As Label
    Friend WithEvents LblSaveDirectory As Label
    Friend WithEvents TbSaveDirectory As TextBox
    Friend WithEvents BtnSaveDirectory As Button
End Class
