using System.Windows;
using System.Windows.Controls;
using WpfApp2.Pages;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsUserLoggedIn = false;

        public MainWindow()
        {
            InitializeComponent();
            MainContentFrame.Navigate(new LoginPage());
        }

        public void SetUserLoggedIn(bool isLoggedIn)
        {
            IsUserLoggedIn = isLoggedIn;
        }

        private void OnMainMenuClicked(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn)
            {
                MainContentFrame.Navigate(new MainPage());
            }
        }

        private void OnSettingsClicked(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn)
            {
                MainContentFrame.Navigate(new SettingsPage());
            }
        }


        private void OnProfileClicked(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn)
            {
                MainContentFrame.Navigate(new ProfilePage());
            }
        }

        private void OnBackClicked(object sender, RoutedEventArgs e)
        {
            if (MainContentFrame.CanGoBack)
            {
                MainContentFrame.GoBack();
            }
        }

        private void OnUsersClicked(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn)
            {
                MainContentFrame.Navigate(new UsersPage());
            }
        }

        private void OnAddArticleClicked(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn)
            {
                MainContentFrame.Navigate(new AddArticlePage());
            }
        }

        private void OnListArticlesClicked(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn)
            {
                MainContentFrame.Navigate(new ArticlesListPage());
            }
        }
    }
}
