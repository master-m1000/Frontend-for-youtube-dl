Public Class FrmMain
    Dim debugmode As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(300, 300)
        CoBSubtitlesFormat.SelectedIndex = 2
        CobAudioFormat.SelectedIndex = 3
        TbCustomArguments.BringToFront()
        LblCustomArguments.BringToFront()
    End Sub

    Private Sub ChangeControlVisibility(sender As Object, e As EventArgs) Handles RdbVideo.CheckedChanged, CbDownloadSubtitles.CheckedChanged
        CbDownloadSubtitles.Visible = RdbVideo.Checked
        LblSubtitles.Visible = CbDownloadSubtitles.Checked And RdbVideo.Checked
        TbSubtitles.Visible = CbDownloadSubtitles.Checked And RdbVideo.Checked
        CbEmbedSubtitles.Visible = CbDownloadSubtitles.Checked And RdbVideo.Checked
        LblSubtitlesFormat.Visible = CbDownloadSubtitles.Checked And RdbVideo.Checked
        CoBSubtitlesFormat.Visible = CbDownloadSubtitles.Checked And RdbVideo.Checked
        LblAudioFormat.Visible = RdbAudio.Checked
        CobAudioFormat.Visible = RdbAudio.Checked
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If String.IsNullOrWhiteSpace(TbIds.Text) = True Then
            MessageBox.Show(Me, "Bitte geben Sie eine Video-URL oder eine Video-ID an", "Keine Video-ID/-URL angegeben", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim path As String = ""

        'Prüfe auf youtube-dl.exe
        If IO.File.Exists(FileIO.FileSystem.CombinePath(Application.StartupPath, "youtube-dl.exe")) = False Then
            If MessageBox.Show(Me, "Konnte ""youtube-dl.exe"" nicht finden!" & vbNewLine & "Bitte geben Sie den Pfad manuell an", "Konnte ""youtube-dl.exe"" nicht finden", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                Dim ofd As New OpenFileDialog With {.AddExtension = True, .CheckFileExists = True, .DefaultExt = "exe", .FileName = "youtube-dl.exe", .Filter = "Anwendungen|*.exe|Alle Dateien|*"}
                If ofd.ShowDialog = DialogResult.OK Then
                    path = ofd.FileName
                    ofd.Dispose()
                Else
                    ofd.Dispose()
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        Else
            path = FileIO.FileSystem.CombinePath(Application.StartupPath, "youtube-dl.exe")
        End If

        If IO.Directory.Exists(TbSaveDirectory.Text) = False Then
            MessageBox.Show(Me, "Das angegebene Zielverzeichnis existiert nicht!" & Environment.NewLine & "Bitte legen Sie es an oder wählen Sie ein anderes Verzeichnis aus.", "Zielverzeichnis existiert nicht", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            TbSaveDirectory.Select()
            Exit Sub
        End If

        Dim Psi As New ProcessStartInfo With {.FileName = path, .Arguments = "--console-title -o ""%(title)s.%(ext)s"" ", .WorkingDirectory = TbSaveDirectory.Text}

        Dim ffmpeglocalation As String = ""
        If IO.File.Exists(FileIO.FileSystem.CombinePath(New IO.FileInfo(path).Directory.FullName, "ffmpeg.exe")) = True Then
            ffmpeglocalation = New IO.FileInfo(path).Directory.FullName
        Else
            If MessageBox.Show(Me, "Konnte ""ffmpeg.exe"" nicht finden!" & vbNewLine & "Bitte geben Sie den Pfad manuell an", "Konnte ""ffmpeg.exe"" nicht finden", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim ofd As New OpenFileDialog With {.RestoreDirectory = False, .AddExtension = True, .CheckFileExists = True, .DefaultExt = "exe", .FileName = "ffmpeg.exe", .Filter = "Anwendungen|*.exe|Alle Dateien|*"}
                If ofd.ShowDialog = DialogResult.OK Then
                    ffmpeglocalation = New IO.FileInfo(ofd.FileName).Directory.FullName
                    Psi.Arguments &= "--ffmpeg-location " & ofd.FileName & " "
                    ofd.Dispose()
                Else
                    ofd.Dispose()
                    Exit Sub
                End If
            End If
        End If

        While RdbAudio.Checked = True And IO.File.Exists(FileIO.FileSystem.CombinePath(New IO.FileInfo(path).Directory.FullName, "ffprobe.exe")) = False
            If MessageBox.Show(Me, "Konnte ""ffprobe.exe"" nicht finden!" & vbNewLine & "Bitte legen Sie diese im selben Verzeichnis, wie die ""ffmpeg.exe"" ab.", "Konnte ""ffprobe.exe"" nicht finden", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Cancel Then
                Exit Sub
            End If
        End While

        If RdbVideo.Checked = True Then
            'Video
            Psi.Arguments &= "-f ""bestvideo[ext=mp4]+bestaudio[ext=m4a]/bestvideo+bestaudio"" --merge-output-format mp4 "
        Else
            'Audio
            If CobAudioFormat.SelectedItem.ToString = "beste Qualität" Then
                Psi.Arguments &= "-x --audio-format ""best"" "
            Else
                Psi.Arguments &= "-x --audio-format """ & CobAudioFormat.SelectedItem.ToString & """ "
            End If
        End If

        'Playlist
        If CbDownloadWholePlaylist.Checked = True Then
            Psi.Arguments &= "--yes-playlist "
        Else
            Psi.Arguments &= "--no-playlist "
        End If

        'Untertitel
        If CbDownloadSubtitles.Checked = True And RdbVideo.Checked = True Then
            Psi.Arguments &= "--convert-subs " & CoBSubtitlesFormat.SelectedItem.ToString.ToLower & " --sub-lang """ & TbSubtitles.Text & """ --write-sub "
            If CbEmbedSubtitles.Checked = True Then
                Psi.Arguments &= "--embed-subs "
            End If
        End If

        'eigene Argumente
        If String.IsNullOrWhiteSpace(TbCustomArguments.Text) = False Then
            Psi.Arguments &= TbCustomArguments.Text & " "
        End If

        'IDs und URLs
        Psi.Arguments &= TbIds.Text

        'Starten
        If DEBUGMODE = True Then
            Process.Start(New ProcessStartInfo With {.FileName = "cmd.exe", .WorkingDirectory = New IO.FileInfo(path).Directory.FullName, .Arguments = "/k youtube-dl.exe " & Psi.Arguments})
        Else
            Process.Start(Psi)
        End If
    End Sub

    Private Sub BtnCustomArguments_Click(sender As Object, e As EventArgs) Handles BtnCustomArguments.Click
        TbCustomArguments.Visible = Not TbCustomArguments.Visible
        LblCustomArguments.Visible = Not LblCustomArguments.Visible
        TlpMainOptions.Visible = Not TlpMainOptions.Visible
    End Sub

    Private Sub LblIds_DoubleClick(sender As Object, e As EventArgs) Handles LblIds.DoubleClick
        If debugmode = False Then
            MessageBox.Show(Me, "Der Debug-Modus wurde aktiviert!" & vbNewLine & "Zum Deaktivieren das Label erneut doppelklicken.", "Debug-Modus aktiviert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            debugmode = True
            Text = "[DEBUG] Frontend for youtube-dl"
        Else
            MessageBox.Show(Me, "Der Debug-Modus wurde deaktiviert!" & vbNewLine & "Zum Aktivieren das Label erneut doppelklicken.", "Debug-Modus deaktiviert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            debugmode = False
            Text = "Frontend for youtube-dl"
        End If
    End Sub

    Private Sub BtnSaveDirectory_Click(sender As Object, e As EventArgs) Handles BtnSaveDirectory.Click
        Dim fbd As New FolderBrowserDialog With {.Description = "Bitte geben Sie an, wo die Videos gespeichert werden sollen.", .SelectedPath = TbSaveDirectory.Text}
        If fbd.ShowDialog = DialogResult.OK Then
            TbSaveDirectory.Text = fbd.SelectedPath
        End If
        fbd.Dispose()
    End Sub

    Private Sub LblCustomArguments_DoubleClick(sender As Object, e As EventArgs) Handles LblCustomArguments.DoubleClick
        TbCustomArguments.Text = "--ignore-errors --no-check-certificate --playlist-start NUMBER --playlist-end NUMBER"
    End Sub
End Class
