Imports System.Runtime.CompilerServices

Public Class Form1
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)
    Dim score As Integer
    Dim m As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(enemy, avatar, 7 + m, 7 + m)
        follow(enemy2, avatar, 7 + m, 7 + m)
        PaceY(enemy3, platform, 5 + m)
        PaceX(enemy4, platform2, 5 + m)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, speedx As Integer, speedy As Integer)
        If e.Location.Y > a.Location.Y Then
            move(e, 0, -speedy)
        Else
            move(e, 0, speedy)
        End If
        If e.Location.X > a.Location.X Then
            move(e, -speedx, 0)
        Else
            move(e, speedx, 0)
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(avatar, -10, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(avatar, 10, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(avatar, 0, 10)
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Space Then
            avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        avatar.Refresh()
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(avatar, 0, -10)
        End If
        avatar.Refresh()
        If astroid.Visible = False And astroid2.Visible = False And astroid3.Visible = False Then
            Me.BackColor = Color.Green
            Label1.Visible = True
            Timer2.Enabled = False
            finalscore.Visible = True
            finalscore.Text = 112 + score
            resetlabeleasy.Visible = True
            resetlabelnormal.Visible = True
            resetlabelhard.Visible = True
            Timer1.Enabled = False
            resetlabeleasy.BackColor = Color.Green
            Label1.Text = "victory"
        End If
        If avatar.Visible = False Then
            finalscore.Text = "0"
            finalscore.Visible = True
            Timer2.Enabled = False
            resetlabeleasy.Visible = True
            resetlabelnormal.Visible = True
            resetlabelhard.Visible = True
            Timer1.Enabled = False
            Me.BackColor = Color.Red
            resetlabeleasy.BackColor = Color.Red
            Label1.Text = False
            Label1.Text = "loss"
        End If
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
        Dim z As PictureBox
        If IntersectsWith(avatar, "astroid", z) Then
            z.Visible = False
        End If
        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)
        If avatar.Bounds.IntersectsWith(astroid.Bounds) Then
            astroid.Visible = False
        End If
        If avatar.Bounds.IntersectsWith(astroid2.Bounds) Then
            astroid2.Visible = False
        End If
        If avatar.Bounds.IntersectsWith(astroid3.Bounds) Then
            astroid3.Visible = False
        End If
        If enemy.Bounds.IntersectsWith(avatar.Bounds) Then
            avatar.Visible = False
        End If
        If enemy2.Bounds.IntersectsWith(avatar.Bounds) Then
            avatar.Visible = False
        End If
        If enemy3.Bounds.IntersectsWith(avatar.Bounds) Then
            avatar.Visible = False
        End If
        If enemy4.Bounds.IntersectsWith(avatar.Bounds) Then
            avatar.Visible = False
        End If

    End Sub
    Function endingWith(s As String) As Collection
        Dim coll As New Collection
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If UCase(obj.Name).EndsWith(UCase(s)) Then
                    coll.Add(obj)
                End If
            End If
        Next
        Return coll
    End Function
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        score += -1
        scorelabel.Text = score * -1
    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub

    Private Sub resetlabel_Click_1(sender As Object, e As EventArgs) Handles resetlabeleasy.Click
        reset()
        m = -2
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles resetlabelnormal.Click
        reset()
        m = 0
    End Sub

    Private Sub resetlabelhard_Click(sender As Object, e As EventArgs) Handles resetlabelhard.Click
        reset()
        m = 5
    End Sub
    Sub reset()
        avatar.Location = New Point(12, 12)
        avatar.Visible = True
        enemy.Location = New Point(1092, 608)
        enemy2.Location = New Point(1092, 12)
        enemy3.Location = New Point(510, 241)
        enemy4.Location = New Point(510, 418)
        astroid.Visible = True
        astroid2.Visible = True
        astroid3.Visible = True
        Timer1.Enabled = True
        scorelabel.Text = ""
        Timer2.Enabled = True
        score = 0
        BackColor = Color.Black
        scorelabel.BackColor = Color.Black
        finalscore.Text = ""
        Label1.Visible = False
        resetlabeleasy.Visible = False
        resetlabelnormal.Visible = False
        resetlabelhard.Visible = False
    End Sub
End Class
