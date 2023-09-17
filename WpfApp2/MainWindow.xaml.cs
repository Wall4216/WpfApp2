using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContentFrame.Navigate(new MainPage());
        }

        private void OnMainMenuClicked(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new MainPage());
        }

        private void OnSettingsClicked(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new SettingsPage());
        }


        private void OnProfileClicked(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new ProfilePage());
        }

        private void OnBackClicked(object sender, RoutedEventArgs e)
        {
            if (MainContentFrame.CanGoBack)
            {
                MainContentFrame.GoBack();
            }
        }
    }
}
