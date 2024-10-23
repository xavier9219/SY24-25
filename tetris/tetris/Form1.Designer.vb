<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        avatar = New PictureBox()
        Timer1 = New Timer(components)
        astroid = New PictureBox()
        enemy = New PictureBox()
        enemy2 = New PictureBox()
        platform = New PictureBox()
        enemy3 = New PictureBox()
        astroid2 = New PictureBox()
        platform2 = New PictureBox()
        enemy4 = New PictureBox()
        Label1 = New Label()
        scorelabel = New Label()
        Timer2 = New Timer(components)
        finalscore = New Label()
        PictureBox1wall = New PictureBox()
        PictureBox3wall = New PictureBox()
        PictureBox2wall = New PictureBox()
        PictureBox4wall = New PictureBox()
        astroid3 = New PictureBox()
        resetlabeleasy = New Label()
        resetlabelnormal = New Label()
        resetlabelhard = New Label()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(astroid, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(astroid2, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform2, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4wall, ComponentModel.ISupportInitialize).BeginInit()
        CType(astroid3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = My.Resources.Resources._439_4392668_pixel_spaceship_png_pixel_spaceship
        avatar.Location = New Point(12, 12)
        avatar.Name = "avatar"
        avatar.Size = New Size(86, 88)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' astroid
        ' 
        astroid.Image = My.Resources.Resources._3df0c312d89ed5b_pngastroid
        astroid.Location = New Point(1545, 744)
        astroid.Name = "astroid"
        astroid.Size = New Size(130, 130)
        astroid.SizeMode = PictureBoxSizeMode.Zoom
        astroid.TabIndex = 1
        astroid.TabStop = False
        astroid.Tag = "astroid"
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources._363116e7da047bd
        enemy.Location = New Point(1092, 608)
        enemy.Name = "enemy"
        enemy.Size = New Size(181, 112)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = My.Resources.Resources._363116e7da047bd
        enemy2.Location = New Point(1092, 12)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(181, 112)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' platform
        ' 
        platform.BackColor = SystemColors.ActiveCaptionText
        platform.Location = New Point(414, 31)
        platform.Name = "platform"
        platform.Size = New Size(70, 634)
        platform.TabIndex = 4
        platform.TabStop = False
        platform.Tag = ""
        platform.Visible = False
        ' 
        ' enemy3
        ' 
        enemy3.Image = My.Resources.Resources._363116e7da047bd
        enemy3.Location = New Point(510, 241)
        enemy3.Name = "enemy3"
        enemy3.Size = New Size(181, 112)
        enemy3.SizeMode = PictureBoxSizeMode.Zoom
        enemy3.TabIndex = 5
        enemy3.TabStop = False
        enemy3.Tag = "1"
        ' 
        ' astroid2
        ' 
        astroid2.Image = My.Resources.Resources._3df0c312d89ed5b_pngastroid
        astroid2.Location = New Point(1365, 12)
        astroid2.Name = "astroid2"
        astroid2.Size = New Size(130, 130)
        astroid2.SizeMode = PictureBoxSizeMode.Zoom
        astroid2.TabIndex = 6
        astroid2.TabStop = False
        astroid2.Tag = "astroid"
        ' 
        ' platform2
        ' 
        platform2.BackColor = SystemColors.ActiveCaptionText
        platform2.Location = New Point(510, 359)
        platform2.Name = "platform2"
        platform2.Size = New Size(1271, 53)
        platform2.TabIndex = 7
        platform2.TabStop = False
        platform2.Visible = False
        ' 
        ' enemy4
        ' 
        enemy4.Image = My.Resources.Resources._363116e7da047bd
        enemy4.Location = New Point(510, 418)
        enemy4.Name = "enemy4"
        enemy4.Size = New Size(181, 112)
        enemy4.SizeMode = PictureBoxSizeMode.Zoom
        enemy4.TabIndex = 8
        enemy4.TabStop = False
        enemy4.Tag = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(12, 628)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 46)
        Label1.TabIndex = 9
        Label1.Text = "victory"
        Label1.Visible = False
        ' 
        ' scorelabel
        ' 
        scorelabel.AutoSize = True
        scorelabel.Font = New Font("Segoe UI", 30F)
        scorelabel.ForeColor = SystemColors.ButtonHighlight
        scorelabel.Location = New Point(12, 674)
        scorelabel.Name = "scorelabel"
        scorelabel.Size = New Size(43, 67)
        scorelabel.TabIndex = 11
        scorelabel.Text = " "
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' finalscore
        ' 
        finalscore.AutoSize = True
        finalscore.Font = New Font("Segoe UI", 30F)
        finalscore.Location = New Point(144, 674)
        finalscore.Name = "finalscore"
        finalscore.Size = New Size(43, 67)
        finalscore.TabIndex = 12
        finalscore.Text = " "
        finalscore.Visible = False
        ' 
        ' PictureBox1wall
        ' 
        PictureBox1wall.Image = My.Resources.Resources.purepng_com_sunsunlightrayssolar_1411527180926csoj9
        PictureBox1wall.Location = New Point(922, 12)
        PictureBox1wall.Name = "PictureBox1wall"
        PictureBox1wall.Size = New Size(164, 129)
        PictureBox1wall.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1wall.TabIndex = 13
        PictureBox1wall.TabStop = False
        ' 
        ' PictureBox3wall
        ' 
        PictureBox3wall.Image = My.Resources.Resources.purepng_com_sunsunlightrayssolar_1411527180926csoj9
        PictureBox3wall.Location = New Point(1457, 609)
        PictureBox3wall.Name = "PictureBox3wall"
        PictureBox3wall.Size = New Size(164, 129)
        PictureBox3wall.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3wall.TabIndex = 14
        PictureBox3wall.TabStop = False
        ' 
        ' PictureBox2wall
        ' 
        PictureBox2wall.Image = My.Resources.Resources.purepng_com_sunsunlightrayssolar_1411527180926csoj9
        PictureBox2wall.Location = New Point(943, 755)
        PictureBox2wall.Name = "PictureBox2wall"
        PictureBox2wall.Size = New Size(164, 129)
        PictureBox2wall.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2wall.TabIndex = 15
        PictureBox2wall.TabStop = False
        ' 
        ' PictureBox4wall
        ' 
        PictureBox4wall.Image = My.Resources.Resources.purepng_com_sunsunlightrayssolar_1411527180926csoj9
        PictureBox4wall.Location = New Point(386, 795)
        PictureBox4wall.Name = "PictureBox4wall"
        PictureBox4wall.Size = New Size(164, 129)
        PictureBox4wall.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4wall.TabIndex = 16
        PictureBox4wall.TabStop = False
        ' 
        ' astroid3
        ' 
        astroid3.Image = My.Resources.Resources._3df0c312d89ed5b_pngastroid
        astroid3.Location = New Point(604, 829)
        astroid3.Name = "astroid3"
        astroid3.Size = New Size(130, 130)
        astroid3.SizeMode = PictureBoxSizeMode.Zoom
        astroid3.TabIndex = 17
        astroid3.TabStop = False
        astroid3.Tag = "astroid"
        ' 
        ' resetlabeleasy
        ' 
        resetlabeleasy.AutoSize = True
        resetlabeleasy.Font = New Font("Segoe UI", 15F)
        resetlabeleasy.Location = New Point(13, 547)
        resetlabeleasy.Name = "resetlabeleasy"
        resetlabeleasy.Size = New Size(125, 35)
        resetlabeleasy.TabIndex = 18
        resetlabeleasy.Text = "reset easy"
        resetlabeleasy.Visible = False
        ' 
        ' resetlabelnormal
        ' 
        resetlabelnormal.AutoSize = True
        resetlabelnormal.Font = New Font("Segoe UI", 15F)
        resetlabelnormal.Location = New Point(13, 512)
        resetlabelnormal.Name = "resetlabelnormal"
        resetlabelnormal.Size = New Size(155, 35)
        resetlabelnormal.TabIndex = 19
        resetlabelnormal.Text = "reset normal"
        resetlabelnormal.Visible = False
        ' 
        ' resetlabelhard
        ' 
        resetlabelhard.AutoSize = True
        resetlabelhard.Font = New Font("Segoe UI", 15F)
        resetlabelhard.Location = New Point(13, 477)
        resetlabelhard.Name = "resetlabelhard"
        resetlabelhard.Size = New Size(127, 35)
        resetlabelhard.TabIndex = 20
        resetlabelhard.Text = "reset hard"
        resetlabelhard.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1924, 1055)
        Controls.Add(resetlabelhard)
        Controls.Add(resetlabelnormal)
        Controls.Add(resetlabeleasy)
        Controls.Add(astroid3)
        Controls.Add(PictureBox4wall)
        Controls.Add(PictureBox2wall)
        Controls.Add(PictureBox3wall)
        Controls.Add(PictureBox1wall)
        Controls.Add(finalscore)
        Controls.Add(scorelabel)
        Controls.Add(Label1)
        Controls.Add(enemy4)
        Controls.Add(platform2)
        Controls.Add(astroid2)
        Controls.Add(enemy3)
        Controls.Add(platform)
        Controls.Add(enemy2)
        Controls.Add(enemy)
        Controls.Add(astroid)
        Controls.Add(avatar)
        Name = "Form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(astroid, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(platform, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(astroid2, ComponentModel.ISupportInitialize).EndInit()
        CType(platform2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1wall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3wall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2wall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4wall, ComponentModel.ISupportInitialize).EndInit()
        CType(astroid3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents astroid As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents platform As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents astroid2 As PictureBox
    Friend WithEvents platform2 As PictureBox
    Friend WithEvents enemy4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scorelabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents finalscore As Label
    Friend WithEvents PictureBox1wall As PictureBox
    Friend WithEvents PictureBox3wall As PictureBox
    Friend WithEvents PictureBox2wall As PictureBox
    Friend WithEvents PictureBox4wall As PictureBox
    Friend WithEvents astroid3 As PictureBox
    Friend WithEvents resetlabeleasy As Label
    Friend WithEvents resetlabelnormal As Label
    Friend WithEvents resetlabelhard As Label

End Class
