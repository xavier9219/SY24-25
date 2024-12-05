Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Santa.Visibility = Visibility.Visible
        Baseball.Visibility = Visibility.Hidden
        Mariners.Visibility = Visibility.Hidden
        Info.Content = "Santa is delivering presents, he is on a roof, he has 3 presents,he has no sliegh."
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Santa.Visibility = Visibility.Hidden
        Baseball.Visibility = Visibility.Visible
        Mariners.Visibility = Visibility.Hidden
        Info.Content = "the baseball is clean, it has 216 laces, it weighs 5.25 oz, and it has red laces."
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Santa.Visibility = Visibility.Hidden
        Baseball.Visibility = Visibility.Hidden
        Mariners.Visibility = Visibility.Visible
        Info.Content = "The Seattle Mariners have been part of Major League Baseball since 1977.
2.The Mariners have never won a World Series.
3.The Mariners have the record for longest time before posting a winning season.
4.The Mariners' home stadium is T-Mobile Park."
    End Sub
End Class
