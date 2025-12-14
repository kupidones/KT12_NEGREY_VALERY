private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
{
    var result = MessageBox.Show("Вы уверены, что хотите выйти?",
                                 "Подтверждение",
                                 MessageBoxButton.YesNo);
    e.Cancel = (result == MessageBoxResult.No);
}
