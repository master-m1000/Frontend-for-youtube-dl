<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNew
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TbUrl = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TbSubtitles = New System.Windows.Forms.TextBox()
        Me.CbDownloadWholePlaylist = New System.Windows.Forms.CheckBox()
        Me.LblSubtitles = New System.Windows.Forms.Label()
        Me.CbAudioFormat = New System.Windows.Forms.ComboBox()
        Me.LblAudioFormat = New System.Windows.Forms.Label()
        Me.CbSubtitlesFormat = New System.Windows.Forms.ComboBox()
        Me.LblSubtitlesFormat = New System.Windows.Forms.Label()
        Me.CbEmbedSubtitles = New System.Windows.Forms.CheckBox()
        Me.TlpMainOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.CbDownloadSubtitles = New System.Windows.Forms.CheckBox()
        Me.TbCustomArguments = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbIgnoreErrors = New System.Windows.Forms.CheckBox()
        Me.CbNoCheckCert = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NudStart = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NudEnd = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbExec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbTitleRegex = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.rdbVideo = New System.Windows.Forms.RadioButton()
        Me.rdbAudio = New System.Windows.Forms.RadioButton()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.BtnDownload = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TbDirectory = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmsDownload = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DowloadstartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugStartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CmsDelete = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.TlpMainOptions.SuspendLayout()
        CType(Me.NudStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.CmsDownload.SuspendLayout()
        Me.CmsDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.TbUrl)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&IDs/URLs von Video(s)/Playlist(en):"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "&URL:"
        '
        'BtnDelete
        '
        Me.BtnDelete.AccessibleName = "Entfernen"
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.minus
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(275, 382)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(23, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.AccessibleName = "Hinzufügen"
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.plus
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(246, 382)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(23, 23)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TbUrl
        '
        Me.TbUrl.AccessibleDescription = "Video-URLs bzw. -IDs hier einfügen"
        Me.TbUrl.AccessibleName = "URL"
        Me.TbUrl.AllowDrop = True
        Me.TbUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbUrl.Location = New System.Drawing.Point(42, 384)
        Me.TbUrl.Name = "TbUrl"
        Me.TbUrl.Size = New System.Drawing.Size(198, 22)
        Me.TbUrl.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.Location = New System.Drawing.Point(6, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(292, 357)
        Me.ListBox1.TabIndex = 0
        '
        'TbSubtitles
        '
        Me.TbSubtitles.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbSubtitles.Location = New System.Drawing.Point(137, 49)
        Me.TbSubtitles.Name = "TbSubtitles"
        Me.TbSubtitles.Size = New System.Drawing.Size(104, 22)
        Me.TbSubtitles.TabIndex = 3
        '
        'CbDownloadWholePlaylist
        '
        Me.CbDownloadWholePlaylist.AutoSize = True
        Me.TlpMainOptions.SetColumnSpan(Me.CbDownloadWholePlaylist, 2)
        Me.CbDownloadWholePlaylist.Location = New System.Drawing.Point(3, 3)
        Me.CbDownloadWholePlaylist.Name = "CbDownloadWholePlaylist"
        Me.CbDownloadWholePlaylist.Size = New System.Drawing.Size(140, 17)
        Me.CbDownloadWholePlaylist.TabIndex = 0
        Me.CbDownloadWholePlaylist.Text = "Gesamte &Playlist laden"
        Me.CbDownloadWholePlaylist.UseVisualStyleBackColor = True
        '
        'LblSubtitles
        '
        Me.LblSubtitles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblSubtitles.AutoSize = True
        Me.LblSubtitles.Location = New System.Drawing.Point(3, 53)
        Me.LblSubtitles.Name = "LblSubtitles"
        Me.LblSubtitles.Size = New System.Drawing.Size(112, 13)
        Me.LblSubtitles.TabIndex = 2
        Me.LblSubtitles.Text = "Untertite&lsprache(n):"
        '
        'CbAudioFormat
        '
        Me.CbAudioFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbAudioFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAudioFormat.FormattingEnabled = True
        Me.CbAudioFormat.Items.AddRange(New Object() {"beste Qualität", "aac", "vorbis", "mp3", "m4a", "opus", "wav"})
        Me.CbAudioFormat.Location = New System.Drawing.Point(137, 127)
        Me.CbAudioFormat.Name = "CbAudioFormat"
        Me.CbAudioFormat.Size = New System.Drawing.Size(104, 21)
        Me.CbAudioFormat.TabIndex = 8
        '
        'LblAudioFormat
        '
        Me.LblAudioFormat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblAudioFormat.AutoSize = True
        Me.LblAudioFormat.Location = New System.Drawing.Point(3, 131)
        Me.LblAudioFormat.Name = "LblAudioFormat"
        Me.LblAudioFormat.Size = New System.Drawing.Size(81, 13)
        Me.LblAudioFormat.TabIndex = 7
        Me.LblAudioFormat.Text = "Audio-&Format:"
        '
        'CbSubtitlesFormat
        '
        Me.CbSubtitlesFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.CbSubtitlesFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSubtitlesFormat.FormattingEnabled = True
        Me.CbSubtitlesFormat.Items.AddRange(New Object() {"ASS", "SRT", "VTT"})
        Me.CbSubtitlesFormat.Location = New System.Drawing.Point(137, 100)
        Me.CbSubtitlesFormat.Name = "CbSubtitlesFormat"
        Me.CbSubtitlesFormat.Size = New System.Drawing.Size(104, 21)
        Me.CbSubtitlesFormat.TabIndex = 6
        '
        'LblSubtitlesFormat
        '
        Me.LblSubtitlesFormat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblSubtitlesFormat.AutoSize = True
        Me.LblSubtitlesFormat.Location = New System.Drawing.Point(3, 104)
        Me.LblSubtitlesFormat.Name = "LblSubtitlesFormat"
        Me.LblSubtitlesFormat.Size = New System.Drawing.Size(99, 13)
        Me.LblSubtitlesFormat.TabIndex = 5
        Me.LblSubtitlesFormat.Text = "Untertitel-F&ormat:"
        '
        'CbEmbedSubtitles
        '
        Me.CbEmbedSubtitles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CbEmbedSubtitles.AutoSize = True
        Me.TlpMainOptions.SetColumnSpan(Me.CbEmbedSubtitles, 2)
        Me.CbEmbedSubtitles.Location = New System.Drawing.Point(3, 77)
        Me.CbEmbedSubtitles.Name = "CbEmbedSubtitles"
        Me.CbEmbedSubtitles.Size = New System.Drawing.Size(131, 17)
        Me.CbEmbedSubtitles.TabIndex = 4
        Me.CbEmbedSubtitles.Text = "Untertitel &einbinden"
        Me.CbEmbedSubtitles.UseVisualStyleBackColor = True
        '
        'TlpMainOptions
        '
        Me.TlpMainOptions.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TlpMainOptions, 2)
        Me.TlpMainOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpMainOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMainOptions.Controls.Add(Me.CbDownloadWholePlaylist, 0, 0)
        Me.TlpMainOptions.Controls.Add(Me.CbDownloadSubtitles, 0, 1)
        Me.TlpMainOptions.Controls.Add(Me.LblAudioFormat, 0, 5)
        Me.TlpMainOptions.Controls.Add(Me.CbSubtitlesFormat, 1, 4)
        Me.TlpMainOptions.Controls.Add(Me.LblSubtitles, 0, 2)
        Me.TlpMainOptions.Controls.Add(Me.LblSubtitlesFormat, 0, 4)
        Me.TlpMainOptions.Controls.Add(Me.TbSubtitles, 1, 2)
        Me.TlpMainOptions.Controls.Add(Me.CbEmbedSubtitles, 0, 3)
        Me.TlpMainOptions.Controls.Add(Me.CbAudioFormat, 1, 5)
        Me.TlpMainOptions.Controls.Add(Me.TbCustomArguments, 1, 12)
        Me.TlpMainOptions.Controls.Add(Me.Label1, 0, 12)
        Me.TlpMainOptions.Controls.Add(Me.CbIgnoreErrors, 0, 6)
        Me.TlpMainOptions.Controls.Add(Me.CbNoCheckCert, 0, 7)
        Me.TlpMainOptions.Controls.Add(Me.Label2, 0, 8)
        Me.TlpMainOptions.Controls.Add(Me.NudStart, 1, 8)
        Me.TlpMainOptions.Controls.Add(Me.Label3, 0, 9)
        Me.TlpMainOptions.Controls.Add(Me.NudEnd, 1, 9)
        Me.TlpMainOptions.Controls.Add(Me.Label4, 0, 10)
        Me.TlpMainOptions.Controls.Add(Me.TbExec, 1, 10)
        Me.TlpMainOptions.Controls.Add(Me.Label5, 0, 11)
        Me.TlpMainOptions.Controls.Add(Me.TbTitleRegex, 1, 11)
        Me.TlpMainOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMainOptions.Location = New System.Drawing.Point(3, 38)
        Me.TlpMainOptions.Name = "TlpMainOptions"
        Me.TlpMainOptions.RowCount = 14
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMainOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpMainOptions.Size = New System.Drawing.Size(244, 307)
        Me.TlpMainOptions.TabIndex = 2
        '
        'CbDownloadSubtitles
        '
        Me.CbDownloadSubtitles.AutoSize = True
        Me.TlpMainOptions.SetColumnSpan(Me.CbDownloadSubtitles, 2)
        Me.CbDownloadSubtitles.Location = New System.Drawing.Point(3, 26)
        Me.CbDownloadSubtitles.Name = "CbDownloadSubtitles"
        Me.CbDownloadSubtitles.Size = New System.Drawing.Size(152, 17)
        Me.CbDownloadSubtitles.TabIndex = 1
        Me.CbDownloadSubtitles.Text = "Untertitel &herunterladen"
        Me.CbDownloadSubtitles.UseVisualStyleBackColor = True
        '
        'TbCustomArguments
        '
        Me.TbCustomArguments.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbCustomArguments.Location = New System.Drawing.Point(137, 312)
        Me.TbCustomArguments.Name = "TbCustomArguments"
        Me.TbCustomArguments.Size = New System.Drawing.Size(104, 22)
        Me.TbCustomArguments.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "&Eigene Argumente:"
        '
        'CbIgnoreErrors
        '
        Me.CbIgnoreErrors.AutoSize = True
        Me.CbIgnoreErrors.Checked = True
        Me.CbIgnoreErrors.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TlpMainOptions.SetColumnSpan(Me.CbIgnoreErrors, 2)
        Me.CbIgnoreErrors.Location = New System.Drawing.Point(3, 154)
        Me.CbIgnoreErrors.Name = "CbIgnoreErrors"
        Me.CbIgnoreErrors.Size = New System.Drawing.Size(108, 17)
        Me.CbIgnoreErrors.TabIndex = 11
        Me.CbIgnoreErrors.Text = "I&gnoriere Fehler"
        Me.CbIgnoreErrors.UseVisualStyleBackColor = True
        '
        'CbNoCheckCert
        '
        Me.CbNoCheckCert.AutoSize = True
        Me.CbNoCheckCert.Checked = True
        Me.CbNoCheckCert.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TlpMainOptions.SetColumnSpan(Me.CbNoCheckCert, 2)
        Me.CbNoCheckCert.Location = New System.Drawing.Point(3, 177)
        Me.CbNoCheckCert.Name = "CbNoCheckCert"
        Me.CbNoCheckCert.Size = New System.Drawing.Size(173, 17)
        Me.CbNoCheckCert.TabIndex = 12
        Me.CbNoCheckCert.Text = "H&TTPS-Zertifikat nicht prüfen"
        Me.CbNoCheckCert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Playlist &Start:"
        '
        'NudStart
        '
        Me.NudStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.NudStart.Location = New System.Drawing.Point(137, 200)
        Me.NudStart.Name = "NudStart"
        Me.NudStart.Size = New System.Drawing.Size(104, 22)
        Me.NudStart.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Playlist E&nde:"
        '
        'NudEnd
        '
        Me.NudEnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.NudEnd.Location = New System.Drawing.Point(137, 228)
        Me.NudEnd.Name = "NudEnd"
        Me.NudEnd.Size = New System.Drawing.Size(104, 22)
        Me.NudEnd.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "&Befehl nach Download:"
        '
        'TbExec
        '
        Me.TbExec.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbExec.Location = New System.Drawing.Point(137, 256)
        Me.TbExec.Name = "TbExec"
        Me.TbExec.Size = New System.Drawing.Size(104, 22)
        Me.TbExec.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Titel (Rege&x):"
        '
        'TbTitleRegex
        '
        Me.TbTitleRegex.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbTitleRegex.Location = New System.Drawing.Point(137, 284)
        Me.TbTitleRegex.Name = "TbTitleRegex"
        Me.TbTitleRegex.Size = New System.Drawing.Size(104, 22)
        Me.TbTitleRegex.TabIndex = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDownload, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TlpMainOptions, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(322, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(250, 412)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.rdbVideo, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rdbAudio, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnAbout, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(244, 29)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'rdbVideo
        '
        Me.rdbVideo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdbVideo.AutoSize = True
        Me.rdbVideo.Checked = True
        Me.rdbVideo.Location = New System.Drawing.Point(3, 6)
        Me.rdbVideo.Name = "rdbVideo"
        Me.rdbVideo.Size = New System.Drawing.Size(55, 17)
        Me.rdbVideo.TabIndex = 0
        Me.rdbVideo.TabStop = True
        Me.rdbVideo.Text = "&Video"
        Me.rdbVideo.UseVisualStyleBackColor = True
        '
        'rdbAudio
        '
        Me.rdbAudio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdbAudio.AutoSize = True
        Me.rdbAudio.Location = New System.Drawing.Point(84, 6)
        Me.rdbAudio.Name = "rdbAudio"
        Me.rdbAudio.Size = New System.Drawing.Size(56, 17)
        Me.rdbAudio.TabIndex = 1
        Me.rdbAudio.Text = "&Audio"
        Me.rdbAudio.UseVisualStyleBackColor = True
        '
        'BtnAbout
        '
        Me.BtnAbout.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.information_frame
        Me.BtnAbout.Location = New System.Drawing.Point(165, 3)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbout.TabIndex = 2
        Me.BtnAbout.Text = "Übe&r"
        Me.BtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnDownload
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.BtnDownload, 2)
        Me.BtnDownload.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnDownload.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.drive_download
        Me.BtnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDownload.Location = New System.Drawing.Point(3, 386)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.Size = New System.Drawing.Size(244, 23)
        Me.BtnDownload.TabIndex = 4
        Me.BtnDownload.Text = "&Download starten"
        Me.BtnDownload.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TbDirectory, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnBrowse, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 351)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(244, 29)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TbDirectory
        '
        Me.TbDirectory.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbDirectory.Location = New System.Drawing.Point(37, 3)
        Me.TbDirectory.Name = "TbDirectory"
        Me.TbDirectory.Size = New System.Drawing.Size(174, 22)
        Me.TbDirectory.TabIndex = 0
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(217, 3)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(24, 23)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "&..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "&Ziel:"
        '
        'CmsDownload
        '
        Me.CmsDownload.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DowloadstartenToolStripMenuItem, Me.DebugStartenToolStripMenuItem})
        Me.CmsDownload.Name = "ContextMenuStrip1"
        Me.CmsDownload.Size = New System.Drawing.Size(161, 48)
        '
        'DowloadstartenToolStripMenuItem
        '
        Me.DowloadstartenToolStripMenuItem.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.drive_download
        Me.DowloadstartenToolStripMenuItem.Name = "DowloadstartenToolStripMenuItem"
        Me.DowloadstartenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DowloadstartenToolStripMenuItem.Text = "Dowload &starten"
        '
        'DebugStartenToolStripMenuItem
        '
        Me.DebugStartenToolStripMenuItem.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.bug__arrow
        Me.DebugStartenToolStripMenuItem.Name = "DebugStartenToolStripMenuItem"
        Me.DebugStartenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DebugStartenToolStripMenuItem.Text = "&Debug starten"
        '
        'CmsDelete
        '
        Me.CmsDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LöschenToolStripMenuItem, Me.AlleLöschenToolStripMenuItem})
        Me.CmsDelete.Name = "CmsDelete"
        Me.CmsDelete.Size = New System.Drawing.Size(181, 70)
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.minus
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LöschenToolStripMenuItem.Text = "&Löschen"
        '
        'AlleLöschenToolStripMenuItem
        '
        Me.AlleLöschenToolStripMenuItem.Image = Global.Frontend_for_youtube_dl.My.Resources.Resources.cross
        Me.AlleLöschenToolStripMenuItem.Name = "AlleLöschenToolStripMenuItem"
        Me.AlleLöschenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlleLöschenToolStripMenuItem.Text = "&Alle Löschen"
        '
        'FrmNew
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 436)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(500, 475)
        Me.Name = "FrmNew"
        Me.Text = "Frontend for youtube-dl"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TlpMainOptions.ResumeLayout(False)
        Me.TlpMainOptions.PerformLayout()
        CType(Me.NudStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.CmsDownload.ResumeLayout(False)
        Me.CmsDelete.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbSubtitles As TextBox
    Friend WithEvents CbDownloadWholePlaylist As CheckBox
    Friend WithEvents TlpMainOptions As TableLayoutPanel
    Friend WithEvents CbEmbedSubtitles As CheckBox
    Friend WithEvents LblSubtitlesFormat As Label
    Friend WithEvents CbSubtitlesFormat As ComboBox
    Friend WithEvents LblAudioFormat As Label
    Friend WithEvents CbAudioFormat As ComboBox
    Friend WithEvents LblSubtitles As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TbUrl As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnDownload As Button
    Friend WithEvents rdbVideo As RadioButton
    Friend WithEvents rdbAudio As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TbDirectory As TextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents CbDownloadSubtitles As CheckBox
    Friend WithEvents CmsDownload As ContextMenuStrip
    Friend WithEvents DowloadstartenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugStartenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TbCustomArguments As TextBox
    Friend WithEvents CbIgnoreErrors As CheckBox
    Friend WithEvents CbNoCheckCert As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NudStart As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NudEnd As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents TbExec As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbTitleRegex As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnAbout As Button
    Friend WithEvents CmsDelete As ContextMenuStrip
    Friend WithEvents LöschenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlleLöschenToolStripMenuItem As ToolStripMenuItem
End Class
