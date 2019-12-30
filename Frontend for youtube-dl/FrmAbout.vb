Partial Public Class FrmAbout
    Inherits Form

    Private tabText As String() = New String(1) {}
    Private headLines As String() = New String(1) {}
    Private licenseText As String() = New String(1) {}

    Private Sub FrmAbout_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.Frontend_for_youtube_dl
        tabText(0) = "Frontend for youtube-dl"
        headLines(0) = "Frontend for youtube-dl Version " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
        licenseText(0) = "zlib License" & Environment.NewLine + Environment.NewLine & "(C) 2018 Mario Wagenknecht" + Environment.NewLine + Environment.NewLine & "This software is provided 'as-is', without any express or implied warranty. In no event will the authors be held liable for any damages arising from the use of this software." + Environment.NewLine + Environment.NewLine & "Permission is granted to anyone to use this software for any purpose, including commercial applications, and to alter it and redistribute it freely, subject to the following restrictions: " + Environment.NewLine + Environment.NewLine & "1. The origin of this software must not be misrepresented; you must not claim that you wrote the original software. If you use this software in a product, an acknowledgment in the product documentation would be appreciated but is not required." + Environment.NewLine & "2. Altered source versions must be plainly marked as such, and must not be misrepresented as being the original software." + Environment.NewLine & "3. This notice may not be removed or altered from any source distribution."
        tabText(1) = "Fugue Icons"
        headLines(1) = "Fugue Icons Version 3.5.6"
        licenseText(1) = "Einige Icons von Yusuke Kamiyamane (http://p.yusukekamiyamane.com). Lizensiert unter einer Creative Commons Namensnennung 3.0 Lizenz (https://creativecommons.org/licenses/by/3.0/deed.de)."

    End Sub

    Private Sub FrmAbout_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        TcList.SelectedTab.Text = tabText(0)
        TcList.Height -= TcList.SelectedTab.Height

        For i As Integer = 1 To tabText.Count() - 1
            TcList.TabPages.Add(tabText(i))
        Next

        TcList_SelectedIndexChanged(sender, New EventArgs())
    End Sub

    Private Sub TcList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TcList.SelectedIndexChanged
        LblVersion.Text = headLines(TcList.SelectedIndex)
        TbAbout.Text = licenseText(TcList.SelectedIndex)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClose.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class