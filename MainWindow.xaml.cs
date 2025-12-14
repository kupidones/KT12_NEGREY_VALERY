using System.Windows;
namespace WpfNavigationDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOpenSecond_Click(object sender, RoutedEventArgs e)
        {
            var secondWindow = new SecondWindow();
            secondWindow.Owner = this;
            secondWindow.Show();
        }
    }
}
