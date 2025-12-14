using System.Windows;
namespace WpfNavigationDemo
{
    public partial class SecondWindow : Window
    {
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
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }
    }
}
