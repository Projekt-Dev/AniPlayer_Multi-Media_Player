Imports System.IO
Imports WMPLib
Public Class formMP
    Private WithEvents player As New WindowsMediaPlayer

    'Get autoplay to work
    'play next song when song ends
    'add progress bar
    'add volume bar



    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click
        Dim diaF As New OpenFileDialog
        diaF.Filter = "Audio Files|*.mp3;*.m4a;*.wav;*.wma;*.flac;*.mp4;*.aac"
        diaF.Multiselect = True
        diaF.Title = "Open Music Files"

        If diaF.ShowDialog = DialogResult.OK Then
            For Each file As String In diaF.FileNames
                Dim item As ListViewItem = lvPlaylist.Items.Add(IO.Path.GetFileNameWithoutExtension(file))
                item.SubItems.Add(player.newMedia(file).durationString)
                item.SubItems.Add(file)
            Next
            btnPlayPause.PerformClick()
            lvPlaylist.Select()
        End If

    End Sub

    Private Sub DirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryToolStripMenuItem.Click
        Dim diaD As New FolderBrowserDialog
        If diaD.ShowDialog = DialogResult.OK Then
            Dim audioFiles = From file In Directory.EnumerateFiles(diaD.SelectedPath) Let extension = Path.GetExtension(file)
                             Where extension.Equals(".m4a") OrElse extension.Equals(".mp3") OrElse extension.Equals(".wav") OrElse extension.Equals(".wma") _
                             OrElse extension.Equals(".flac") OrElse extension.Equals(".mp4") OrElse extension.Equals(".aac") Select file

            For Each file In audioFiles
                Dim item As ListViewItem = lvPlaylist.Items.Add(IO.Path.GetFileNameWithoutExtension(file))
                item.SubItems.Add(player.newMedia(file).durationString)
                item.SubItems.Add(file)
            Next
            btnPlayPause.PerformClick()
            lvPlaylist.Select()
        End If
    End Sub

    Private Sub DeleteSongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSongToolStripMenuItem.Click
        If lvPlaylist.SelectedIndices.Count > 0 Then
            Dim x As Integer = lvPlaylist.SelectedIndices(0)
            lvPlaylist.Items.RemoveAt(lvPlaylist.SelectedIndices(0))
            lvPlaylist.Items(x).Selected = True
            lvPlaylist.Items(x).EnsureVisible()
            lvPlaylist.Select()
        End If
    End Sub

    Private Sub DeleteSongsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSongsToolStripMenuItem.Click
        If lvPlaylist.SelectedIndices.Count > 0 Then
            lvPlaylist.Items.Clear()
        End If
    End Sub

#Region "Controls"

    Private Sub btnSavePlay_Click(sender As Object, e As EventArgs) Handles btnSavePlay.Click
        Dim s As New SaveFileDialog
        s.Filter = "AniPlayer Playlists|*.amp"
        s.Title = "Save Playlist"
        If s.ShowDialog = DialogResult.OK Then
            Dim myWriter As New StreamWriter(s.FileName)
            For Each item As ListViewItem In lvPlaylist.Items
                myWriter.WriteLine(item.Text + "," + item.SubItems(1).Text + "," + item.SubItems(2).Text)
            Next
            myWriter.Close()
        End If
    End Sub

    Private Sub btnLoadPlay_Click(sender As Object, e As EventArgs) Handles btnLoadPlay.Click
        Dim l As New OpenFileDialog
        l.Filter = "AniPlayer Playlists|*.amp"
        l.Title = "Load AniPlayer Playlist"
        If l.ShowDialog = DialogResult.OK Then
            Dim firstline() As String = File.ReadAllLines(l.FileName)
            For Each lm As String In firstline
                Dim data() As String = lm.Split(","c)
                Dim item As ListViewItem = lvPlaylist.Items.Add(data(0))
                item.SubItems.Add(data(1))
                item.SubItems.Add(data(2))
            Next
            btnPlayPause.PerformClick()
            lvPlaylist.Select()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cmsAddMedia.Show(btnAdd, 0, btnAdd.Height)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cmsDeleteMedia.Show(btnDelete, 0, btnDelete.Height)
    End Sub

    Private Sub btnVolUp_Click(sender As Object, e As EventArgs) Handles btnVolUp.Click
        If player.settings.volume >= 100 Then
            Return
        Else
            player.settings.volume += 2
        End If
    End Sub

    Private Sub btnVolDown_Click(sender As Object, e As EventArgs) Handles btnVolDown.Click
        If player.settings.volume <= 0 Then
            Return
        Else
            player.settings.volume -= 2
        End If
    End Sub

    Private Sub btnPlayPause_Click(sender As Object, e As EventArgs) Handles btnPlayPause.Click

        If player.playState = WMPPlayState.wmppsPaused Then
            player.controls.play()
            timerPlay.Start()
        Else
            If lvPlaylist.SelectedIndices.Count > 0 Then
                player.URL = lvPlaylist.Items(lvPlaylist.SelectedIndices(0)).SubItems(2).Text
                player.controls.play()
                lvPlaylist.Select()
                timerPlay.Start()
            End If
        End If


    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If player.playState = WMPPlayState.wmppsPlaying Or WMPPlayState.wmppsPaused Then
            player.controls.stop()
            timerPlay.Stop()
            lblDurLengthSmall.Text = "/ 00:00"
            lblDurMainSmall.Text = "00:00"
            lblDurLengthBig.Text = "00:00"
            lblDurMainBig.Text = "00:00"
        End If
    End Sub

    Private Sub btnForwardNext_MouseDown(sender As Object, e As MouseEventArgs) Handles btnForwardNext.MouseDown
        Select Case MouseButtons
            Case MouseButtons.Left
                player.controls.currentPosition += 10

            Case MouseButtons.Right
                If lvPlaylist.SelectedIndices.Count > 0 Then
                    Try
                        Dim g As Integer = lvPlaylist.SelectedIndices(0)
                        g += 1
                        lvPlaylist.Items(g).Selected = True
                        lvPlaylist.Items(g).EnsureVisible()
                        lvPlaylist.Select()
                    Catch ex As Exception
                        lvPlaylist.Items(0).Selected = True
                        lvPlaylist.Items(0).EnsureVisible()
                        lvPlaylist.Select()
                    End Try
                    btnPlayPause.PerformClick()
                End If
        End Select
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

#End Region

    Private Sub timerPlay_Tick(sender As Object, e As EventArgs) Handles timerPlay.Tick

        lblDurMainSmall.Text = player.controls.currentPositionString
        lblDurMainBig.Text = player.controls.currentPositionString
        lblDurLengthSmall.Text = "/ " + player.controls.currentItem.durationString
        lblDurLengthBig.Text = player.controls.currentItem.durationString
        If lblDurMainSmall.Text = String.Empty Then
            lblDurLengthSmall.Text = String.Empty
            lblDurLengthBig.Text = String.Empty
        End If

    End Sub

End Class
