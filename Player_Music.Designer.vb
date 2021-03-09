<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSongTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLoadPlay = New System.Windows.Forms.Button()
        Me.btnSavePlay = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnForwardNext = New System.Windows.Forms.Button()
        Me.btnRewindPrevious = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPlayPause = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblDurLengthSmall = New System.Windows.Forms.Label()
        Me.lblDurMainSmall = New System.Windows.Forms.Label()
        Me.lblDurLengthBig = New System.Windows.Forms.Label()
        Me.lblDurMainBig = New System.Windows.Forms.Label()
        Me.lvPlaylist = New System.Windows.Forms.ListView()
        Me.chTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVolDown = New System.Windows.Forms.Button()
        Me.btnVolUp = New System.Windows.Forms.Button()
        Me.cmsAddMedia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDeleteMedia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSongsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerPlay = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.cmsAddMedia.SuspendLayout()
        Me.cmsDeleteMedia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSongTitle)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 29)
        Me.Panel1.TabIndex = 0
        '
        'lblSongTitle
        '
        Me.lblSongTitle.AutoSize = True
        Me.lblSongTitle.Location = New System.Drawing.Point(7, 7)
        Me.lblSongTitle.Name = "lblSongTitle"
        Me.lblSongTitle.Size = New System.Drawing.Size(98, 13)
        Me.lblSongTitle.TabIndex = 5
        Me.lblSongTitle.Text = "Scrolling Song Title"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.AniPlayer.My.Resources.Resources._exit
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(382, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(332, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(76, 42)
        Me.Panel2.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.AniPlayer.My.Resources.Resources.add
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(39, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 30)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = Global.AniPlayer.My.Resources.Resources.remove
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(30, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnLoadPlay)
        Me.Panel3.Controls.Add(Me.btnSavePlay)
        Me.Panel3.Location = New System.Drawing.Point(251, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(80, 42)
        Me.Panel3.TabIndex = 5
        '
        'btnLoadPlay
        '
        Me.btnLoadPlay.BackgroundImage = Global.AniPlayer.My.Resources.Resources.playlist_load
        Me.btnLoadPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoadPlay.FlatAppearance.BorderSize = 0
        Me.btnLoadPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadPlay.ForeColor = System.Drawing.Color.Transparent
        Me.btnLoadPlay.Location = New System.Drawing.Point(3, 5)
        Me.btnLoadPlay.Name = "btnLoadPlay"
        Me.btnLoadPlay.Size = New System.Drawing.Size(30, 30)
        Me.btnLoadPlay.TabIndex = 1
        Me.btnLoadPlay.UseVisualStyleBackColor = True
        '
        'btnSavePlay
        '
        Me.btnSavePlay.BackgroundImage = Global.AniPlayer.My.Resources.Resources.playlist_save
        Me.btnSavePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSavePlay.FlatAppearance.BorderSize = 0
        Me.btnSavePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePlay.ForeColor = System.Drawing.Color.Transparent
        Me.btnSavePlay.Location = New System.Drawing.Point(39, 5)
        Me.btnSavePlay.Name = "btnSavePlay"
        Me.btnSavePlay.Size = New System.Drawing.Size(30, 30)
        Me.btnSavePlay.TabIndex = 0
        Me.btnSavePlay.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnForwardNext)
        Me.Panel4.Controls.Add(Me.btnRewindPrevious)
        Me.Panel4.Controls.Add(Me.btnStop)
        Me.Panel4.Controls.Add(Me.btnPlayPause)
        Me.Panel4.Location = New System.Drawing.Point(103, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(147, 42)
        Me.Panel4.TabIndex = 6
        '
        'btnForwardNext
        '
        Me.btnForwardNext.BackgroundImage = Global.AniPlayer.My.Resources.Resources.foward
        Me.btnForwardNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnForwardNext.FlatAppearance.BorderSize = 0
        Me.btnForwardNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForwardNext.Location = New System.Drawing.Point(111, 5)
        Me.btnForwardNext.Name = "btnForwardNext"
        Me.btnForwardNext.Size = New System.Drawing.Size(30, 30)
        Me.btnForwardNext.TabIndex = 4
        Me.btnForwardNext.UseVisualStyleBackColor = True
        '
        'btnRewindPrevious
        '
        Me.btnRewindPrevious.BackgroundImage = Global.AniPlayer.My.Resources.Resources.rewind
        Me.btnRewindPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRewindPrevious.FlatAppearance.BorderSize = 0
        Me.btnRewindPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRewindPrevious.Location = New System.Drawing.Point(75, 5)
        Me.btnRewindPrevious.Name = "btnRewindPrevious"
        Me.btnRewindPrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnRewindPrevious.TabIndex = 3
        Me.btnRewindPrevious.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = Global.AniPlayer.My.Resources.Resources._stop
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(39, 5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(30, 30)
        Me.btnStop.TabIndex = 2
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackgroundImage = Global.AniPlayer.My.Resources.Resources.play
        Me.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayPause.FlatAppearance.BorderSize = 0
        Me.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayPause.Location = New System.Drawing.Point(3, 5)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(30, 30)
        Me.btnPlayPause.TabIndex = 0
        Me.btnPlayPause.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblDurLengthSmall)
        Me.Panel5.Controls.Add(Me.lblDurMainSmall)
        Me.Panel5.Location = New System.Drawing.Point(0, 145)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(102, 42)
        Me.Panel5.TabIndex = 7
        '
        'lblDurLengthSmall
        '
        Me.lblDurLengthSmall.AutoSize = True
        Me.lblDurLengthSmall.Font = New System.Drawing.Font("Nexa Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurLengthSmall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.lblDurLengthSmall.Location = New System.Drawing.Point(43, 13)
        Me.lblDurLengthSmall.Name = "lblDurLengthSmall"
        Me.lblDurLengthSmall.Size = New System.Drawing.Size(53, 16)
        Me.lblDurLengthSmall.TabIndex = 1
        Me.lblDurLengthSmall.Text = "/ 00:00"
        '
        'lblDurMainSmall
        '
        Me.lblDurMainSmall.AutoSize = True
        Me.lblDurMainSmall.Font = New System.Drawing.Font("Nexa Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurMainSmall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblDurMainSmall.Location = New System.Drawing.Point(3, 13)
        Me.lblDurMainSmall.Name = "lblDurMainSmall"
        Me.lblDurMainSmall.Size = New System.Drawing.Size(43, 16)
        Me.lblDurMainSmall.TabIndex = 0
        Me.lblDurMainSmall.Text = "00:00"
        '
        'lblDurLengthBig
        '
        Me.lblDurLengthBig.AutoSize = True
        Me.lblDurLengthBig.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.lblDurLengthBig.Font = New System.Drawing.Font("Nexa Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurLengthBig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblDurLengthBig.Location = New System.Drawing.Point(23, 87)
        Me.lblDurLengthBig.Name = "lblDurLengthBig"
        Me.lblDurLengthBig.Size = New System.Drawing.Size(52, 19)
        Me.lblDurLengthBig.TabIndex = 9
        Me.lblDurLengthBig.Text = "00:00"
        '
        'lblDurMainBig
        '
        Me.lblDurMainBig.AutoSize = True
        Me.lblDurMainBig.Font = New System.Drawing.Font("Nexa Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurMainBig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblDurMainBig.Location = New System.Drawing.Point(12, 61)
        Me.lblDurMainBig.Name = "lblDurMainBig"
        Me.lblDurMainBig.Size = New System.Drawing.Size(77, 26)
        Me.lblDurMainBig.TabIndex = 8
        Me.lblDurMainBig.Text = "00:00"
        '
        'lvPlaylist
        '
        Me.lvPlaylist.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvPlaylist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTitle, Me.chDur, Me.chFileName})
        Me.lvPlaylist.Font = New System.Drawing.Font("TYPOGRAPH PRO", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPlaylist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lvPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPlaylist.HideSelection = False
        Me.lvPlaylist.Location = New System.Drawing.Point(103, 31)
        Me.lvPlaylist.MultiSelect = False
        Me.lvPlaylist.Name = "lvPlaylist"
        Me.lvPlaylist.Size = New System.Drawing.Size(304, 113)
        Me.lvPlaylist.TabIndex = 10
        Me.lvPlaylist.UseCompatibleStateImageBehavior = False
        Me.lvPlaylist.View = System.Windows.Forms.View.Details
        '
        'chTitle
        '
        Me.chTitle.Text = "Song Title"
        Me.chTitle.Width = 224
        '
        'chDur
        '
        Me.chDur.Text = "Duration"
        Me.chDur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.chDur.Width = 72
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        Me.chFileName.Width = 0
        '
        'btnVolDown
        '
        Me.btnVolDown.BackgroundImage = Global.AniPlayer.My.Resources.Resources.volume_decrease
        Me.btnVolDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolDown.FlatAppearance.BorderSize = 0
        Me.btnVolDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolDown.Location = New System.Drawing.Point(6, 109)
        Me.btnVolDown.Name = "btnVolDown"
        Me.btnVolDown.Size = New System.Drawing.Size(30, 30)
        Me.btnVolDown.TabIndex = 11
        Me.btnVolDown.UseVisualStyleBackColor = True
        '
        'btnVolUp
        '
        Me.btnVolUp.BackgroundImage = Global.AniPlayer.My.Resources.Resources.volume_increase
        Me.btnVolUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolUp.FlatAppearance.BorderSize = 0
        Me.btnVolUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolUp.Location = New System.Drawing.Point(71, 109)
        Me.btnVolUp.Name = "btnVolUp"
        Me.btnVolUp.Size = New System.Drawing.Size(30, 30)
        Me.btnVolUp.TabIndex = 12
        Me.btnVolUp.UseVisualStyleBackColor = True
        '
        'cmsAddMedia
        '
        Me.cmsAddMedia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.DirectoryToolStripMenuItem})
        Me.cmsAddMedia.Name = "ContextMenuStrip1"
        Me.cmsAddMedia.Size = New System.Drawing.Size(123, 48)
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'DirectoryToolStripMenuItem
        '
        Me.DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem"
        Me.DirectoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DirectoryToolStripMenuItem.Text = "Directory"
        '
        'cmsDeleteMedia
        '
        Me.cmsDeleteMedia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSongToolStripMenuItem, Me.DeleteSongsToolStripMenuItem})
        Me.cmsDeleteMedia.Name = "ContextMenuStrip2"
        Me.cmsDeleteMedia.Size = New System.Drawing.Size(143, 48)
        '
        'DeleteSongToolStripMenuItem
        '
        Me.DeleteSongToolStripMenuItem.Name = "DeleteSongToolStripMenuItem"
        Me.DeleteSongToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeleteSongToolStripMenuItem.Text = "Delete Song"
        '
        'DeleteSongsToolStripMenuItem
        '
        Me.DeleteSongsToolStripMenuItem.Name = "DeleteSongsToolStripMenuItem"
        Me.DeleteSongsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeleteSongsToolStripMenuItem.Text = "Delete Songs"
        '
        'timerPlay
        '
        '
        'formMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 186)
        Me.Controls.Add(Me.btnVolUp)
        Me.Controls.Add(Me.btnVolDown)
        Me.Controls.Add(Me.lvPlaylist)
        Me.Controls.Add(Me.lblDurLengthBig)
        Me.Controls.Add(Me.lblDurMainBig)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MusicPlayer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.cmsAddMedia.ResumeLayout(False)
        Me.cmsDeleteMedia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSavePlay As Button
    Friend WithEvents btnLoadPlay As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnForwardNext As Button
    Friend WithEvents btnRewindPrevious As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlayPause As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblDurLengthSmall As Label
    Friend WithEvents lblDurMainSmall As Label
    Friend WithEvents lblDurLengthBig As Label
    Friend WithEvents lblDurMainBig As Label
    Friend WithEvents lvPlaylist As ListView
    Friend WithEvents chTitle As ColumnHeader
    Friend WithEvents chDur As ColumnHeader
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents btnVolDown As Button
    Friend WithEvents btnVolUp As Button
    Friend WithEvents cmsAddMedia As ContextMenuStrip
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsDeleteMedia As ContextMenuStrip
    Friend WithEvents DeleteSongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSongsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents timerPlay As Timer
    Friend WithEvents btnClose As Button
    Friend WithEvents lblSongTitle As Label
End Class
