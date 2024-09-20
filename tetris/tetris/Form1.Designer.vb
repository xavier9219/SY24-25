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
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(astroid, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = My.Resources.Resources._439_4392668_pixel_spaceship_png_pixel_spaceship
        avatar.Location = New Point(253, 12)
        avatar.Name = "avatar"
        avatar.Size = New Size(86, 88)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' astroid
        ' 
        astroid.Image = My.Resources.Resources._3df0c312d89ed5b_pngastroid
        astroid.Location = New Point(424, 194)
        astroid.Name = "astroid"
        astroid.Size = New Size(130, 130)
        astroid.SizeMode = PictureBoxSizeMode.Zoom
        astroid.TabIndex = 1
        astroid.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources._363116e7da047bd
        enemy.Location = New Point(100, 115)
        enemy.Name = "enemy"
        enemy.Size = New Size(181, 112)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = My.Resources.Resources._363116e7da047bd
        enemy2.Location = New Point(663, 319)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(181, 112)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1507, 750)
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents astroid As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class
