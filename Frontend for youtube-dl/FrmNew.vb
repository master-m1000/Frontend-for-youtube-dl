Option Strict Off
Public Class FrmNew
    Private Sub FrmNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSubtitles.Visible = False
        TbSubtitles.Visible = False
        CbEmbedSubtitles.Visible = False
        LblSubtitlesFormat.Visible = False
        CbSubtitlesFormat.Visible = False
        CbSubtitlesFormat.SelectedIndex = 0
        LblAudioFormat.Visible = False
        CbAudioFormat.Visible = False
        CbAudioFormat.SelectedIndex = 0
        BtnDelete.Enabled = False
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Delete Then BtnDelete_Click(sender, New EventArgs())
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        For Each s As String In TbUrl.Text.Split(Char.Parse(" "))
            If String.IsNullOrWhiteSpace(s) = True Then Continue For
            ListBox1.Items.Add(s)
        Next

        TbUrl.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click, LöschenToolStripMenuItem.Click
        If ListBox1.SelectedItems.Count = 0 Then Return
        Dim index As List(Of Integer) = New List(Of Integer)
        For Each o In ListBox1.SelectedIndices
            index.Add(o)
        Next
        For Each s In index.ToArray().Reverse()
            ListBox1.Items.RemoveAt(s)
        Next
    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles BtnDownload.Click, DowloadstartenToolStripMenuItem.Click, DebugStartenToolStripMenuItem.Click
        If String.IsNullOrWhiteSpace(TbUrl.Text) = False And ListBox1.Items.Count = 0 Then BtnAdd.PerformClick()

        'Prüfe Anzahl Video-URLs
        If ListBox1.Items.Count < 1 Then
            MessageBox.Show(Me, "Bitte geben Sie eine oder mehrere Video-URLs/-IDs an", "Keine Video-ID/-URL angegeben", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'Prüfe auf youtube-dl.exe
        Dim path As String = ""
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

        If IO.Directory.Exists(TbDirectory.Text) = False Then
            MessageBox.Show(Me, "Das angegebene Zielverzeichnis existiert nicht!" & Environment.NewLine & "Bitte legen Sie es an oder wählen Sie ein anderes Verzeichnis aus.", "Zielverzeichnis existiert nicht", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            TbDirectory.Select()
            Exit Sub
        End If

        Dim Psi As New ProcessStartInfo With {.FileName = path, .Arguments = "--console-title -o ""%(title)s.%(ext)s"" ", .WorkingDirectory = TbDirectory.Text}

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

        While rdbAudio.Checked = True And IO.File.Exists(FileIO.FileSystem.CombinePath(New IO.FileInfo(path).Directory.FullName, "ffprobe.exe")) = False
            If MessageBox.Show(Me, "Konnte ""ffprobe.exe"" nicht finden!" & vbNewLine & "Bitte legen Sie diese im selben Verzeichnis, wie die ""ffmpeg.exe"" ab.", "Konnte ""ffprobe.exe"" nicht finden", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Cancel Then
                Exit Sub
            End If
        End While

        If rdbVideo.Checked = True Then
            'Video
            Psi.Arguments &= "-f ""bestvideo[ext=mp4]+bestaudio[ext=m4a]/bestvideo+bestaudio"" --merge-output-format mp4 "
        Else
            'Audio
            If CbAudioFormat.SelectedItem.ToString = "beste Qualität" Then
                Psi.Arguments &= "-x --audio-format ""best"" "
            Else
                Psi.Arguments &= "-x --audio-format """ & CbAudioFormat.SelectedItem.ToString & """ "
            End If
        End If

        'Playlist
        If CbDownloadWholePlaylist.Checked = True Then
            Psi.Arguments &= "--yes-playlist "
        Else
            Psi.Arguments &= "--no-playlist "
        End If
        If NudStart.Value > 0 Then
            Psi.Arguments &= "--playlist-start " & NudStart.Value.ToString() & " "
        End If
        If NudEnd.Value > 0 Then
            Psi.Arguments &= "--playlist-end " & NudEnd.Value.ToString() & " "
        End If

        'Untertitel
        If CbDownloadSubtitles.Checked = True And rdbVideo.Checked = True Then
            Psi.Arguments &= "--convert-subs " & CbSubtitlesFormat.SelectedItem.ToString.ToLower & " --sub-lang """ & TbSubtitles.Text & """ --write-sub "
            If CbEmbedSubtitles.Checked = True Then
                Psi.Arguments &= "--embed-subs "
            End If
        End If

        'Exec
        If String.IsNullOrWhiteSpace(TbExec.Text) = False Then
            Psi.Arguments &= "--exec """ & TbExec.Text & """ "
        End If

        'Titel Regex
        If String.IsNullOrWhiteSpace(TbTitleRegex.Text) = False Then
            Psi.Arguments &= "--match-title """ & TbTitleRegex.Text & """ "
        End If

        'Fehler ignorieren
        If CbIgnoreErrors.Checked = True Then
            Psi.Arguments &= "--ignore-errors "
        End If

        'Fehler ignorieren
        If CbNoCheckCert.Checked = True Then
            Psi.Arguments &= "--no-check-certificate "
        End If

        'eigene Argumente
        If String.IsNullOrWhiteSpace(TbCustomArguments.Text) = False Then
            Psi.Arguments &= TbCustomArguments.Text & " "
        End If

        'IDs und URLs
        For Each item As String In ListBox1.Items
            Psi.Arguments &= item + " "
        Next

        'Starten
        If sender Is DebugStartenToolStripMenuItem Then
            Process.Start(New ProcessStartInfo With {.FileName = "cmd.exe", .WorkingDirectory = New IO.FileInfo(path).Directory.FullName, .Arguments = "/k youtube-dl.exe " & Psi.Arguments})
        Else
            Process.Start(Psi)
        End If
    End Sub

    Private Sub ChangeVisibilty(sender As Object, e As EventArgs) Handles rdbVideo.CheckedChanged, CbDownloadSubtitles.CheckedChanged
        LblAudioFormat.Visible = Not rdbVideo.Checked
        CbAudioFormat.Visible = Not rdbVideo.Checked
        CbDownloadSubtitles.Visible = rdbVideo.Checked
        LblSubtitles.Visible = rdbVideo.Checked And CbDownloadSubtitles.Checked
        TbSubtitles.Visible = rdbVideo.Checked And CbDownloadSubtitles.Checked
        CbEmbedSubtitles.Visible = rdbVideo.Checked And CbDownloadSubtitles.Checked
        LblSubtitlesFormat.Visible = rdbVideo.Checked And CbDownloadSubtitles.Checked
        CbSubtitlesFormat.Visible = rdbVideo.Checked And CbDownloadSubtitles.Checked
    End Sub

    Private Sub BtnDownload_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDownload.MouseUp
        If e.Button <> MouseButtons.Right Then Return
        CmsDownload.Show(BtnDownload, New Point(BtnDownload.Margin.Left, BtnDownload.Margin.Top), ToolStripDropDownDirection.Default)

    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Dim text = e.Data.GetData(DataFormats.Text, True)
        If text Is Nothing Or text.GetType() IsNot "".GetType() Then Return
        ListBox1.Items.Add(text)
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub TbUrl_DragDrop(sender As Object, e As DragEventArgs) Handles TbUrl.DragDrop
        Dim text = e.Data.GetData(DataFormats.Text, True)
        If text Is Nothing Or text.GetType() IsNot "".GetType() Then Return
        TbUrl.Text = text
        Return

        Dim formats As String() = {DataFormats.Bitmap, DataFormats.CommaSeparatedValue, DataFormats.Dib, DataFormats.Dif, DataFormats.EnhancedMetafile, DataFormats.FileDrop, DataFormats.Html, DataFormats.Locale, DataFormats.MetafilePict, DataFormats.OemText, DataFormats.Palette, DataFormats.PenData, DataFormats.Riff, DataFormats.Rtf, DataFormats.Serializable, DataFormats.StringFormat, DataFormats.SymbolicLink, DataFormats.Text, DataFormats.Tiff, DataFormats.UnicodeText, DataFormats.WaveAudio}
        Dim formatString As String = "DataFormats.Bitmap,DataFormats.CommaSeparatedValue,DataFormats.Dib,DataFormats.Dif,DataFormats.EnhancedMetafile,DataFormats.FileDrop,DataFormats.Html,DataFormats.Locale,DataFormats.MetafilePict,DataFormats.OemText,DataFormats.Palette,DataFormats.PenData,DataFormats.Riff,DataFormats.Rtf,DataFormats.Serializable,DataFormats.StringFormat,DataFormats.SymbolicLink,DataFormats.Text,DataFormats.Tiff,DataFormats.UnicodeText,DataFormats.WaveAudio,"
        Dim result As String = "", i As Integer = 0, res As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        For Each s In formats
            Try
                Dim test = e.Data.GetData(s, True)
                If test Is Nothing Then Exit Try
                res.Add(formatString.Split(",")(i), test)
                result += formatString.Split(",")(i) + ";"
            Catch ex As Exception

            End Try
            i += 1
        Next
    End Sub

    Private Sub TbUrl_DragEnter(sender As Object, e As DragEventArgs) Handles TbUrl.DragEnter
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        BtnDelete.Enabled = (ListBox1.SelectedItems.Count > 0)
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim fbd As New FolderBrowserDialog With {.Description = "Bitte geben Sie an, wo die Videos gespeichert werden sollen.", .SelectedPath = TbDirectory.Text}
        If fbd.ShowDialog = DialogResult.OK Then
            TbDirectory.Text = fbd.SelectedPath
        End If
        fbd.Dispose()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Dim dialog As FrmAbout = New FrmAbout
        dialog.ShowDialog(Me)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TbExec.Text = "D:\Programme\VLC\vlc.exe --started-from-file --playlist-enqueue {}"
        TbDirectory.Text = "D:\YouTube\Cache"
    End Sub

    Private Sub AlleLöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlleLöschenToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseUp, BtnDelete.MouseUp
        If e.Button <> MouseButtons.Right Then Return
        CmsDelete.Show(ListBox1, e.Location, ToolStripDropDownDirection.Default)
    End Sub

    Private Sub CmsDelete_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CmsDelete.Opening
        LöschenToolStripMenuItem.Enabled = ListBox1.SelectedIndices.Count > 0
        'Alles Löschen immer anzeigen
    End Sub
End Class