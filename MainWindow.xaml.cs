private void btnOpenSecond_Click(object sender, RoutedEventArgs e)
{
    var secondWindow = new SecondWindow();
    secondWindow.Owner = this;
    secondWindow.ShowDialog();
    var userName = secondWindow.UserName;
    MessageBox.Show($"Данные из второго окна: {userName}");
}
