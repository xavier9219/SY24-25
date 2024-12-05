Class MainWindow
    Private Sub fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles fill1.MouseDown, fill2.MouseDown, fill3.MouseDown, fill4.MouseDown, fill5.MouseDown, fill6.MouseDown, fill7.MouseDown, fill8.MouseDown
        brush1.Fill = sender.fill
    End Sub
End Class
