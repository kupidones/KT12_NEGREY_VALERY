using System.Windows;
namespace WpfNavigationDemo
{
    public partial class SecondWindow : Window
    {
        public string UserName { get; set; }
        public SecondWindow()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            UserName = "Пользователь";
            this.Close();
        }
    }
}
