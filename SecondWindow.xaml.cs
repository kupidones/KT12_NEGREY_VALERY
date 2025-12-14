public string UserName { get; set; }

private void ReturnButton_Click(object sender, RoutedEventArgs e)
{
    UserName = "Пользователь";
    this.Close();
}
