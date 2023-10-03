using System.Windows;
using System.Windows.Controls;
using WpfApp2.Models;
using WpfApp2.Pages;

namespace WpfApp2.Pages
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                Name = LoginTextBox.Text,
                Password = PasswordTextBox.Text
            };

            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.SetUserLoggedIn(true);
            mainWindow.MainContentFrame.Navigate(new MainPage());
        }
    }
}
